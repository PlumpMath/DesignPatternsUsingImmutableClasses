using System;
using PatternLibrary.ImmutableObjectConvention;

namespace ImmutableObjectConvention
{
    public class Program
    {
        //uncomment any field/property/mutator for exception on start
        public class MutableObject
        {
            //public static string PublicStaticStringField;
            //private static string PrivateStaticStringField;

            //public static string PublicStaticStringProperty { get; set; }
            //public static string PublicStaticStringPropertyWithPrivateSetter { get; private set; }
            //private static string PrivateStaticStringProperty { get; set; }

            //public string PublicString;
            //private string PrivateString;

            //public string PublicStringProperty { get; set; }
            public string PublicStringPropertyWithPrivateSetter
            {
                get { return "PublicStringInMutableObj"; }
                //private set;
            }

            private string PrivateStringProperty { get;
                //set;
            }

            //public const string PUBLIC_CONST_STRING = "PublicConstString";
            //private const string PRIVATE_CONST_STRING = "PrivateConstString";

            public static readonly string PublicStaticReadonlyString = "Const";
            public readonly string PublicReadOnlyStringField = "PublicReadOnlyStringField";
            private readonly string PrivateReadOnlyStringField = "PrivateReadOnlyStringField";
        }

        public static void Main()
        {
            try {
                new ImmutableObjectConventionTest().Test<MutableObject>();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
