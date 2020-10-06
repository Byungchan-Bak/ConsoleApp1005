using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class ArrayList2
    {
        static void Main()
        { 
            ArrayList list = new ArrayList();

            list.Add(new PhoneInfo("홍길동"));
            list.Add(new PhoneInfo("김길동"));
            list.Add(new PhoneInfo("박길동"));
            list.Add(new PhoneInfo("이길동"));

            list.Sort();

            foreach(PhoneInfo info in list)
            {
                Console.WriteLine(info.Name);
            }
        }
    }
}
