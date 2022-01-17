using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_exam3
{
    class superEmployee : advancedEmployee
    {
        //Declare Variables
        private Boolean _supEmployeeHigh, _supEmployeeMed, _supEmployeeLow;
        private string _supEmployeeOffice;



        //Set Constructor
        public superEmployee()
        {
            _supEmployeeHigh = false;
            _supEmployeeMed = false;
            _supEmployeeLow = false;

        }

        //GETTERS AND SETTERS
        public Boolean employeeHigh
        {
            get
            {
                return _supEmployeeHigh;
            }
            set
            {
                _supEmployeeHigh = value;
            }
        }
        public Boolean employeeMed
        {
            get
            {
                return _supEmployeeMed;
            }
            set
            {
                _supEmployeeMed = value;
            }
        }
        public Boolean employeeLow
        {
            get
            {
                return _supEmployeeLow;
            }
            set
            {
                _supEmployeeLow = value;
            }
        }
        public string employeeOffice
        {
            get
            {
                return _supEmployeeOffice;
            }
            set
            {
                _supEmployeeOffice = value;
            }
        }



    } 
}
