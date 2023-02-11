using MathNet.Numerics;
using System.Runtime.Serialization;

namespace Laboratory_Work.Classes.FifthLaboratoryWork
{
    public static  class Methods
    {


        public static decimal[] FindA_And_B(Func<decimal, decimal> func, decimal x, decimal h)
        {
            decimal a;
            decimal b;
            int countIter = 100000000;
            for (int i = 0; i < countIter; i++)
            {
                a = x + ((decimal)i * h);
                b = x + (((decimal)i + 1m) * h);

                if (func(a) * func(b) < 0)
                {
                    return new decimal[2] { a, b };
                }
            }

            throw new MyException($"Not find root at this segment from {x} to {x + (h * countIter)} ",x,h,countIter);
        }



        public static decimal FunctionEqualX(Func<decimal, decimal> func, Func<double, double> funcDouble, decimal x)
        {
            double der = Differentiate.Derivative(funcDouble, (double)x, 1);
            decimal derd = (decimal)der;
            return x - (func(x) / derd);
        }
        public static LaboratoryWorkRespounse MethodOfSuccesApprox(Func<decimal, decimal> func, Func<double, double> funcDouble, decimal a, decimal b, decimal precition)
        {
            decimal x = a > b ? a : b; decimal y = 0;
            int count = 0;
            y = FunctionEqualX(func, funcDouble, x);
            while (Math.Abs(y - x) > precition)
            {

                x = y;
                y = FunctionEqualX(func, funcDouble, x);
                count++;

            }
            return new LaboratoryWorkRespounse(y, count);
        }






    }
}
