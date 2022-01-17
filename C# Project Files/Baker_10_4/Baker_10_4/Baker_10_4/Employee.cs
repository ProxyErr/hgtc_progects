using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_10_4
{
    class Employee
    {
        //Declare Variables
        private string _name, _department, _position;

        private int _idNumber;

        //Constructor that sets the default values for the variables.
        public Employee() 
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

        public Employee(string dpEmpty) 
        {
            _name = "";
            _idNumber = 0;
            _department = depToString;
            _position = posToString;

        }

        public Employee(int toZero) 
        {
            _name = nameToString;
            _idNumber = toZero;
            _department = depToString;
            _position = posToString;

        }

        // Getter and setter the _name variable.
        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }

        }
        // Getter and setter the _idNumber variable.
        public int id 
        {
            get 
            {
                return _idNumber;
            }
            set 
            {
                _idNumber = value;
            }
        }
        // Getter and setter the _department variable.
        public string department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        // Getter and setter the _position variable.
        public string position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public string depToString
        {
            get
            {
                return _department;
            }
            set
            {
                _department = "";
            }
        }

        public string posToString
        {
            get
            {
                return _position;
            }
            set
            {
                _position = "";
            }
        }

        public string nameToString
        {
            get
            {
                return _name;
            }
            set
            {
                _name = "";
            }
        }

        public int idToZero
        {
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = 0;
            }
        }








    }
}
