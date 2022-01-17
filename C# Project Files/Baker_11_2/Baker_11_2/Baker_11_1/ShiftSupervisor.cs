using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_11_1
{
    class ShiftSupervisor: Employee
    {
        private Boolean _superShift;
        private string _superSalary;
        private double _superBonus;

        public ShiftSupervisor() 
        {
            _superShift = false;
          
        }


        public Boolean superShift 
        {
            get 
            {
                return  _superShift;

            }
            set 
            {
                _superShift = value;
            }
        }

        public string superSalary 
        {
            get
            {
                return _superSalary;

            }
            set
            {
                _superSalary = value;
            }
        }
        public double superBonus
        {
            get
            {
                return _superBonus;

            }
            set
            {
                _superBonus = value;
            }
        }
    }
}
