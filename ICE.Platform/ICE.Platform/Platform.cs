using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform
{
    public class Platform
    {
        public static IPlatformDAL DAL;

        public static void AddDAL(IPlatformDAL platformDAL)
        {
            DAL = platformDAL;
        }

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
    }
}
