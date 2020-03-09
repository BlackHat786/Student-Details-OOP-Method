using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsBusiness
{
    public class StudentInfo
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactNumber { get; set; }
         
        public StudentInfo()
        { }

        public StudentInfo( string Name, string Surname, string ContactNumber)
        {
            Random rand = new Random();
            string StudentNumbers = rand.Next(21600000, 21699999).ToString();
            this.StudentNumber = StudentNumbers;
            this.Name = Name;
            this.Surname = Surname;
            this.ContactNumber = ContactNumber;
        }

        public async void Details()
        {
            
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            Surname = Console.ReadLine();
            Console.Write("Enter your contact number: ");
            ContactNumber = Console.ReadLine();
            await Task.Delay(1);
        }

        public void display()
        {
            var x = new StudentInfo(Name, Surname, ContactNumber);

            Console.WriteLine($"\n StudentNumber: {x.StudentNumber}" +
                              $"\n Studnet Name : {x.Name}" +
                              $"\n Student Surname : {x.Surname}" +
                              $"\n Contact Number : {x.ContactNumber}");
        }

    }
}
