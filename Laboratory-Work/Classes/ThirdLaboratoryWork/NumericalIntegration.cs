using DecimalMath;
using static Laboratory_Work.Classes.ThirdLaboratoryWork.FunctionsVariant;
using System.Collections;
namespace Laboratory_Work.Classes.ThirdLaboratoryWork
{
    public static class NumericalIntegration
    {

        public static readonly decimal minYValueSquare = 0;
        public static decimal maxYValueSquare;

        public static List<decimal[]> outGrafic;
        public static List<decimal[]> inGrafic;


        public static void MaxYValueSquare(decimal a, decimal b)
        {
            decimal localXValue = a;
            decimal maxYValueGrafic = VariantSix(localXValue);
            
            while (localXValue <= b)
            {

                maxYValueGrafic = maxYValueGrafic < VariantSix(localXValue) ? VariantSix(localXValue) : maxYValueGrafic;
                localXValue += 0.000001m;
            }

             maxYValueSquare = maxYValueGrafic * 1.1m;
        }

        public static decimal AreaOfSquare(decimal a, decimal b)
        {
            return (maxYValueSquare - minYValueSquare) * (b - a);

        }






        public static decimal[] RandomArray(decimal min, decimal max, decimal n)
        {
            decimal[] a = new decimal[(int)n];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                decimal c = max - min;
                decimal rN = (decimal)rand.NextDouble();

                a[i] = (min + (rN * c));
            }



            return a;
        }
        
        public static decimal Integral(decimal a, decimal b, decimal n, decimal[] x, decimal[] y)
        {

            decimal areaOfSquare = AreaOfSquare(a, b);


            outGrafic = new List<decimal[]>();
            inGrafic = new List<decimal[]>();

            int CountInGrafic = 0;
            int CountOutGrafic = 0;

            for (int i = 0; i < x.Length; i++)
            {
                decimal funcX = VariantSix(x[i]);
                if (y[i] <= funcX)
                {

                    CountInGrafic++;
                    inGrafic =  inGrafic.Append( new decimal[] { x[i], y[i] }).ToList();
                }
                else if(y[i] > funcX)
                {
                    CountOutGrafic++;
                    outGrafic = outGrafic.Append( new decimal[] { x[i], y[i] }).ToList();
                }


            }


            return areaOfSquare * (CountInGrafic / n);
        }





        public static decimal Average(List<Squere> arraySquares)
        {
            decimal Sum = 0;
            foreach (Squere V in arraySquares)
            {
                Sum += V.S;
            }
            return Sum / (decimal)arraySquares.Count;
        }


        public static decimal StandartDeviation(List<Squere> arraySquares, decimal avarage)
        {
            decimal a = 0;
            foreach (Squere x in arraySquares)
            {
                a += DecimalEx.Pow(x.S - avarage, 2);
            }

            return DecimalEx.Sqrt(a / (arraySquares.Count - 1));
        }





        public static decimal ConfidenceInterval(decimal n, decimal standartDeviation)
        {
            switch (n)
            {
                case (5):
                    return (2.5706m * (standartDeviation / DecimalEx.Sqrt(n)));

                case (10):
                    return (2.2281m * (standartDeviation / DecimalEx.Sqrt(n)));

                default:
                    return -1;

            }



        }

        public static decimal[] ReliableSampleResult(decimal average, decimal confidenceInterval)
        {
            return new decimal[2] { average + confidenceInterval, average - confidenceInterval };
        }






    }
}
