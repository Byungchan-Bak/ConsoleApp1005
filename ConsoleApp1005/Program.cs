using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1005
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            const int count = 5;
            //5명의 이름을 받고, 출력
            string[] name = new string[count];

            for(int i = 0; i < name.Length; i++)
            {
                Console.Write("이름 : ");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("입력된 이름");
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //5명의 이름과 전화번호를 입력받고, 출력
            string[,] personArr = new string[5, 2];

            for (int i = 0; i < personArr.GetLength(0); i++)    //1차 배열의 크기 -->> 5
            {
                Console.Write("이름 : ");
                personArr[i, 0] = Console.ReadLine();

                Console.Write("번호 : ");
                personArr[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < personArr.GetLength(0); i++)    //1차 배열의 크기 -->> 5
            {
                Console.WriteLine($"{personArr[i, 0]}님의 전화번호는 {personArr[i, 1]}입니다.");
            }

            //5명의 이름과 전화번호, 생일을 입력받고, 출력
            PhoneInfo[] pArr = new PhoneInfo[5];
            for(int i = 0; i < pArr.Length; i++)
            {
                PhoneInfo info = new PhoneInfo();

                Console.Write("이름 : ");
                info.Name = Console.ReadLine();
                Console.Write("번호 : ");
                info.Phone = Console.ReadLine();
                Console.Write("생일 : ");
                info.Birth = Console.ReadLine();

                pArr[i] = info;
            }
            foreach(PhoneInfo info in pArr)
            {
                Console.WriteLine($"{info.Name} / {info.Phone} / {info.Birth}");
            }
            */            
            ArrayList infoList = new ArrayList();

            while (true)
            {
                PhoneInfo info = new PhoneInfo();
                Console.Write("이름 : ");
                info.Name = Console.ReadLine();
                Console.Write("번호 : ");
                info.Phone = Console.ReadLine();
                Console.Write("생일 : ");
                info.Birth = Console.ReadLine();

                infoList.Add(info);
                //infoList.Add(100);  //데이터 타입에 맞지 않는 값 입력 -->> 출력 시 오류

                Console.Write("다시?(y or n) : ");
                if(Console.ReadLine().ToUpper() == "N")
                { break; }
            }
            foreach(PhoneInfo print in infoList)
            {
                Console.WriteLine($"{print.Name} // {print.Phone} // {print.Birth}");
            }

            List<PhoneInfo> pinfoList = new List<PhoneInfo>();
            while(true)
            {
                PhoneInfo info = new PhoneInfo();
                Console.Write("이름 : ");
                info.Name = Console.ReadLine();
                Console.Write("번호 : ");
                info.Phone = Console.ReadLine();
                Console.Write("생일 : ");
                info.Birth = Console.ReadLine();

                pinfoList.Add(info);
                //pinfoList.Add(100); //데이터 타입에 맞지 않은 값을 입력하면 사전에 오류검출

                Console.Write("다시?(y or n) : ");
                if (Console.ReadLine().ToUpper() == "n")
                { break; }
            }
            foreach (PhoneInfo print in pinfoList)
            {
                Console.WriteLine($"{print.Name} // {print.Phone} // {print.Birth}");
            }

            ArrayList alist = new ArrayList();
            alist.Add("사과");
            alist.Add("딸기");
            alist.Add("참외");
            alist.Add("수박");

            Console.WriteLine(alist.Count);
            for(int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine(alist[i]);
            }
        }
    }

    public class PhoneInfo : IComparable
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Birth { get; set; }

        public PhoneInfo()
        {

        }

        public PhoneInfo(string name)
        {
            Name = name;
        }

        public int CompareTo(object obj)
        {
            PhoneInfo info = (PhoneInfo)obj;
            return this.Name.CompareTo(info.Name);
        }

        public override bool Equals(object obj) //사용자 정의 클래스의 비교 기준 생성
        {
            return obj is PhoneInfo info &&
                   Name == info.Name;
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }


}
