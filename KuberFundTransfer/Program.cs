using KuberFundTransfer.ProjectData;
using System;
using System.Collections.Generic;

namespace KuberFundTransfer
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentTransaction stu = new StudentTransaction();

            // ADD
            Console.WriteLine("Enter StuId, StuName, StudExamFees");
            Student s1 = new Student();
            s1.StuId = Convert.ToInt32(Console.ReadLine());
            s1.StuName=Console.ReadLine();
            s1.StuExamFees =Convert.ToInt32(Console.ReadLine());
            stu.AddStudent(s1);

            Console.WriteLine("Enter StuId, StuName, StudExamFees");
            Student s2 = new Student();
            s2.StuId = Convert.ToInt32(Console.ReadLine());
            s2.StuName = Console.ReadLine();
            s2.StuExamFees = Convert.ToInt32(Console.ReadLine());
            stu.AddStudent(s2);
            List<Student> List1 = stu.Listt();
            foreach (Student item in List1)
            {
                Console.WriteLine($"{item.StuId}  {item.StuName}  {item.StuExamFees}");
            }


            // Remove
            Console.WriteLine("Enter Id to remove");
            int studid = Convert.ToInt32(Console.ReadLine());
            stu.RemoveStudent(studid);
             List1 = stu.Listt();
            foreach (Student item in List1)
            {
                Console.WriteLine($"{item.StuId}  {item.StuName}  {item.StuExamFees}");
            }


            // Update
            Console.WriteLine("Enter Student Id to Modify");
            Student s = new Student();
            s.StuId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name and ExamFees");
            s.StuName = Console.ReadLine();
            s.StuExamFees = Convert.ToInt32(Console.ReadLine());
            stu.UpdateStudent(s);
            List1 = stu.Listt();
            foreach (Student item in List1 )
            {
                Console.WriteLine($"{item.StuId}   {item.StuName} {item.StuExamFees}");
            }



            Console.WriteLine("Enter Fees to Compare");
            int  examfees= Convert.ToInt32(Console.ReadLine());
            stu.ExamFees(examfees);
            List1 = stu.Listt();
            foreach (Student item in List1)
            {
                Console.WriteLine($"{item.StuId}  {item.StuName}  {item.StuExamFees}");
            }
        }



    }
}

