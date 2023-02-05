using DecimalMath;
namespace Laboratory_Work.Classes.ThirdLaboratoryWork
{
    public static class FunctionsVariant
    {
        public static decimal VariantSix(decimal x)
        {
            
            decimal a = DecimalEx.Pow(x, -2);

            decimal ret = (2 * DecimalEx.Exp(a - DecimalEx.Pow(x, 2)));
            return ret;

        }
    }
}
