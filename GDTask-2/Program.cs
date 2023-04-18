using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_2
{
    internal class Program
    {
        static int getTask2(object[] array ) {
            int answer = 0;
            
            foreach(var item in array)
            {
                if (item is String) 
                {
                    answer--;
                    continue;
                }
                answer += (int)item;
            }
            return answer;

        }
        static void Main(string[] args)
        {
            object[] array = { };
            Console.WriteLine(getTask2(array));
            Console.ReadLine();
        }
    }
}
