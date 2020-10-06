using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
    class ArrayList1
    {
        static void Main()
        {
            PhoneInfo info = new PhoneInfo();
            info.Name = "홍길동";
            info.Phone = "010-1234-5678";
            ArrayList alist = new ArrayList();
            alist.Add("사과");
            alist.Add("딸기");
            alist.Add("참외");
            alist.Add("수박");
            alist.Add(123);
            alist.Add(info);
            alist.Insert(0, "포도");  //해당 index위치에 입력하고 배열은 자동으로 늘어남

            Console.WriteLine(alist.Count);
            alist.Remove("딸기"); //alist[1] -->> 데이터 삭제 후 뒤에 있는 배열이 자동으로 채움
            alist.RemoveAt(2);  //배열의 해당 index데이터를 삭제
            alist.Clear();  //데이터 전체 삭제
            Console.WriteLine(alist.Count);

            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i] is PhoneInfo)  //데이터 타입이 PhoneInfo일 경우
                {
                    Console.WriteLine(((PhoneInfo)alist[i]).Name);  //형변환하여 출력
                }
                else
                {
                    Console.WriteLine(alist[i]);
                }
            }
        }
    }
}
