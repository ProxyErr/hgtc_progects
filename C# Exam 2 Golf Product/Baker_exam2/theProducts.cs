using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_exam2
{
    class theProducts
    {
        //Declare Variables: 
        private string _prodName, _prodDescr;

        private int _prodPrice, _prodQty;

        //Set constructor: 
        public theProducts()
        {
            _prodName = "";
            _prodDescr = "";
            _prodPrice = 0;
            _prodQty = 0;
        }
        //GETTERS AND SETTERS.
        public string Name
        {
            get
            {
                return _prodName;
            }
            set
            {
                _prodName = value;
            }
        }

        public string Descr
        {
            get
            {
                return _prodDescr;
            }
            set
            {
                _prodDescr = value;
            }

        }

        public int Price
        {
            get
            {
                return _prodPrice;
            }
            set
            {
                _prodPrice = value;
            }

        }

        public int Qty
        {
            get
            {
                return _prodQty;
            }
            set
            {
                _prodQty = value;
            }
        }

    }
}
