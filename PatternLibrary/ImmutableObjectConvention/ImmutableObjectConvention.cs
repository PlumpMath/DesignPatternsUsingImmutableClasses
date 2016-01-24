using System;
using System.Linq;
using System.Reflection;

namespace PatternLibrary.ImmutableObjectConvention
{
    public class ImmutableObjectConventionTest<T>
    {
        public void Test() {
            var bindingFlags = 
                BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public;

            FieldInfo fieldInfo;
            if((fieldInfo = typeof(T)
                .GetFields(bindingFlags)
                .FirstOrDefault(field => !field.IsInitOnly)) != null)
            {
                throw new ArgumentException($"Type argument contains field that is not readonly: {fieldInfo.Name}");
            }
            PropertyInfo propertyInfo;
            if((propertyInfo = typeof(T)
                .GetProperties(bindingFlags)
                .FirstOrDefault(property => property.CanWrite)) != null)
            {
                throw new ArgumentException($"Type argument contains property that is writeable (setter): {propertyInfo.Name}");
            }
        }
    }
}
