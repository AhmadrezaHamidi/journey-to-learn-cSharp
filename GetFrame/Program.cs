// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//' "One practical example of this code is when your program displays an error and you don't know where the error occurred" is that when your program encounters an error and you are not sure which part of the program caused it, you can use the StackTrace class and the GetFrame method to trace the error
//    and identify the part of the program that caused the error.

try
{
    throw new Exception();
}
catch (Exception ex)
{
    Console.WriteLine("Error message: {0}", ex.Message);
    Console.WriteLine("Stack trace: {0}", ex.StackTrace);
}

