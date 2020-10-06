using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashSet1
    {
        static void Main()
        {
            HashSet<int> lotto = new HashSet<int>();    //같은 값을 입력 시 무시함.
            Random rand = new Random();

            while(true)
            {
                lotto.Add(rand.Next(1, 46));

                if (lotto.Count > 6)
                { break; }
            }

            int[] a_lotto = lotto.ToArray<int>();
            Array.Sort(a_lotto);
            for(int i = 0; i < lotto.Count(); i++)
            {
                Console.Write(a_lotto[i] + "  ");
            }
            foreach(int temp in a_lotto)
            {
                Console.Write(temp + "  ");
            }
        }
    }
}
