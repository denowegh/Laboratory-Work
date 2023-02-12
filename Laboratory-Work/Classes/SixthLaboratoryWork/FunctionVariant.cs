using DecimalMath;

namespace Laboratory_Work.Classes.SixthLaboratoryWork
{
    public static class FunctionVariant
    {
        public static decimal SixthVariant(decimal x, decimal y)
        {
            decimal ret = DecimalEx.Sin(2 * x) - 0.03m * x;
            return ret;
        }
    }
}
