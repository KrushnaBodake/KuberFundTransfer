
using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer
{
    public class StudentTransaction
    {
       private List<Student> StudentList = new List<Student>();

        public StudentTransaction()
        {
            StudentList = new List<Student>();
        }
        public void AddStudent(Student stud)            // it refers student class thats why we use Object
        {
            StudentList.Add(stud);
        }

        public void UpdateStudent( Student stud)        // it refers Student class thats why we use Object
        {
            foreach (Student item in StudentList)
            {
                if(item.StuId==stud.StuId)
                {
                    item.StuName = stud.StuName;
                    item.StuExamFees = stud.StuExamFees;
                    break;
                }
            }
        }
        public void RemoveStudent(int studid)             // it refers current class thats why we use Object
        {
            foreach (Student item in StudentList)
            {
                if(item.StuId==studid)
                {
                    StudentList.Remove(item);
                    break;
                }
            }
        }
        
        public List<Student> ExamFees(int examfees)         // it Return Seperate List
        {
            List<Student> StudentList1 = new List<Student>();
            foreach (Student item in StudentList)
            {
                if (item.StuExamFees > examfees)
                {
                    StudentList1.Add(item);
                }                
            }
            return StudentList1;
        }

        public List<Student> Listt()
        {
            return StudentList;
        }


    }
    public class Remove
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no which is remove");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[] { 3, 4, 5, 6, 8 };

            for(int i=0; i<a.Length;i++)
            {
              
                if(a[i]==num)
                {
                    a[i] = 0 ;
                }
                else if (a[i] != 0)
                {
                    Console.Write(a[i]);
                }

            }
            
            
        }
    }
    public class Sum
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {  12, 4, 2, 10, 5, 1 } ;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    for (int k = 0; k <a. Length; k++)
                    {
                        if(a[i]+a[j]+a[k]==16)
                        {
                            Console.WriteLine(a[i]+a[j]+a[k]);
                        }
                    }

                }
            }
        }
    }
}
