using System;
using System.Linq;
using System.Reflection;

namespace PatternLibrary.ImmutableObjectConvention
{
    public class ImmutableObjectConventionTest
    {
        public void Test(Type type)
        {
            const BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static |
                                              BindingFlags.NonPublic | BindingFlags.Public;

            FieldInfo fieldInfo;
            if ((fieldInfo = type
                .GetFields(bindingFlags)
                .FirstOrDefault(field => !field.IsInitOnly)) != null)
            {
                throw new ArgumentException($"Type argument contains field that is not readonly: {fieldInfo.Name}");
            }
            PropertyInfo propertyInfo;
            if ((propertyInfo = type
                .GetProperties(bindingFlags)
                .FirstOrDefault(property => property.CanWrite)) != null)
            {
                throw new ArgumentException($"Type argument contains property that is writeable (setter): {propertyInfo.Name}");
            }
        }

        public void Test<T>() {
            Test(typeof(T));
        }
    }
}
