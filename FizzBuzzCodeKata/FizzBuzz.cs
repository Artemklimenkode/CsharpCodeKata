using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public bool isDevidableByFive(int number) {
            if (number % 5 == 0)
                return true;
            else
                return false;
        }

        public string doFizzBuzz(int number) {
            string result = "";

            if (this.isDevidableByThree(number))
            {
                result += "Fizz";
            }
            if (this.isDevidableByFive(number)) {
                result += "Buzz";
            }
            if (result == "") {
                result = number.ToString();
            }

            return result;
            //if (this.isDevidableByThree(number) && this.isDevidableByFive(number))
            //{
            //    return "FizzBuzz";
            //}
            //if (this.isDevidableByFive(number))
            //{
            //    return "Buzz";
            //}            
            //if (this.isDevidableByThree(number))
            //{
            //    return "Fizz";
            //}
            
            //return number.ToString();
        }

        public void printNumbersInLoop() {
            for (int i = 1; i <= 100; i++)
            {
                Debug.WriteLine(this.doFizzBuzz(i));
            }
        }
    }
}



