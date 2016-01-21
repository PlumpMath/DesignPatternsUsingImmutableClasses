using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Toolkit
{
    public static class DeepCloneExtension
    {
        public static T DeepClone<T>(this T obj)
            where T : class
        {
            //Shallow copy
            MethodInfo memberwiseCloneMethod = obj.GetType().GetMethod("MemberwiseClone",
                BindingFlags.NonPublic | BindingFlags.Instance);
            var returnData = (T)memberwiseCloneMethod.Invoke(obj, new object[] { });
            
            Type type = returnData.GetType();
            //Make deep copy of each field
            FieldInfo[] fieldInfoArray = type.GetFields();
            foreach (FieldInfo fieldInfo in fieldInfoArray)
            {
                object sourceFieldValue = fieldInfo.GetValue(obj);
                var sourceData = sourceFieldValue;
                fieldInfo.SetValue(returnData, sourceData.DeepClone());
            }
            return returnData;
        }

    }
}
