using SMS_Service.Repository.Implementation;
using System;
using System.Collections.Generic;

namespace SMS_Service.Repository.Injection
{
    public class Injector
    {
        private static Dictionary<Type, object> _implementations = new Dictionary<Type, object>()
        {
            { typeof(IStudentRepository), new StudentRepository() },
            { typeof(IScholarshipRepository), new ScholarshipRepository() },
            { typeof(IScholarshipApplicationRepository), new ScholarshipApplicationRepository() }
        };

        public static T CreateInstance<T>()
        {
            Type type = typeof(T);

            if (Injector._implementations.ContainsKey(type))
            {
                return (T)Injector._implementations[type];
            }

            throw new ArgumentException($"No implementation found for type {type}");
            return default(T);
        }
    }
}