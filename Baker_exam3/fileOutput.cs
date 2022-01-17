using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_exam3
{
    class fileOutput 
    {
        private string _employeeList;

        public fileOutput() 
        {
                        
        }
        //Getters and Setters
        public string employeeList 
        {
            get 
            {
                return _employeeList;
            }
            set 
            {
                _employeeList = value;

            }
        }
    }
}
