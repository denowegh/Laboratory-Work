using DecimalMath;

namespace Laboratory_Work.Classes.SeventhLaboratoryWork
{
    public static class FunctionVariant
    {

        public static decimal  FunctionVariantSix(decimal x, decimal y)
        {
            decimal a = DecimalEx.Cos(y) / (x + 2);
            decimal b = 0.3m * (y * y);
            return a - b;
        }

    }
}
