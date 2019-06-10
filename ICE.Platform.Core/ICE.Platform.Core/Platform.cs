using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    using Attributes;
    using Structs;

    public class Platform
    {
        public static IEnumerable<Tuple<Type, Type>> GetTriggerMap()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
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
        }

        public static IEnumerable<Tuple<Type, Type>> GetInjectableMap()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsAbstract) continue;

                    if (type.GetCustomAttributes(typeof(InjectableAttribute), true).Length > 0)
                    {
                        var meta = (InjectableAttribute)type.GetCustomAttributes(typeof(InjectableAttribute), true)[0];

                        yield return new Tuple<Type, Type>(meta.Interface, type);
                    }
                }
            }
        }

        public static IEnumerable<Type> GetMutationList<E>(MutationType mutationType) where E : IPlatformEntity
        {
            return GetMutationList(typeof(E), mutationType);
        }

        public static IEnumerable<Type> GetMutationList(Type entity, MutationType mutationType)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
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
        }

        public static Type GetEntityForName(string name)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
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
            }

            return null;
        }

        public static IEnumerable<Type> GetResourceList()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsAbstract) continue;

                    if (type.GetCustomAttributes(typeof(ResourceAttribute), true).Length > 0)
                    {
                        yield return type;
                    }
                }
            }
        }
    }
}
