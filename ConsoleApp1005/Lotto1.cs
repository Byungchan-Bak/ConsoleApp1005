using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class Lotto1
    {
        static void Main()
        {
            //int[] lotto = new int[6];
            List<int> lotto = new List<int>();
            Random rand = new Random();
            int i = 0;

            while(true)
            {
                
                int temp = rand.Next(1, 46);
                if (!lotto.Contains(temp))
                { lotto.Add(temp); }

                if(lotto.Count > 6)
                { break; }
                //lotto[i] = rand.Next(1, 46);
                //i++;

                /*
                if (i > 5)
                { break; }
                */
            }
        }
    }
}
