using DecimalMath;

namespace Laboratory_Work.Classes.EighthLaboratoryWork
{
    public static class FunctionVariant
    {


        public static decimal Function_Variant_Six(decimal x)
        {
            if ((x >= 0) && (x <= 0.10m))
            {
                return (11.1m - (11.1m / 0.10m) * x);
            }
            else if ((x > 0.10m) && (x <= 0.35m))
            {
                return 0;
            }
            else if ((x > 0.35m) && (x <= 1))
            {
                return (14.5m / (1m - 0.35m)) * (x - 0.35m);
            }
            else
            {
                return 0;
            }

        }
        public static decimal Function_Variant_Six_boundaryCondition_X0(decimal t)
        {
            return 14.5m;

        }
        public static decimal Function_Variant_Six_boundaryCondition_X1(decimal t)
        {
            return 11.1m;

        }

    }
}
