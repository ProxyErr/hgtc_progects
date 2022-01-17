using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_11_1
{
    class Employee
    {
        //Declare Variables:
        private string _employeeName;
        private string _employeeNum;

        //Set constructor:
        public Employee()
        {
            
        }

        //GETTERS AND SETTERS.
        public string employeeName
        {          
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }

        public string employeeNum 
        {
            get
            {
                return _employeeNum;
            }
            set 
            {
                _employeeNum = value;
            }
        }

       
        

       
    }
}
