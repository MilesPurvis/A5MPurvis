using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace A5MPurvis
{
    internal class Student
    {
        private int studentId;
        private string studentName;
        private int studentAge;
        private string studentCity;


        //Constructor non-default 
        public Student(int studentId, string studentName, int studentAge, string studentCity)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.studentCity = studentCity;
        }

        public Student()
        {
            //Constructor default
        }

        //TODO Allow user to Edit Student
        //TODO Edit Name
        //TODO Edit Age
        //TODO Edit City
        public void EditStudentInformation()
        {
            int studentIdSearch;
            string editInput;
            try
            {
                Console.WriteLine("[Edit Student Information]\n");

                Console.Write("Enter Student ID: ");
                studentIdSearch = int.Parse(Console.ReadLine());

                if (studentIdSearch == studentId)
                {
                    Console.Clear();
                    //Display Record of Student
                    Console.WriteLine("[Now editing: Student {0} | Age: {1} | City: {2} | Id#: {3}]\n",studentName,studentAge,studentCity,studentId);

                    //Edit ID
                    //Edit Name
                    //Edit Age
                    //Edit City
                    Console.WriteLine("A) Edit Student ID");
                    Console.WriteLine("B) Edit Student Name");
                    Console.WriteLine("C) Edit Student Age");
                    Console.WriteLine("D) Edit Student City");

                    //Allow user to edit the student
                    Console.Write("Which field would you like to edit: ");
                    editInput = Console.ReadLine();
                    editInput = editInput.ToUpper();

                    Console.Clear();

                    switch (editInput)
                    {
                        case "A":
                            Console.WriteLine("[Now editing: Student {0} | Age: {1} | City: {2} | Id#: {3}]\n", studentName, studentAge, studentCity, studentId);

                            Console.Write("\nNew Student ID: ");
                            studentId = int.Parse(Console.ReadLine());
                            break;
                        case "B":
                            Console.WriteLine("[Now editing: Student {0} | Age: {1} | City: {2} | Id#: {3}]\n", studentName, studentAge, studentCity, studentId);

                            Console.Write("\nNew Student Name: ");
                            studentName = Console.ReadLine();
                            break;
                        case "C":
                            Console.WriteLine("[Now editing: Student {0} | Age: {1} | City: {2} | Id#: {3}]\n", studentName, studentAge, studentCity, studentId);

                            Console.Write("\nNew Student Age: ");
                            studentAge = int.Parse(Console.ReadLine());
                            break;
                        case "D":
                            Console.WriteLine("[Now editing: Student {0} | Age: {1} | City: {2} | Id#: {3}]\n", studentName, studentAge, studentCity, studentId);

                            Console.Write("\nNew Student City: ");
                            studentCity = Console.ReadLine();
                            break;
                    }

                }
                //else if the record does not exist notify the user
                else if (studentIdSearch != studentId)
                {
                    Console.WriteLine("No Student Exists");
                    Console.WriteLine("\nPress Any Key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void DisplayStudentInformation()
        {
                string studentSearch = "";

            do
            {
                try
                {
                    Console.WriteLine("[Display Student Information]\n");
                    Console.Write("Search Student by Name or Enter \"QUIT\": ");
                    studentSearch = Console.ReadLine();

                    //if record exists, Display Name|Age|City 
                    if (studentSearch == studentName)
                    {
                        Console.WriteLine("\nName: {0}|City: {1}|Age: {2}", studentName, studentCity, studentAge);
                        Console.WriteLine("\nPress any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (studentSearch == "QUIT")
                    {
                        Console.Clear();
                        break;
                    }
                    //else if the record does not exist notify the user
                    else if (studentSearch != studentName)
                    {
                        Console.WriteLine("No student record exists, Press any key to re-enter");
                        Console.ReadKey();
                        Console.Clear();
                    }
                   
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    Console.WriteLine("\nPress any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                }
              
            } while (studentSearch != "QUIT" );
           
        }
    }
}
