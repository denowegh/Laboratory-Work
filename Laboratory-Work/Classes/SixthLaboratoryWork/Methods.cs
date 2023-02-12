namespace Laboratory_Work.Classes.SixthLaboratoryWork
{
    public static class Methods
    {

       public static LaboratoryWorkRespounse MethodEller(Func<decimal, decimal, decimal> func, decimal a, decimal b, decimal x0, decimal y0, int n)
        {
            decimal[] listPointsX = new decimal[n + 1];
            decimal[] listPointsY = new decimal[n + 1];
            decimal h = (b - x0) / n;
            listPointsX[0] = x0;
            listPointsY[0] = y0;
            decimal YNew;
            for (int i = 0; i < n; i++)
            {
                listPointsX[i + 1] = listPointsX[i] + h;
                YNew = listPointsY[i] + func(listPointsX[i], listPointsY[i]) * h;
                listPointsY[i + 1] = listPointsY[i] + ((func(listPointsX[i + 1], YNew) +
                    func(listPointsX[i], listPointsY[i])) / 2 * h);

            }

            var ret = new LaboratoryWorkRespounse(listPointsX, listPointsY);

            return ret;
        }
    }
}
