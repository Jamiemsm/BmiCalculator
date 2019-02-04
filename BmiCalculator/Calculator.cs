using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
    class Calculator
    {
        public int Heigth;
        public int Weigth;
        public int bmi;

        public void Calulate()
        {
            bmi = (Weigth / (Heigth * Heigth)) * 703;
            
        }



    }
}
