namespace Laboratory_Work.Classes.FirstlaboratoryWork
{
    public class SuportFunc
    {
        //Отримати дані про надану функцію біля точки х
        public static IEnumerable<decimal>  DataFunction(Func<double,double>func, decimal[] x)
        {
            decimal[] y = new decimal[x.Length];
            for(int i = 0;i<x.Length;i++)
            {
                y[i] = (decimal)func((double)x[i]);
            }

            return y;
        }
    }
}
