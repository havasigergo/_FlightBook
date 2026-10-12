using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FlightBook
{
    public class Passenger
    {
        //valtozok
        private string _name;
        private int _age;
        private int _bagCount;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int BagCount
        {
            get { return _bagCount; }
            set { _bagCount = value; }
        }

        //constructor
        public Passenger(string name, int age)
        {
            _name = name;
            _age = age;
            _bagCount = 0;
        }

        //methods
        public bool AddBag()
        {
            if (_bagCount < 2)
            {
                _bagCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsChild()
        {
            return _age < 12;
        }
    }
}
