using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class NumReader
    {
        public delegate void NumReaderDelegate(int num, List<string> nameList);
        public event NumReaderDelegate NumEnteredEvent;
        /// <summary>
        /// Получет число из консоли
        /// </summary>
        /// <param name="nameList"></param>
        /// <exception cref="MyException"></exception>
        public void Read(List<string> nameList)
        {
            Console.WriteLine();
            Console.WriteLine("Enter : 1 for A-Z or 2 for Z-A sort");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != 1 && num != 2) throw new MyException("Its not 1 or 2, try again!");
            NumEnteredEvent?.Invoke(num, nameList);
        }
    }
}
