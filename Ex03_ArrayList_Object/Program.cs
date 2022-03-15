using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Ex03_ArrayList_Object
{

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

    class Person
    {
        private string name;
        private string phone;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Person() { }
        public Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        public override string ToString()
        {
            return "Name: " + name + " Phone: " + phone + " Email: " + email;
        }

    }

    class PersonList : IEnumerable, IEnumerator
    {
        private ArrayList persons = new ArrayList();
        private int pos = -1;

        public void Add(Person p)
        {
            persons.Add(p);
        }
        public void Add(string name, string phone, string email)
        {
            persons.Add(new Person(name, phone, email));
        }

        #region IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        #endregion

        #region IEnumerator 멤버

        public object Current
        {
            get { return persons[pos]; }
        }

        public bool MoveNext()
        {
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

        public void Reset()
        {
            pos = -1;
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {   // ?? add(Object parameter)
            // 문제점) 1. 많은 메모리 2. boxing/unboxing -> casting 해야 함
            ArrayList list = new ArrayList();
            list.Add(new Account("111", "홍길동"));
            list.Add(new Account("222", "김유신"));
            list.Add(new Account("333", "이순신"));

            for (int i = 0; i < list.Count; i++)
            {

                if (((Account)list[i]).num == "22222")
                {
                    Console.WriteLine("계좌를 찿았습니다");
                    Console.WriteLine(((Account)list[i]).num);
                    return;
                }
                else
                {
                    Console.WriteLine("계좌를 없습니다");

                }
            }

            // foreach (Account account in list)
            foreach (Object account in list)  //자동 형변환 처리 
            {
                //Console.WriteLine("번호 : {0} , 이름 : {1}", account.num, account.name);
                Console.WriteLine("번호 : {0} , 이름 : {1}", ((Account)account).num, ((Account)account).name);
            }


            //////////////////////////////////////////////////////////////////////

            PersonList pi = new PersonList();
            for (int i = 0; i < 10; i++)
            {
                pi.Add("N" + i, " P" + i, " E" + i);
            }
            /*
            foreach (Person p in pi)
            {
                Console.WriteLine(p.ToString());
            }
            */
            IEnumerator ie = pi.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }


        }
    }
}
