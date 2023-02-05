using System.Collections;
using System.Linq;
using  Laboratory_Work.Classes.ThirdLaboratoryWork;
using static Laboratory_Work.Classes.ThirdLaboratoryWork.NumericalIntegration;
namespace Laboratory_Work.Classes.ThirdLaboratoryWork
{
    public class LaboratoryWorkRespounse
    {

        public decimal A { get; set; }
        public decimal B { get; set; }
        public decimal N { get; set; }

        public int SampleSize { get; set; }

        public List<Squere> Squeres { get; set; }

        public decimal Average { get; set; }


        public decimal StandartDeviation { get; set; }

        public decimal ConfidenceInterval { get; set; }
        public decimal[]? ReliableSampleResult { get; set; }


        public LaboratoryWorkRespounse(decimal a, decimal b, decimal n, int sampleSize)
        {
            this.A = a;
            this.B = b;
            this.N = n;
            this.SampleSize = sampleSize;
            MaxYValueSquare(a,b);

            Squeres = new List<Squere>(this.SampleSize);
            for (int i = 0; i < this.SampleSize; i++)
            {
                Squere squere = new Squere();
                decimal[] randomArrX = RandomArray(a, b, n);
                decimal[] randomArrY = RandomArray(0, NumericalIntegration.maxYValueSquare, n);

                decimal S = Integral(a, b, n,
                            randomArrX,
                            randomArrY);


                squere.OutGrafic = outGrafic;
                squere.InGrafic = inGrafic;
                squere.S = S;
                Console.WriteLine($"Squere: {squere.S}");

                Squeres = Squeres.Append(squere).ToList<Squere>();
            }




        }





    }
    public class Squere
    {
        public List<decimal[]>? InGrafic { get; set; }

        public List<decimal[]>? OutGrafic { get; set; }

        public decimal S { get; set; }

        public Squere(List<decimal[]> InGrafic, List<decimal[]> OutGrafic, decimal s)
        {
            this.InGrafic = InGrafic;
            this.OutGrafic = OutGrafic;
            this.S = s;
        }
        public Squere()
        {

        }
    }

}
