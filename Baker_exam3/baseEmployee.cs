using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_exam3
{
    class baseEmployee
    {
        //Declare Variables
        private string _employeeName, _employeeEmail;
        private string _employeeAddress;


        //Set Constructor
        public baseEmployee()
        {


        }

        //GETTERS AND SETTERS
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

        public string employeeEmail
        {
            get
            {
                return _employeeEmail;
            }
            set
            {
                _employeeEmail = value;
            }
        }

        public string employeeAddy
        {
            get
            {
                return _employeeAddress;
            }
            set
            {
                _employeeAddress = value;
            }
        }


    }
}
