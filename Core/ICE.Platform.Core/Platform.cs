using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace ICE.Platform.Core
{
    using Attributes;
    using Structs;

    /// <summary>
    /// Provides a Platform level API for service discovery. Used to bootstrap applications
    /// </summary>
    public class Platform
    {
        public static string JunctionAssemblyName = "ICE.Platform.dll";        

        private static List<Type> TypeCache;

        private static IEnumerable<Assembly> LocalAssemblies
        {    
            get
            {
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies()) yield return assembly;                
            }            
        }

        private static List<Type> AllAccessibleTypes
        {
            get
            {
                if (TypeCache != null) return TypeCache;

                TypeCache = new List<Type>();

                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    Type[] types;

                    try
                    {
                        types = assembly.GetTypes();
                    }
                    catch (Exception e)
                    {
                        types = null;
                    }

                    if (types == null) continue;

                    foreach (Type type in types) TypeCache.Add(type);                    
                }

                return TypeCache;
            }
        }

        /// <summary>
        /// Gets a list of concrete triggers from the Platform
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Tuple<Type, Type>> GetTriggerMap()
        {            
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                foreach (var _interface in type.GetInterfaces())
                {
                    if (_interface.IsGenericType && _interface.GetGenericTypeDefinition() == typeof(IPlatformTrigger<>))
                    {
                        yield return new Tuple<Type, Type>(_interface, type);
                    }
                }
            }
        }

        /// <summary>
        /// Gets a list of service object / concrete pairs for dependency injection 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Tuple<Type, Type>> GetInjectableMap()
        {                        
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                if (type.GetCustomAttributes(typeof(InjectableAttribute), true).Length > 0)
                {
                    var meta = (InjectableAttribute)type.GetCustomAttributes(typeof(InjectableAttribute), true)[0];

                    yield return new Tuple<Type, Type>(meta.Interface, type);
                }
            }
        }

        /// <summary>
        /// Gets a list of concrete mutation types
        /// </summary>
        /// <typeparam name="E">PlatformEntity specific mutations</typeparam>
        /// <param name="mutationType">Filters responses to this type only</param>
        /// <returns></returns>
        public static IEnumerable<Type> GetMutationList<E>(MutationType mutationType) where E : IPlatformEntity
        {
            return GetMutationList(typeof(E), mutationType);
        }

        /// <summary>
        /// Gets a list of concrete mutation types
        /// </summary>
        /// <param name="entity">Mutations specific to this type</param>
        /// <param name="mutationType">Filters responses to this type only</param>
        /// <returns></returns>
        public static IEnumerable<Type> GetMutationList(Type entity, MutationType mutationType)
        {   
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                if (type.GetCustomAttributes(typeof(MutationAttribute), true).Length > 0)
                {
                    var meta = (MutationAttribute)type.GetCustomAttributes(typeof(MutationAttribute), true)[0];

                    if (meta.Type == mutationType && meta.Entity == entity)
                    {
                        yield return type;
                    }
                }
            }
        }

        /// <summary>
        /// Gets a list of concrete mutations for the mutation type specified
        /// </summary>
        /// <param name="mutationType"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetMutationList(MutationType mutationType)
        {    
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                if (type.GetCustomAttributes(typeof(MutationAttribute), true).Length > 0)
                {
                    var meta = (MutationAttribute)type.GetCustomAttributes(typeof(MutationAttribute), true)[0];

                    if (meta.Type == mutationType)
                    {
                        yield return type;
                    }
                }
            }
        }

        /// <summary>
        /// Gets a PlatformEntity type for the string name specified
        /// </summary>
        /// <param name="name">PlatformEntity Type name</param>
        /// <returns></returns>
        public static Type GetEntityForName(string name)
        {   
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                foreach (var _interface in type.GetInterfaces())
                {
                    if (_interface.Equals(typeof(IPlatformEntity)) && type.Name.ToUpper() == name.ToUpper())
                    {
                        return type;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a list of custom resources exposed by local assemblies
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Type> GetResourceList()
        {
            foreach (Type type in AllAccessibleTypes)
            {
                if (type.IsAbstract) continue;

                if (type.GetCustomAttributes(typeof(ResourceAttribute), true).Length > 0)
                {
                    yield return type;
                }
            }
        }

        /// <summary>
        /// Gets a single type for the fully qualified name provided
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static Type GetType(string fullName)
        {
            foreach (Type type in AllAccessibleTypes)
            {
                if(type.FullName == fullName)
                {
                    return type;
                }
            }

            return null;
        }
    }
}
