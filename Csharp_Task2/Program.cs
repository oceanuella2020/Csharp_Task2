using System;
using System.Collections.Generic;

namespace Csharp_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            int age;
            string email;
            string gender;
            string answer;
            string prefered;
            string choice;
            string choosed;

            string[] schools = new string[4] { "University of Ibadan", "Olabisi Onabanjo University", "Babcock University", "University of Lagos" };
            string[] faculty = new string[3] { "Science", "Art", "Social Science" };

            List<string> department = new List<string>();
            department.Add("Biochemistry");
            department.Add("Medicine");
            department.Add("Geology");
            department.Add("Physiology");
            department.Add("MIcrobiology");
            department.Add("Chemistry");
            department.Add("Physics");
            department.Add("Philosophy");
            department.Add("Mass_Communication");
            department.Add("English");
            department.Add("Linguistics");
            department.Add("Yoruba");
            department.Add("Music");
            department.Add("Accounting");
            department.Add("Business_Administration");
            department.Add("Political_Science");
            department.Add("Psycology");
            department.Add("Sociology");
            department.Add("International_studies");

            Console.WriteLine("Hello Aspirant.");
            Console.WriteLine("kindly fill in your information below.\nNB: Your Given Information will be used for further processing.\nSo therefore, Your real informations should be provided. Thanks. ");
            Console.Write("Enter your firstname: ");
            fname = Console.ReadLine();
            Console.Write("Enter your lastname: ");
            lname = Console.ReadLine();
            Console.Write ("Enter your email: ");
            email = Console.ReadLine();
            Console.Write ("Enter your gender: ");
            gender = Console.ReadLine();
            Console.Write ("Enter your age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Thank you\n" + fname+ " " + lname + "\n" + email + "\n" + gender + "\n" + age);
            Console.WriteLine("Kindly review if your information above is correctly stated Thanks.\nInput yes if correct, and no if wrong:");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Great. You are almost done.");
                Console.WriteLine("Below are the University currently offering admission in 2020");
                Console.WriteLine(schools[0]);
                Console.WriteLine(schools[1]);
                Console.WriteLine(schools[2]);
                Console.WriteLine(schools[3]);
                Console.Write("Enter your preferred school of choice: ");
                prefered = Console.ReadLine();

                if (prefered == schools[0])
                {
                    Console.WriteLine("Welcome to " + schools[0] + ". Below are the available faculties");
                    Console.WriteLine(faculty[0]);
                    Console.WriteLine(faculty[1]);
                    Console.WriteLine(faculty[2]);
                    Console.Write ("Choose a faculty: ");
                    choice = Console.ReadLine();
                    if (choice == faculty[0])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[0] + schools[0] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[0]);
                        Console.WriteLine(department[0]);
                        Console.WriteLine(department[1]);
                        Console.WriteLine(department[2]);
                        Console.WriteLine(department[3]);
                        Console.WriteLine(department[4]);
                        Console.WriteLine(department[5]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[0])
                        { 
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of " + department[0] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[1])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of " + department[1] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[2])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of " + department[2] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[3])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of " + department[3] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[4])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of " + department[4] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[5])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[0] + ",Department of" + department[5] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[1])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[1] + schools[0] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[1]);
                        Console.WriteLine(department[6]);
                        Console.WriteLine(department[7]);
                        Console.WriteLine(department[8]);
                        Console.WriteLine(department[9]);
                        Console.WriteLine(department[10]);
                        Console.WriteLine(department[11]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[6])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[6] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[7])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[7] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[8])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[8] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[9])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[9] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[10])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[10] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[11])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[1] + ",Department of " + department[11] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[2])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[2] + schools[0] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[2]);
                        Console.WriteLine(department[12]);
                        Console.WriteLine(department[13]);
                        Console.WriteLine(department[14]);
                        Console.WriteLine(department[15]);
                        Console.WriteLine(department[16]);
                        Console.WriteLine(department[17]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[12])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[12] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[13])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[13] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[14])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[14] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[15])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[15] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[16])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[16] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[17])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[0] + ",Faculty of " + faculty[2] + ",Department of " + department[17] + ". Best of luck.\nEnjoy your stay on campus.");
                        }


                    }

                }

                else if (prefered == schools[1])
                {
                    Console.WriteLine("Welcome to " + schools[1] + ". Below are the available faculties");
                    Console.WriteLine(faculty[0]);
                    Console.WriteLine(faculty[1]);
                    Console.WriteLine(faculty[2]);
                    Console.Write("Choose a faculty: ");
                    choice = Console.ReadLine();

                    if (choice == faculty[0])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[0] + schools[1] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[0]);
                        Console.WriteLine(department[0]);
                        Console.WriteLine(department[1]);
                        Console.WriteLine(department[2]);
                        Console.WriteLine(department[3]);
                        Console.WriteLine(department[4]);
                        Console.WriteLine(department[5]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[0])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[0] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[1])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[1] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[2])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[2] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[3])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[3] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[4])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[4] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[5])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[0] + ",Department of " + department[5] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[1])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[1] + schools[1] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[1]);
                        Console.WriteLine(department[6]);
                        Console.WriteLine(department[7]);
                        Console.WriteLine(department[8]);
                        Console.WriteLine(department[9]);
                        Console.WriteLine(department[10]);
                        Console.WriteLine(department[11]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[6])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + "With email " + email + "We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of" + department[6] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[7])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of " + department[7] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[8])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of " + department[8] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[9])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of " + department[9] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[10])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname +  "With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of " + department[10] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[11])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[1] + ",Department of " + department[11] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[2])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[2] + schools[1] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[2]);
                        Console.WriteLine(department[12]);
                        Console.WriteLine(department[13]);
                        Console.WriteLine(department[14]);
                        Console.WriteLine(department[15]);
                        Console.WriteLine(department[16]);
                        Console.WriteLine(department[17]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[12])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " +lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[12] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[13])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[13] + ". Best of luck.\nEnjoy your stay on campus.");
                        } 
                        else if (choosed == department[14])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[14] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[15])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[15] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[16])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " with email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[16] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[17])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[1] + ",Faculty of " + faculty[2] + ",Department of " + department[17] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                    }


                }
                else if (prefered == schools[2])
                {
                    Console.WriteLine("Welcome to " + schools[2] + ". Below are the available faculties");
                    Console.WriteLine(faculty[0]);
                    Console.WriteLine(faculty[1]);
                    Console.WriteLine(faculty[2]);
                    Console.Write ("Choose a faculty: ");
                    choice = Console.ReadLine();

                    if (choice == faculty[0])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[0] + schools[2] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[0]);
                        Console.WriteLine(department[0]);
                        Console.WriteLine(department[1]);
                        Console.WriteLine(department[2]);
                        Console.WriteLine(department[3]);
                        Console.WriteLine(department[4]);
                        Console.WriteLine(department[5]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[0])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[0] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[1])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[1] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[2])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[2] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[3])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[3] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[4])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[4] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[5])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[0] + ",Department of " + department[5] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[1])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[1] + schools[2] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[1]);
                        Console.WriteLine(department[6]);
                        Console.WriteLine(department[7]);
                        Console.WriteLine(department[8]);
                        Console.WriteLine(department[9]);
                        Console.WriteLine(department[10]);
                        Console.WriteLine(department[11]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[6])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[6] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[7])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[7] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[8])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[8] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[9])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[9] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[10])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[10] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[11])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[1] + ",Department of " + department[11] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[2])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[2] + schools[2] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[2]);
                        Console.WriteLine(department[12]);
                        Console.WriteLine(department[13]);
                        Console.WriteLine(department[14]);
                        Console.WriteLine(department[15]);
                        Console.WriteLine(department[16]);
                        Console.WriteLine(department[17]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[12])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[12] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[13])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[13] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[14])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[14] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[15])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[15] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[16])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[16] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[17])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[2] + ",Faculty of " + faculty[2] + ",Department of " + department[17] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                    }

                }
                else if (prefered == schools[3])
                {
                    Console.WriteLine("Welcome to " + schools[3] + ". Below are the available faculties");
                    Console.WriteLine(faculty[0]);
                    Console.WriteLine(faculty[1]);
                    Console.WriteLine(faculty[2]);
                    Console.Write("Choose a faculty: ");
                    choice = Console.ReadLine();

                    if (choice == faculty[0])
                    {
                        Console.WriteLine("Dear" + fname + " " + lname + " you are welcome to the Faculty of " + faculty[0] + schools[3] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[0]);
                        Console.WriteLine(department[0]);
                        Console.WriteLine(department[1]);
                        Console.WriteLine(department[2]);
                        Console.WriteLine(department[3]);
                        Console.WriteLine(department[4]);
                        Console.WriteLine(department[5]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[0])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[0] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[1])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[1] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[2])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[2] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[3])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[3] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                        else if (choosed == department[4])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[4] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[5])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[0] + ",Department of " + department[5] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[1])
                    {
                        Console.WriteLine("Dear " + fname + " " + lname + " you are welcome to the Faculty of " + faculty[1] + schools[3] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[1]);
                        Console.WriteLine(department[6]);
                        Console.WriteLine(department[7]);
                        Console.WriteLine(department[8]);
                        Console.WriteLine(department[9]);
                        Console.WriteLine(department[10]);
                        Console.WriteLine(department[11]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[6])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of" + department[6] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[7])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of" + department[7] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[8])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of " + department[8] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[9])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of " + department[9] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[10])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of " + department[10] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[11])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[1] + ",Department of " + department[11] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                    }
                    else if (choice == faculty[2])
                    {
                        Console.WriteLine("Dear " + fname +" "+ lname + " you are welcome to the Faculty of " + faculty[2] +","+ schools[3] + ".");
                        Console.WriteLine("Below are the available department in Faculty of " + faculty[2]);
                        Console.WriteLine(department[12]);
                        Console.WriteLine(department[13]);
                        Console.WriteLine(department[14]);
                        Console.WriteLine(department[15]);
                        Console.WriteLine(department[16]);
                        Console.WriteLine(department[17]);
                        Console.WriteLine("Choose your preferred department: ");
                        choosed = Console.ReadLine();

                        if (choosed == department[12])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname +" " +lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[12] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[13])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[13] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[14])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[14] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[15])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[15] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[16])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " With email " + email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[16] + ". Best of luck.\nEnjoy your stay on campus.");
                        }
                        else if (choosed == department[17])
                        {
                            Console.WriteLine("Great!!! \nDear " + fname + " " + lname + " with email "+email + " We are happy to inform you that you have been offered an admission at " + schools[3] + ",Faculty of " + faculty[2] + ",Department of " + department[17] + ". Best of luck.\nEnjoy your stay on campus.");
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("Restart your Registration Process.");
            }

        }
    }         

}
