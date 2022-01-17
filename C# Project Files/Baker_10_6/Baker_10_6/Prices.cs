using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_10_6
{
    public class Prices
    {
        
        private int _ahPrice, _phPrice, _fhPrice, _usPrice, _7Price, _14Price, _unlimited;

        public Prices() 
        {
            _ahPrice = 0;
            _phPrice = 0;
            _fhPrice = 0;
            _usPrice = 0;
            _7Price = 0;
            _14Price = 0;
            _unlimited = 0;
        }
        public  int Allen
        {
            get
            {
                return _ahPrice;
            }
            set
            {
                _ahPrice = 1500;
            }

        }
        public  int Pike
        {
            get
            {
                return _phPrice;
            }
            set
            {
                _phPrice =  1600;
            }

        }
        public int Farthing
        {
            get
            {
                return _fhPrice;
            }
            set
            {
                _fhPrice = 1800;
            }

        }
        public int Univ
        {
            get
            {
                return _usPrice;
            }
            set
            {
                _usPrice = 2500;
            }

        }
        public int SevenMeals
        {
            get
            {
                return _7Price;
            }
            set
            {
                _7Price = 600;
            }

        }
        public int FourteenMeals
        {
            get
            {
                return _14Price;
            }
            set
            {
                _14Price = 1200;
            }

        }
        public int Unlimted
        {
            get
            {
                return _unlimited;
            }
            set
            {
                _unlimited = 1700;
            }

        }

    }
}
