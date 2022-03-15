using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 추가해줘야 제네릭보다 컬렉션이 먼저 나와

namespace Ex06_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            List<string> list2 = new List<string>();

            // Stack (FILO) 먼저 들어간 것이 나중에 빠진다
            Stack stack = new Stack();
            stack.Push("aaa");
            stack.Push("bbb");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Pop()); // 더 없는데 뭘 꺼내... 이러면 예외 발생


            Stack<int> stack2 = new Stack<int>();
            stack2.Push(1);
            stack2.Push(1);
            stack2.Push(1); // 중복값 들어가도 된다. 인덱스[0],[1],[2] 가지고 찾으니까


            // Queue (FIFO) 먼저 들어간 것이 먼저 빠진다
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            //Console.WriteLine(queue.Dequeue()); // 더 없는데 뭘 꺼내... 이러면 예외 발생

            Queue<string> queue2 = new Queue<string>();

            
            Hashtable ht = new Hashtable();
            ht.Add("A", "사과는 맛있어");
            ht.Add("B", "바나나는 맛있어");
            ht.Add("O", "오렌지는 맛있어");

            // ht.Add("O", "오렌지는 맛있어"); // 키 값은 중복 데이터를 갖지 않는다

            Console.WriteLine(ht.ContainsKey("O")); // 너 O 라는 키 있니? 예
            ICollection ic = ht.Keys; // 프로퍼티(get)가 내부적으로 new list() 객체를 생성하고 주소값을 리턴
            foreach (string key in ic) 
            {
                Console.WriteLine(key);
            }

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("[key : {0}, value : {1}]", item.Key, item.Value);
            }
            
            // key와 value를 한번에 보고 싶다면?
            Dictionary<string, string> ht2 = new Dictionary<string, string>();

            ht2.Add("A", "사과는 맛있어");
            ht2.Add("B", "바나나는 맛있어");
            ht2.Add("O", "오렌지는 맛있어");

            foreach (KeyValuePair<string, string> item in ht2)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
            }

            // 개발에서는 var
            foreach (var item in ht2)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, item.Value);
            }

            ////////////////////////////////////////////////////////
            // 게시판  댓글
            /*
              1, 홍길동 , 방가방가
              2, 김유신 , 방가

              댓글
              1 , 1 , 나도 방가
              2 , 1 , 정말 방가 

              Dictionary<1, List<>>
             */
            // 1. List<>
            // 2. Dictionary<,>


            // 내부적으로 데이터가 들어올 때 정렬을 제공함(key 순으로 정렬)
            SortedList so = new SortedList();
            SortedList<int, string> so2 = new SortedList<int, string>();
            so.Add(10, "F");
            so.Add(3, "D");
            so.Add(31, "K");
            so.Add(1, "A");

            Console.WriteLine(so.GetKey(0)); // 1
            Console.WriteLine(so.IndexOfValue("D")); // 1
            IList solist = so.GetKeyList();
            foreach (int item in solist)
            {
                Console.WriteLine(item); // 1 3 10 31 정렬
            }
            solist = so.GetValueList();
            foreach (string item in solist)
            {
                Console.WriteLine(item);
            }

        }
    }
}


/*
 1. ArrayList   >> List<T>     ***
 2. Stack       >> Stack<T>    기본
 3. Queue       >> Queue<T>    기본
 4. HashTable   >> Dictionary<T,V>    ***
 5. SortedList  >> SortedList<T,V>
 6. LinkedList 
 */