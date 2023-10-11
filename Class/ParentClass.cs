using Class;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Class
{



//    Classes are the most fundamental of C#'s types. A class is a data structure that combines state (fields) and actions (methods and other function members) in a single unit. A class provides a definition for instances of the class, also known as objects. Classes support inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.

//New classes are created using class declarations. A class declaration starts with a header.The header specifies:

//The attributes and modifiers of the class
//The name of the class
//The base class (when inheriting from a base class)
//The interfaces implemented by the class.
//The header is followed by the class body, which consists of a list of member declarations written between the delimiters { and }.

//The following code shows a declaration of a simple class named Point:

//C#

//Copy
//public class Point
//    {
//        public int X { get; }
//        public int Y { get; }

//        public Point(int x, int y) => (X, Y) = (x, y);
//    }
//    Instances of classes are created using the new operator, which allocates memory for a new instance, invokes a constructor to initialize the instance, and returns a reference to the instance.The following statements create two Point objects and store references to those objects in two variables:

//C#

//Copy
//var p1 = new Point(0, 0);
//    var p2 = new Point(10, 20);
//    The memory occupied by an object is automatically reclaimed when the object is no longer reachable.It's not necessary or possible to explicitly deallocate objects in C#.

//C#

//Copy
//var p1 = new Point(0, 0);
//    var p2 = new Point(10, 20);
//    Applications or tests for algorithms might need to create multiple Point objects.The following class generates a sequence of random points.The number of points is set by the primary constructor parameter.The primary constructor parameter numberOfPoints is in scope for all members of the class:
//    C#

//Copy
//public class PointFactory(int numberOfPoints)
//{
//    public IEnumerable<Point> CreatePoints()
//    {
//        var generator = new Random();
//        for (int i = 0; i < numberOfPoints; i++)
//        {
//            yield return new Point(generator.Next(), generator.Next());
//        }
//    }
//}
//You can use the class as shown in the following code:

//C#

//Copy
//var factory = new PointFactory(10);
//foreach (var point in factory.CreatePoints())
//{
//    Console.WriteLine($"({point.X}, {point.Y})");
//}
internal class ParentClass
{
}
public interface IntefaceA
{
    public string CalcuLateA();
    public int CalcuLate();
}
public interface IntefaceB
{
    public string CalcuLateB();
    public int CalcuLate();

    }
}
