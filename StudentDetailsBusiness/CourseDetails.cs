using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsBusiness
{
   public class CourseDetails
    {
        public List<string> CourseName { get; set; }
        public string CourseCode { get; set; }
        public double courseCost { get; set; }
        
        public CourseDetails()
        { }

        public async void CourseInfo()
        {
            CourseName = new List<string>();
            CourseName.Add("1. Course Name: NDip in Info and Comm Tech in App Dev Course Code: APDII");
            CourseName.Add("2. Course Name: BTech in IT Course Code:BTIT");
            CourseName.Add("3. Course Name: Business Analysis Course Code: BAII");
            CourseName.Add("4. Course Name: System Engineering Course Code: SEWDII");

            foreach (var item in CourseName)
            {
                Console.WriteLine(item + "\n");
            }
            await Task.Delay(1);
        }

        public async void StudentCost()
        {
            StudentInfo std = new StudentInfo();
            std.Details();
            CourseInfo();
            Costing c = new Costing();
            Console.Write("Choose a course Code: ");
            c.CourseCode = Console.ReadLine();
            Console.Write("Annual or Semester Student: ");
            c.type = Console.ReadLine();
            await Task.Delay(1);
            std.display();
            Console.WriteLine($"\n Corse Type : {c.type}" +
                              $"\n Course Code : {c.CourseCode}");
            await Task.Delay(1000);
            await c.Costs();
        }
    }
}
