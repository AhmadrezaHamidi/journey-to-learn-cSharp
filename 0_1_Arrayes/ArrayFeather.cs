using System;

namespace _0_1_Arrayes
{
    public class ArrayFeather
    {
        private readonly string[] item;
        private readonly string insertItem;
        private readonly int countOfNewArray;

        public ArrayFeather(string[] OldArray, string ItemForINPut)
        {
            item = OldArray;
            insertItem = ItemForINPut;
            countOfNewArray = OldArray.Length + 1;
        }
        public ArrayFeather(string[] OldArray)
        {
            item = OldArray;
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
        public string[] insertTo()
        {
            var result = new string[countOfNewArray];

            for (int i = 0; i < countOfNewArray; i++)
            {
                if (i == countOfNewArray - 1)
                    result[i] = insertItem;
                else
                    result[i] = item[i];
            }
            return result;
        }
        public string[] DeleteByIndex(int index)
        {
            if (index < 0 || index > item.Length)
                throw new Exception("Mistake");
            ///MA mikhym ke on indeco pak kone Tosh pas mishe 
            var result = new string[item.Length - 1];
            int flag = 0;
            for (int i = 0; i < item.Length; i++)
            {
                if (i == index)
                {
                    flag++;
                    continue;
                }
                else
                    result[i - flag] = item[i];
            }
            return result;
        }
    }

}