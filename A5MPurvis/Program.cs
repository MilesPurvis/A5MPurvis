/*
 * Program: Assignment 5 Classes.
 * 
 * Purpose: Records information for a student
 * 
 * Revision History:
 *  Created By Miles Purvis
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5MPurvis
{
    internal class Program
    {
        //Main handles the menu
        static void Main(string[] args)
        {
            //Declare variables
            string menuInput;
            bool menuExit = false;
            bool studentExists = false;
            Student myStudent = null;
            try
            {
                do
                {
                    Console.WriteLine("[Main Menu]\n");
                    Console.WriteLine("A) Add New Student");
                    Console.WriteLine("B) Edit Existing Student");
                    Console.WriteLine("C) Display Student");
                    Console.WriteLine("D) Exit the Program");
                    Console.Write("Select A Menu Option: ");
                    menuInput = Console.ReadLine();
                    menuInput = menuInput.ToUpper();

                    switch (menuInput)
                    {
                        case "A":
                            if (studentExists == false)
                            {
                                Console.Clear();
                                studentExists = true;
                                myStudent = AddStudent();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n[A Student record already exists]\n");
                                Console.WriteLine("\nPress Any Key to return to menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case "B":
                            Console.Clear();
                            if(myStudent== null)
                            { 
                                Console.WriteLine("No student record exists, Press any key to return to menu");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                myStudent.EditStudentInformation();
                            }
                            Console.Clear();
                            break;
                        case "C":
                            Console.Clear();
                            if (myStudent == null)
                            {
                                Console.WriteLine("No student record exists, Press any key to return to menu");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            else
                            {
                                myStudent.DisplayStudentInformation();

                            }
                            Console.Clear();
                            break;
                        case "D":
                            menuExit = true;
                            break;
                    }
                } while (menuExit == false);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }

        // Take information for student
        public static Student AddStudent()
        {
            Console.WriteLine("[Add Student]\n");
            try
            {
                Console.Write("Enter Student ID Number: ");
                int stuId = int.Parse(Console.ReadLine());

                Console.Write("\nEnter Student Name: ");
                string stuName = Console.ReadLine();

                Console.Write("\nEnter Sutdent Age: ");
                int stuAge = int.Parse(Console.ReadLine());

                Console.Write("\nEnter Student City: ");
                string stuCity = Console.ReadLine();

                Student myStudent = new Student(stuId, stuName, stuAge, stuCity);

                return myStudent;
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return null;
        }
    }
}
