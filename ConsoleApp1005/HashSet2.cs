using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashSet2
    {
        static void Main()
        {
            HashSet<string> sets = new HashSet<string>();
            sets.Add("홍길동");
            sets.Add("최길동");
            sets.Add("홍길동");
            Console.WriteLine(sets.Count);//count -->> 2

            HashSet<PhoneInfo> persons = new HashSet<PhoneInfo>();
            persons.Add(new PhoneInfo("홍길동"));
            persons.Add(new PhoneInfo("최길동"));
            persons.Add(new PhoneInfo("홍길동"));
            Console.WriteLine(persons.Count);//count -->> GetHashCode재정의 전 : 3, 후 : 2

        }
    }
}
