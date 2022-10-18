using System.Collections;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] ex =
            {
                new MyException("MyException"),
                new ArgumentException(),
                new ArgumentNullException(),
                new FormatException(),
                new RankException(),
            };

            for (int i = 0; i < ex.Length; i++)
            {
                try { throw ex[i]; }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            Console.WriteLine();

            var nameList = new List<string>
            {
                "Putin",
                "Zelenskiy",
                "Biden",
                "Erdogan",
                "Wasserman"
            };

            var num = new NumReader();
            num.NumEnteredEvent += SortList;
            num.NumEnteredEvent += Print;
            while (true)
            {
                try { num.Read(nameList); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
        /// <summary>
        /// Сортирует список имен
        /// </summary>
        /// <param name="num"></param>
        /// <param name="nameList"></param>
        static void SortList(int num, List<string> nameList)
        {
            if (num == 1) { nameList.Sort(); }
            else if (num == 2) { nameList.Sort(); nameList.Reverse(); }

        }
        /// <summary>
        /// Выводит в консоль список имен
        /// </summary>
        /// <param name="number"></param>
        /// <param name="nameList"></param>
        static void Print(int number, List<string> nameList)
        {
            string a = "";
            if (number == 1) { a = "Sorted from A-Z"; }
            else if (number == 2) { a = "Sorted from Z-A"; }

            Console.WriteLine();

            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}