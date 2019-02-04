using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
    class Calculator
    {
        public double Heigth;
        public double Weigth;
        public double bmi;

        public void Calulate(double weight, double height)
        {
            bmi = (weight / (height * height));
			DB.Writer(Heigth, Weigth);
        }



    }
}
