using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_exam3
{
    class advancedEmployee : baseEmployee
    {
        //Declare Variables
        private double _advEmployeeRate, _advEmployeeHoursWorked;



        //Set Constructor
        public advancedEmployee()
        {
            _advEmployeeRate = 0;
            _advEmployeeHoursWorked = 0;

        }

        //GETTERS AND SETTERS
        public double employeeRate
        {
            get
            {
                return _advEmployeeRate;
            }
            set
            {
                _advEmployeeRate = value;
            }
        }

        public double employeeHrs
        {
            get
            {
                return _advEmployeeHoursWorked;
            }
            set
            {
                _advEmployeeHoursWorked = value;
            }
        }
    }
}
