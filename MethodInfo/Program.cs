// See https://aka.ms/new-console-template for more information
using System.Reflection;
using MethodInfo;

Console.WriteLine("Hello, World!");



Calculator calculator = new Calculator();
Type calculatorType = calculator.GetType();
string methodName = "Add";
var method = calculatorType.GetMethod(methodName);
object[] parameters = new object[] { 5, 10 };
int result = (int)method.Invoke(calculator, parameters);
Console.WriteLine("Result: " + result);
