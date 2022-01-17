using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_11_1
{
    class ProductionWorker : Employee
    {
        //Declare Variables:
        private Boolean _employeeShift1, _employeeShift2;
        private string _employeeHRate;

        //Set constructor:
        public ProductionWorker() 
        {
            _employeeShift1 = false;
            _employeeShift2 = false;                    
        }

        //GETTERS AND SETTERS.
        public Boolean employeeShift1
        {
            get 
            {
                return _employeeShift1;
            }
            set 
            {
                _employeeShift1 = value;
            }
        }

        public Boolean employeeShift2 
        {
            get
            {
                return _employeeShift2;
            }
            set
            {
                _employeeShift2 = value;
            }
        }

        public string employeeHRate 
        {
            get 
            {
                return _employeeHRate;
            }
            set
            {
                _employeeHRate = value;
            }
        }
    }
}
