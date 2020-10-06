using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class HashTable1
    {
        static  void Main()
        {
            //Hashtable ht = new Hashtable();
            SortedList ht = new SortedList();   //key값을 기준으로 정렬이 되어 HashTable됨.
            ht.Add("홍길동", 25);
            ht.Add("박길동", 20);
            ht.Add("김길동", 21);
            ht.Add("고길동", 42);
            ht.Add("최길동", 24);

            if(!ht.ContainsKey("홍길동"))
            { ht.Add("홍길동", 32); } //key값이 같을경우 오류발생 -->> ContainsKey함수로 중복체크 후 없으면 입력

            foreach (string key in ht.Keys)
            { Console.WriteLine($"{key} - {ht[key]}"); }    //순서가 무작위로 출력

            int age = (int)ht["박길동"];
            Console.WriteLine(age);
        }
    }
}
