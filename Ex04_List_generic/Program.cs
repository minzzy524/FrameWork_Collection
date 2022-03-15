using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_List_generic
{
    //ArrayList 가  Object 타입을 가지고 노는 것에 대한 반기  >> casting (반환)
    //JAVA : ArrayList<int> list = new ArrayList<int>();
    //JAVA : interface   List<int> list = new ArrayList<int>();  다형성


    //C# ArrayList list = new ArrayList();  list.add(Object)
    //C#  List<int> list = new List<int>(); list.add(int) // 결국 이거 쓴다!!

    class Account
    {
        public string num;
        public string name;


        public Account(string num, string name)
        {
            this.num = num;
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //타입강제 
            //list.Add("가"); (x)
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (int item in list)
            {
                Console.WriteLine("item:{0}", item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("item:{0}", list[i]);
            }

            List<bool> list2 = new List<bool>();
            list2.Add(true);
            list2.Add(false);
            Console.WriteLine(list2.Count);
            list2.Clear();
            Console.WriteLine("Clear:{0}", list2.Count);


            //연습
            int[] array = { 10, 20, 30 };

            List<int> list3 = new List<int>(array);  //IEnumerable 구현하고 하위자원 올수 있다 (다형성)
            Console.WriteLine(list3.Count);

            //사용 @@@ 이게 제일 중요해 @@@
            List<Account> list4 = new List<Account>();
            list4.Add(new Account("111", "홍길동"));
            list4.Add(new Account("222", "김유신"));
            list4.Add(new Account("333", "아무개"));

            // foreach (Account account in list)
            //{
            //    Console.WriteLine("번호 : {0} , 이름 : {1}", ((Account)account).num, ((Account)account).name);
            //}

            //  ((Account)account).num   개발자가 너무 싫어 해요

            foreach (Account account in list4)
            {
                Console.WriteLine("번호 : {0} , 이름 : {1}", account.num, account.name);
            }

        }
    }
}