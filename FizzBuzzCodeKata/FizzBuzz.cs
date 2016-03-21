using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodeKata
{
    
       public class FizzBuzz
        {
            public bool isDevidableByThree(int number) {
                return (number % 3 == 0);
            }

            public bool isDevidableByFive(int number)
            {

            if (number % 5 == 0)
            {
                return true;

            }
            else return false;
            }
            public string doFizzBuzz(int number)
            {
                return "";
            }
        }
    }



