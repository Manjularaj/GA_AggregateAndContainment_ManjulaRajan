using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_ManjulaRajan
{
    internal class Engine
    {

        int _hp;

        public Engine(int hp)
        {
            _hp = hp;
        }

        public int Hp
        {
            get => _hp;

            set

            {
                if (value >= 50)
                {
                    _hp = value; // Setter method sets the horsepower if it's greater than or equal to 50
                }
                else
                {
                    throw new Exception("Invalid horsepower value"); // Throws an exception for invalid horsepower values
                }





            }






        }//class


    }
}//namespace


