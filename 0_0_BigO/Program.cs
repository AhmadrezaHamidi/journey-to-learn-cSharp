using System;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            //Big O 
            //O(1)
            Console.WriteLine("Hello World!"); //O(1)
            #endregion


            #region 
            //O(1) +  //O(n) + O(1) 
            //O(2)+O(n)
            System.Console.WriteLine("Hello word ");//O(1)
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };//O(n)
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Hello word ");//O(1)
            #endregion


            #region 
            //O(n+m)
            string[] Name = { "Masih", "Mohammad", "Vali", "Taqi" };//O(n)
            //O(n)
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }
            //O(m)
            foreach (var item in Name)
            {
                System.Console.WriteLine(item);
            }
            #endregion



            #region 
            //O(n * n)
            //O(n ^ 2)
            foreach (var item in Name) //O(n)
            {
                foreach (var itemm in cars)//O(n)
                {
                    System.Console.WriteLine($"{item} {itemm}");
                }
            }
            #endregion


            #region 
            //O(n * n)
            //O(n ^ 2)

            foreach (var item in Name) //O(n)
            {
                foreach (var itemm in cars)//O(n)
                {
                    System.Console.WriteLine($"{item} {itemm}");
                }
            }
            #endregion



            #region 
            ///o(N + N^2)
            foreach (var item in Name)//O(n)
            {
                System.Console.WriteLine(item);
            }
            //O(n * n)
            //O(n ^ 2)
            foreach (var item in Name) //O(n)
            {
                foreach (var itemm in cars)//O(n)
                {
                    System.Console.WriteLine($"{item} {itemm}");
                }
            }
            #endregion



            #region 
            //O(n * n * n)
            //O(n ^ 3)

            foreach (var item in Name) //O(n)
            {
                foreach (var itemm in cars)//O(n)
                {
                    foreach (var itemmm in Name) //O(n)
                    {

                        System.Console.WriteLine($"{item} {itemm}");
                    }
                }
            }
            #endregion


            #region 
            //Difference Between Linear Search and Binary Search
            //Definition
            // Linear search is an algorithm to find an element in a list by sequentially checking the elements of the list until finding the matching element.Binary search is an algorithm that finds the position of a target value within a sorted array. Thus, 
            // this is the main difference between linear search and binary search.
            #endregion




        }
    }
}
