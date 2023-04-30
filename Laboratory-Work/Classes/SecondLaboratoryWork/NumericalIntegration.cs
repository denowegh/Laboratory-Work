using DecimalMath;
using System.Numerics;

namespace Laboratory_Work.Classes.SecondLaboratoryWork
{
    public class NumericalIntegration
    {


        private static decimal Xi(decimal a ,decimal h, int i)
        {
            return a + (h * i);
        }
        /*
        public static decimal methodTrapezium(Func<decimal,decimal> func , decimal a,decimal b,int n)
        {
            decimal h = (b - a )/ n;

            decimal S0 = (func(a) + func(b)) / 2m;

            decimal Sn = 0;

            for(int i = 1; i < n; i++) Sn += func(Xi(a, h, i));
            
            
            return h*(S0+Sn);
        }
        */
        public static decimal methodTrapezium(Func<decimal, decimal> func, decimal a, decimal b, int n)
        {
            decimal h = (b - a) / n;

            decimal S0 = func(a) + func(b);

            decimal Sn = 0;

            for (int i = 1; i < n; i++) Sn += func(Xi(a, h, i));


            return (h/2) * (S0 + 2*(Sn));
        }

        public static decimal methodSimpson(Func<decimal, decimal> func, decimal a, decimal b, int n)
        {

            decimal h = (b - a) / (2*n);

            decimal Even = 0;
            decimal NoEven = 0;
            decimal Item0 = func(a);
            decimal ItemN = func(b);
            
            for (int i = 1; i < 2*n; i++)
            {
                if ((i%2)==0)
                {
                    Even += func(Xi(a,h,i));
                }else if ((i % 2) != 0)
                {
                    NoEven += func(Xi(a, h, i));
                }
            }

            return (h/3)*(Item0+ItemN+2*(Even)+4*(NoEven));

        }


        public static decimal Comparison(decimal methodSimpson,decimal methodTrapezium)
        {
            
            return Math.Abs((methodTrapezium - methodSimpson) / methodSimpson);
        }

    }
}
