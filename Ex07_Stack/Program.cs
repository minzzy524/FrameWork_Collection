using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //추가

namespace Ex07_Stack
{
    // LIFO
    class MyStack
    {
        object[] items; // 저장 구조(타입)
        int stackpointer = 0; // 정적 배열의 위치정보를 저장 [0][1][2][3][4]
        readonly int s_size;

        public MyStack() : this(100) { } // 100개의 방 생성

        public MyStack(int size) 
        {
            this.s_size = size;
            this.items = new object[this.s_size]; // 저장소 생성

        }
        
        public void Push(object item)
        {
            if(stackpointer >= s_size)
            {
                throw new InvalidOperationException("stack Full");
            }
            items[stackpointer] = item;
            stackpointer++; // 포인터 이동시키자
        }

        public object Pop()
        {
            stackpointer--; // 그래야 데이터 있는 방으로 가지
            if (stackpointer >= 0)
            {
                return items[stackpointer];
            }
            else { 
                stackpointer = 0;  // 포인터 초기화
                throw new InvalidOperationException("stack empty");
            }
        }

    }

    // 제너릭 클래스 만들기
    // Gstack<string>
    // Gstack<int>
    class GStack<T> // <> 안에 있는 T를 쭉 바꿔줘 L56 L65 L69 L79
    {
        T[] items; // 저장 구조(타입)
        int stackpointer = 0; // 정적 배열의 위치정보를 저장 [0][1][2][3][4]
        readonly int s_size;

        public GStack() : this(100) { } // 100개의 방 생성

        public GStack(int size)
        {
            this.s_size = size;
            this.items = new T[this.s_size]; // 저장소 생성

        }

        public void Push(T item)
        {
            if (stackpointer >= s_size)
            {
                throw new InvalidOperationException("stack Full");
            }
            items[stackpointer] = item;
            stackpointer++; // 포인터 이동시키자
        }

        public T Pop()
        {
            stackpointer--; // 그래야 데이터 있는 방으로 가지
            if (stackpointer >= 0)
            {
                return items[stackpointer];
            }
            else
            {
                stackpointer = 0;  // 포인터 초기화
                throw new InvalidOperationException("stack empty");
            }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            // Stack 클래사 C# API 제공해주는 자원
            // 내부적인 구현방법 이해
            Stack stack = new Stack(); // C# API
            MyStack stack2 = new MyStack(); // 개발자가 직접

            MyStack s = new MyStack(3);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            //s.Push(50);

            int number = (int)s.Pop(); //[object][object][object]
            Console.WriteLine(number);
            int number2 = (int)s.Pop(); 
            Console.WriteLine(number2);
            int number3 = (int)s.Pop(); 
            Console.WriteLine(number3);


            GStack<int> gstack = new GStack<int>(5);
            gstack.Push(10);
            gstack.Push(20);
            gstack.Push(30);
            gstack.Push(40);

            int data = gstack.Pop(); // casting
            Console.WriteLine("data : {0}", data);


        }
    }
}
