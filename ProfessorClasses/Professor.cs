using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorClasses
{
    public class Professor
    {
        //private variables
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;

        //default constructor
        public Professor() { }

        //overloaded constructor
        public Professor(string lnum, string fName, string lName, string dept)
        {
            lNumber = lnum;
            firstName = fName;
            lastName = lName;
            department = dept;
        }

        //the getter and setter properties
        public string LNumber
        {
            get
            {
                return lNumber;
            }
            set
            {
                int n = lNumber.Length;
                if ( n == 10)
                    lNumber = value;
                else
                    throw new ArgumentException("Error! LNumber must be an L followed by 9 numbers!");
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        //the ToString, which has been overridden
        public override string ToString()
        {
            return String.Format("LNumber: {0} First Name: {1} Last Name: {2} Department: {3}", lNumber, firstName, lastName, department);
        }
    }
}
