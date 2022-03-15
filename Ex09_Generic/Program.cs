using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 추가

namespace Ex09_Generic
{
    class Program
    {
        class Person
        { // DTO , VO , DOMAIN
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public Person() { }
            public Person(string name, string phone, string email)
            {
                this.Name = name;
                this.Phone = phone;
                this.Email = email; 
            }

            public override string ToString()
            {
                return "Name : " + Name + " Phone : " + Phone + "Email : " + Email; 
            }

        }

        // Interface 만들기 (난이도 높음)
        class PersonList : IEnumerable , IEnumerator // 열거된 자원에 대해서 순차적으로 접근해서 데이터를 read 하겠다
        {
            private ArrayList persons = new ArrayList();
            // private List<Person> list = new List<Person>(); // 리스트 써서 타입 강제하는 게 더 좋은 방법
            private int pos = -1; // reset 값

            // 데이터 넣는 함수
            public void Add(Person person)
            {
                persons.Add(person);
            }
            public void Add(string name, string phone, string email)
            {
                persons.Add(new Person(name, phone, email));
            }





            public IEnumerator GetEnumerator()
            {
                // IEnumerator 상속해서 구현하고 객체의 주소를 리턴
                return this;
            }

            // IEnumerator 구현
            public object Current { // 프로퍼티 구현 , get의 로직 구현 // 데이터 받는 역할
                get { return persons[pos]; } 
            } 
            public bool MoveNext() { // 구현 , bool 타입이 리턴 되도록 // 데이터 위치 확인
                if (pos + 1 < persons.Count)
                {
                    pos++;
                    return true;
                }
                else
                {
                    return false;
                }
            } 

            public void Reset() { // 실행 블록에 초기화 // 배열의 리셋 -> -1
                pos = -1;
            } 
        }


        static void Main(string[] args)
        {
            //Person person = new Person(); // 데이터 1건
            //List<Person> list = new List<Person>(); // 데이터 여러 건

            PersonList personlist = new PersonList();
            for (int i = 0; i < 10; i++)
            {
                personlist.Add("Na" + i, "Ph" + i, "Em" + i);
            }

/*            foreach (var person in personlist)
            {
                Console.WriteLine(person);
                // public override string Tostring() {재정의}
            }*/

            IEnumerator ie = personlist.GetEnumerator();
            // ie가 받은 건 personlist 객체의 주소
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current.ToString());
            }

            //Dictionary<int, string> dictionary = new Dictionary<int, string>() // 둘 다 가능
            var dictionary = new Dictionary<int, string>()
            {
                { 0, "value0"},
                { 1, "value1"},
                { 2, "value2"} // 초기화

            };

            for (int index = 0; index < dictionary.Count; index++){
                Console.WriteLine("index :{0}-{1}", index,dictionary[index]);
            }

            foreach (var entry in dictionary) // 많이 쓰이는 유형
            {
                Console.WriteLine("key : {0}, value : {1}", entry.Key, entry.Value);
            }
        }
    }
}
