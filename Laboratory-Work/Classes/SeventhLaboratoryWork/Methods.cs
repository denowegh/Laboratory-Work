namespace Laboratory_Work.Classes.SeventhLaboratoryWork
{
    public static class Methods
    {

        public static LaboratoryWorkRespounse MethodRungeKutti(Func<decimal, decimal, decimal> func, decimal a, decimal b, decimal x0, decimal y0, decimal h, int n)
        {
            decimal[] listPointsX = new decimal[n + 1];
            decimal[] listPointsY = new decimal[n + 1];
            listPointsX[0] = x0;
            listPointsY[0] = y0;
            decimal k1, k2, k3, k4, x, y;
            for (int i = 0; i < n; i++)
            {
                listPointsX[i + 1] = listPointsX[i] + h;

                x = listPointsX[i];
                y = listPointsY[i];
                k1 = func(x, y);

                x = listPointsX[i] + (h / 2);
                y = listPointsY[i] + (k1 * h / 2);
                k2 = func(x, y);

                x = listPointsX[i] + (h / 2);
                y = listPointsY[i] + (k2 * h / 2);
                k3 = func(x, y);

                x = listPointsX[i] + h;
                y = listPointsY[i] + (k2 * h);
                k4 = func(x, y);

                listPointsY[i + 1] = listPointsY[i] + (((k1 + (k2 * 2) + (k3 * 2) + k4) * h) / 6);
            }

            var ret = new LaboratoryWorkRespounse(listPointsX, listPointsY);

            return ret;
        }

    }
}
