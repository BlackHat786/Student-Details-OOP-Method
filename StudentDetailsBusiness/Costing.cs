using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsBusiness
{
    class Costing
    {
        //string CourseCode = "", type="";
        double cost = 0.0, vat = 0.15, total = 0.0, reg = 0.0,pay=0.0, Fee=0.0;
        public string CourseCode { get; set; }
        public string type { get; set; }

        public double Annual()
        {
            reg = 2240;
           return pay = reg + (vat * reg);
        }

        public double Semester()
        {
            reg = 2500;
            return pay = reg + (vat * reg);
        }

        public async Task<double> Costs()
        {
            if (CourseCode == "APDII")
            {
                Fee = 25000;
                if (type=="Annual")
                {
                    total += Annual() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
                else
                {
                    total += Semester() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
            }
            else if (CourseCode == "BTIT")
            {
                Fee = 45000;
                if (type == "Annual")
                {
                    total += Annual() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
                else
                {
                    total += Semester() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
            }

            else if (CourseCode == "BAII")
            {
                Fee = 15000;
                if (type == "Annual")
                {
                    total += Annual() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
                else
                {
                    total += Semester() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
            }
            else if (CourseCode == "SEWDII")
            {
                Fee = 35000;
                if (type == "Annual")
                {
                    total += Annual() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
                else
                {
                    total += Semester() + Fee;
                    Console.Write($"\nCourse Cost: R" + total);
                }
            }
            return total;
        }

    }
}
