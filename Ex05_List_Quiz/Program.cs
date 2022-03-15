using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ListQuiz
{
    /*
     Emp 클래스 생성
    사번 (empno)  정수
    이름 (ename)  문자열
    직종 (job)      문자열
    급여 (sal)       정수
    생성자를 통해서 member field 초기화
    -------------------------------------------
    List<T> 사용하여 사원 3명을 만드세요

    사원의 정보를 (사원 , 이름 , 직종 , 급여)  출력하세요
    일반  for  과 foreach    
     */
    class Emp
    {   // 멤버 필드
        private int empno;
        private string ename;
        private string job;
        private int sal;

        public Emp(int empno, string ename, string job, int sal) // 생성자
        {
            this.empno = empno;
            this.ename = ename;
            this.job = job;
            this.sal = sal;
        }

        public override string ToString() // 리턴
        {
            return this.empno + "/" + this.ename;
            //  return ($"{empno},{ename},{job},{sal}");
        }

        public void getEmp()
        {
            Console.WriteLine($"사번 : {this.empno}, 이름 : {this.ename}, 직종 : {this.job}, 급여 : {this.sal}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();

            list.Add(new Emp(101, "이건희", "회장", 10000));
            list.Add(new Emp(102, "이재용", "부회장", 5000));
            list.Add(new Emp(103, "아무개", "사원", 100));

            foreach (var emps in list)
            {
                Console.WriteLine(emps);
            }

            Console.WriteLine("-----------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
