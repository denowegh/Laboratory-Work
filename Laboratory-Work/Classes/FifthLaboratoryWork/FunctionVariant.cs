using DecimalMath;

namespace Laboratory_Work.Classes.FifthLaboratoryWork
{
    public static class FunctionVariant
    {
        public static decimal FunctionDecimal(decimal x)
        {
            decimal t = 2.2082m * x;
            decimal ret1 = DecimalEx.Tan(t / 180);
            decimal ret2 = (3.2258m * x);
            return ret1 - ret2;
        }
        public static double FunctionDouble(double x)
        {
            double t = 2.2082 * x;
            double ret1 = Math.Tan(t / 180);
            double ret2 = (3.2258 * x);
            return ret1 - ret2;
        }
    }
}
