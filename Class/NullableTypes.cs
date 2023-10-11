using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Class
{
//    Nullable types
//Variables of any type may be declared as non-nullable or nullable.A nullable
//        variable can hold an additional null value,
//        indicating no value.Nullable Value types(structs or enums)
//        are represented by System.Nullable<T>.Non-nullable 
//            and Nullable Reference types are both represented by the underlying reference type.
//            The distinction is represented by metadata read by the compiler and some libraries.
//            The compiler provides warnings when nullable references are dereferenced without first checking their value against null.
//            The compiler also provides warnings when non-nullable references are assigned a value that may be null. The following example declares a nullable int, initializing it to null. Then, it sets the value to 5. It demonstrates the same concept with a nullable string. For more information, see nullable value types and nullable reference types.

    internal class NullableTypes
    {
        public int IntWitheOutNUll { get; set; }
        public int? IntWitheNUll { get; set; }

    }




    //Tuples
    //C# supports tuples, which provides concise syntax to group multiple data elements in a lightweight data structure.
    //You instantiate a tuple by declaring the types and names of the members between ( and ), as shown in the following example:
    public class TupeClass
    {
        public (double Sum, int Count) claculate(double Sum, int Count)
        {
            return (Sum + 2, Count - 1);
        }

    }


}
