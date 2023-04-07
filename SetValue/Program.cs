// See https://aka.ms/new-console-template for more information
using System.Reflection;
using SetValue;

Console.WriteLine("Hello, World!");



// ایجاد یک شیء از کلاس Person
Person myPerson = new Person();

// دریافت نوع شیء
Type type = myPerson.GetType();

// دریافت ویژگی Name
PropertyInfo prop = type.GetProperty("Name");

// تغییر مقدار ویژگی Name به "Mike"
prop.SetValue(myPerson, "Mike");





Console.WriteLine(myPerson.Name);
