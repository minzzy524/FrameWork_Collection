using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex01_ArrayList
{
    class Program
    {
        public static void PrintValues(IEnumerable myList)
        {
            IList li =(IList)myList; // 다운 캐스팅 (Count 쓸라고)
            Console.WriteLine("Count : {0}", li.Count);

            foreach (Object obj in myList) { 
                Console.Write("   {0}", obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            // Collection 구현하고 있는 (상속) 대표적인 클래스
            // ArrayList
            // 동적으로 데이터 관리
            // using System.Collections; 아래 있는 자원

            // ArrayList 는 내부적으로 데이터를 Array로 관리한다.
            // ArrayList 의 단점 : 배열이기 때문에 중간에 추가하면 다 자리 옮겨야 한다.
            // 순차적으로 나열된 자원을 관리할 수 있는 클래스 (내부적으로는 배열)
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("ToString(): {0}",list.ToString());

            foreach (int to in list)
            {
                Console.WriteLine("to : {0}", to);
            }
            Console.WriteLine("list.Count : {0}", list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list:[{0}]", i);
            }

            Console.WriteLine("list ArrayList");
            Console.WriteLine("Count : {0}", list.Count); // 물병에 담긴 물의 양 
            Console.WriteLine("Capacity : {0}", list.Capacity); // 물병의 전체 용량 // Count 값 보다는 크다 


            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy"); // remove로 지워보자
            myAL.Add("dog");  // 빈 자리 메꿔서 앞으로 땡겨 앉는다!!!

            // Displays the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL);

            // Removes the element containing "lazy".
            myAL.Remove("lazy");

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing \"lazy\":");
            PrintValues(myAL);

            // Removes the element at index 5. // 5번 째 인덱스 날려라
            myAL.RemoveAt(5);

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing the element at index 5:");
            PrintValues(myAL);

            // Removes three elements starting at index 4.
            myAL.RemoveRange(4, 3);

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing three elements starting at index 4:");
            PrintValues(myAL);
        }

        // 0311 16:00 test

    }
}

