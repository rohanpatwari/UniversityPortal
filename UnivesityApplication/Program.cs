using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivesityApplication
{
    class student
    {
        public int SId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Sex { get; set; }
        public string EmailId { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<student> L = new List<student>();
            Console.WriteLine("University Portal");
            Start:
            Console.WriteLine("Please select your Option: 1 - REGISTER, 2 - SEARCH, 3 - EXIT");
            int UserChoice = int.Parse(Console.ReadLine().ToUpper());
            switch (UserChoice)
            {
                case 1:
                    student s = new student();
                    Console.WriteLine("Enter the Student Id:");
                    s.SId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the First Name:");
                    s.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter the Last Name:");
                    s.LastName = Console.ReadLine();
                    Console.WriteLine("Enter the Date Of Birth: ");
                    s.DateOfBirth = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter you Sex: M/F");
                    s.Sex = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Email Id: ");
                    s.EmailId = Console.ReadLine();
                    Console.WriteLine("student got enrolled");
                    L.Add(s);
                    break;
                case 2:
                    Console.WriteLine("Enter the Last Name to get the Student Details:");
                    String LN = Console.ReadLine();
                    if(L.Count != 0)
                    {
                        foreach (var st in L)
                        {
                            if (st.LastName == LN)
                            {

                                Console.WriteLine("Student Details:");
                                Console.WriteLine("Full Name: {0}", st.FirstName + " " + st.LastName);
                                Console.WriteLine("Email Id: {0}", st.EmailId);
                                Console.WriteLine("Date Of Birth: {0}", st.DateOfBirth);
                            }
                            else
                            {
                                Console.WriteLine("Student Not Found");
                            }
                        }
                        }
                    
                        else
                        {
                            Console.WriteLine("No data is available");
                        }
                    
                    break;
                case 3:
                    goto End;
                default:
                    Console.WriteLine("Your Choice is invalid", UserChoice);
                    goto Start;

            }
            Decide:
            Console.WriteLine("Do you want to register/search - Yes or No?");
            string UserDecide = Console.ReadLine();
            switch (UserDecide.ToUpper())
            {
                case "YES":

                    goto Start;
                case "NO":

                    break;
                default:
                    Console.WriteLine("Your Choice is inavalid.Please try again...",UserDecide);

                    goto Decide;
            }
            End:
            Console.WriteLine("Thank You for Visting the University Portal");
            Console.ReadLine();
        }
    }
}

   
