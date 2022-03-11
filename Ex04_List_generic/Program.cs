using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_List_generic
{
    // ArrayList가 Object 타입을 가지고 노는 것에 대한 반기 >> casting (반환)

    // C# ArrayList list = new ArrayList<int>
    // C# List<int> list = new List<int>
    class Account {
        public string num;
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //타입 강제
          //list.Add("가"); 가 안된다.

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (int item in list)
            {
                Console.WriteLine("Item : {0}", item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Item : {0}", list[i]);
            }

            List<bool> list2 = new List<bool>();
            list2.Add(true);
            list2.Add(false);
            Console.WriteLine(list2.Count);
            list2.Clear();
            Console.WriteLine("clear : {0}", list2.Count);

            // 연습
            int[] array = { 10, 20, 30 };
            List<int> list3 = new List<int>(array); // Enumerable 구현하고 있는 하위 자원 올 수 있다. (다형성)
            Console.WriteLine(list3.Count);
        }
    }
}
