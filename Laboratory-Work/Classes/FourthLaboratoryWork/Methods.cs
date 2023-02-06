
using DecimalMath;
namespace Laboratory_Work.Classes.FourthLaboratoryWork
{
    public static class Methods
    {


        public static LaboratoryWorkRespounse MethodBisection(Func<decimal, decimal> func, decimal a, decimal b, decimal precition)
        {
            int count = 0;
            bool condition = true;
            decimal c = 0;

            decimal funcA = func(a);
            decimal funcB = func(b);
            decimal funcC = 0;
            if (funcA * funcB < 0)
            {
                c = (a + b) / 2m;
            }
            else
            {
                throw new Exception("Не задовольняе умовам Больцано-Коші ");
            }


            while (condition)
            {


                funcA = func(a);
                funcB = func(b);


                decimal res = (Math.Abs(funcA) + Math.Abs(funcB));
                if (res / 2 <= precition)
                {
                    condition = false;
                }
                if (func(a) * func(c) < 0)
                {
                    b = c;
                    c = (a + b) / 2;



                }
                else if (func(c) * func(b) < 0)
                {
                    a = c;
                    c = (a + b) / 2;


                }




                count++;
            }


            return new LaboratoryWorkRespounse(c, count, precition);
        }


    }
}
