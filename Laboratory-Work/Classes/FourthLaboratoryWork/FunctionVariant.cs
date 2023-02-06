using DecimalMath;

namespace Laboratory_Work.Classes.FourthLaboratoryWork
{
    public static class FunctionVariant
    {
        public static decimal VariantSix(decimal x)
        {
            decimal x4 = DecimalEx.Pow(x, 4);
            decimal x3 = DecimalEx.Pow(x, 3);
            decimal x2 = DecimalEx.Pow(x, 2);

            return ((3m / 5m) * x4) + ((4m / 5m) * x3) - ((12m / 5m) * x2);
        }

    }
}
