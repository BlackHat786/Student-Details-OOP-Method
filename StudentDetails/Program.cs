using StudentDetailsBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseDetails x = new CourseDetails();            
            x.StudentCost();
            Console.ReadLine();
        }
    }
}
