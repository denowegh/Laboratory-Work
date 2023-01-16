﻿namespace Laboratory_Work.Classes.FirstlaboratoryWork
{
    public class DerivativeFormulas
    {
        public decimal fivePointSchemeForCalculatingTheCostA(decimal x,decimal h, Func<double,double> func)
        {
            


            return 
                (-3m * (decimal)func((double)(x - h )) 
                - 10m * (decimal)func((double)( x )) + 
                18m * (decimal)func((double)(x + h)) -
                6m * (decimal)func((double)(x + h*2)) +
                (decimal)func((double)(x + h * 3)))/(12*h);
        }
        public decimal fivePointSchemeForCalculatingTheCostB(decimal x, decimal h, Func<double, double> func)
        {



            return
                 (-25m * (decimal)func((double)(x))
                + 48m * (decimal)func((double)(x+h)) -
                 36m * (decimal)func((double)(x + h*2)) +
                 16m * (decimal)func((double)(x + h * 3)) -
                 3m* (decimal)func((double)(x + h * 4))) / (12 * h);
        }
        public decimal FunctionForSerchingSecondDerivative(decimal x, decimal h, Func<double, double> func)
        {



            return ((decimal)func((double)(x+h))-2*(decimal)func((double)x)+(decimal)func((double)(x - h))) / (h*h);
        }

    }
}
