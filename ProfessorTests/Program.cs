using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls for the tests
            TestConstructors();
            TestToString();
            TestGetters();
            TestSetters();
            TestError();

            Console.ReadLine();
        }

        //constructor tests for default and overloaded
        static void TestConstructors()
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor("L00000001", "Dudley", "Doright", "Computer Science");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting L00000001, Dudley, Doright, Computer Science " + p2.ToString());
            Console.WriteLine();
        }

        //testing the ToString method
        static void TestToString()
        {
            Professor p1 = new Professor("L101010101", "Mary", "Sue", "English");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting L101010101, Mary, Sue, English " + p1.ToString());
            Console.WriteLine("Expecting L101010101, Mary, Sue, English " + p1);
            Console.WriteLine();
        }

        //Testing the getters
        static void TestGetters()
        {
            Professor p1 = new Professor("L123456789", "Vlad", "Countalot", "Math");

            Console.WriteLine("Testing getters");
            Console.WriteLine("LNumber. Expecting L123456789: " + p1.LNumber);
            Console.WriteLine("First Name, Expecting Vlad: " + p1.FirstName);
            Console.WriteLine("Last Name, Expecting Countalot " + p1.LastName);
            Console.WriteLine("Department, Expecting Math: " + p1.Department);
            Console.WriteLine();
        }

        //testing the setters
        static void TestSetters()
        {
            Professor p1 = new Professor("L000000001", "Dudley", "Doright", "Computer Science");

            Console.WriteLine("Testing Setters");
            p1.LNumber = "L222222222";
            p1.FirstName = "Wungus";
            p1.LastName = "Bill";
            p1.Department = "Computer Science";
            Console.WriteLine("Expecting L222222222, Wungus, Bill, Computer Science: " + p1);
            Console.WriteLine();    
        }

        //testing error handling
        static void TestError()
        {
            Professor p1 = new Professor("L01", "Tammy", "Twoshoes", "Dance");

            Console.WriteLine("TEsting error handling");
            Console.WriteLine("Using and LNumber less than 10 characters long, expecting and error ");
            Console.WriteLine(p1);
            Console.WriteLine();
        }
    }
}
