using DecimalMath;
namespace Laboratory_Work.Classes.FirstlaboratoryWork
{
    public class FunctionsVariant
    {

        public static double VariantSix(double x)
        {

            return (double)(1.5m*(DecimalEx.Exp(DecimalEx.Pow((decimal)x,2m))+DecimalEx.Exp(DecimalEx.Pow(-1*(decimal)x, 2m))));
        }
        

    }
}
