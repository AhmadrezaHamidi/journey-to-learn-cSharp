using System;
using System.Collections.Generic;

namespace _0_1_Arrayes
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new string[4];
            name[0] = "Ahmad";
            name[1] = "Vali";
            name[2] = "Taqi";
            for (var i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }
            var names = new string[] { "Ahmad", "Taqi", "NAqi", "vali" };
            foreach (var item in names)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"The size of this array is equal white {names.Length}");



            var cars = new string[4];
            for (var i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine($"write the {i + 1} of our states ");
                cars[0] = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Give me index for remmoving !!");
            //we dont have remove at and index of in arrayes of c sahrp 
            System.Console.WriteLine("Give me index for remmoving !!");

            ///List 
            string[] authors = { "Mike Gold", "Don Box",
                        "Sundar Lal", "Neel Beniwal" };
            List<string> authorsRange = new List<string>(authors);
            foreach (var item in authorsRange)
            {
                System.Console.WriteLine(item);
            }
            //For insert data in our data base 
            System.Console.WriteLine("Give me a data to nsert in list ");
            authorsRange.Add(Console.ReadLine());

            System.Console.WriteLine("Give me datas to nsert in list ");
            var vars = new List<string>();
            for (var i = 0; i < 4; i++)
            {
                vars.Add(Console.ReadLine());
            }
            authorsRange.AddRange(vars);



            //for remove data  
            ///this is our data which item  you want to remove 
            foreach (var item in authorsRange)
            {
                System.Console.WriteLine(item);
            }
            var index = Convert.ToInt32(Console.ReadLine());
            authorsRange.RemoveAt(index);
            authorsRange.RemoveRange(0, 2);
            ///For Remow One element 
            authorsRange.RemoveAll(x => x.Equals("Don Box"));


            ///For Delte All contant  
            authorsRange.Clear();
            foreach (var item in authorsRange)
            {
                System.Console.WriteLine(item);
            }
            ////We can declare class and Maike Mehod look like Arrays class 
            var array = new Arrays(authors);
            var res = array.conternt();
            foreach (var item in res)
                System.Console.WriteLine(item);

            System.Console.WriteLine("---------------------------------------------");
            foreach (var item in authors)
                System.Console.WriteLine(item);

            var arraye = new ArrayFeather(authors, "Ahmadrezas");
            var rest = arraye.insertTo();
            foreach (var item in rest)
                System.Console.WriteLine(item);
            System.Console.WriteLine("--------------------------object array-------------------");


            // Creating and initializing
            // object array
            object[] arr = new object[6];

            arr[0] = 3.899;
            arr[1] = 3;
            arr[2] = 'g';
            arr[3] = "Geeks";

            // it will display
            // nothing in output
            arr[4] = null;

            // it will show System.Object
            // in output
            arr[5] = new object();

            // Display the element of
            // an object array
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            System.Console.WriteLine("--------------------------Remove From index -------------------");
            var arate = new ArrayFeather(authors);
            var a = arate.DeleteByIndex(1);
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            } 

        }
    }
    public class Arrays
    {
        private readonly string[] item;
        public Arrays(string[] input)
        {
            item = input;
        }
        public string[] conternt()
        {
            var result = new string[item.Length];
            for (var i = 0; i < item.Length; i++)
            {
                result[i] = item[i];
            }
            return result;
        }
    }

}