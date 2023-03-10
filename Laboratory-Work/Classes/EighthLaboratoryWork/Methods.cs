namespace Laboratory_Work.Classes.EighthLaboratoryWork
{
    public static class Methods
    {
        public static double[,] Method_Net(decimal dX, Func<decimal, decimal> func,
            decimal dT, decimal alpha, Func<decimal, decimal> boundaryCondition_X0,
            Func<decimal, decimal> boundaryCondition_X1)
        {
            double k_ij = (double)(alpha * dT / (dX * dX));
            int numX = (int)((double)1 / (double)dX);
            int numT = (int)((decimal)boundaryCondition_X0(1.0m) / dT);
            decimal[] arrX = new decimal[numX];
            decimal[] arrT = new decimal[numT];
            for (int i = 0; i < numX; i++)
            {
                arrX[i] = (i * dX);
            }
            for (int i = 0; i < numT; i++)
            {
                arrT[i] = (i * dT);
            }
            double[,] retValue = new double[numX, numT];
            for (int i = 0; i < numX; i++)
            {
                retValue[i, 0] = (double)func(arrX[i]);
            }
            for (int j = 0; j < numT; j++)
            {
                retValue[0, j] = (double)boundaryCondition_X0(arrT[j]);
                retValue[numX - 1, j] = (double)boundaryCondition_X1(arrT[j]);
            }
            for (int j = 0; j < numT - 1; j++)
            {
                for (int i = 1; i < numX - 1; i++)
                {
                    retValue[i, j + 1] = retValue[i, j] + 
                        (k_ij * (retValue[i - 1, j] - (2 * retValue[i, j]) + retValue[i-1,j]));
                }
            }
            return retValue;
        }
    }
}
