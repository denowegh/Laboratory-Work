namespace Laboratory_Work.Classes.SeventhLaboratoryWork
{
    public class LaboratoryWorkRespounse
    {
        public decimal[] ListPointsX { get; set; }
        public decimal[] ListPointsY { get; set; }

        public LaboratoryWorkRespounse(decimal[] listPointsX, decimal[] listPointsY)
        {
            ListPointsX = listPointsX;
            ListPointsY = listPointsY;
        }
        public override string ToString()
        {
            string Ret = "";
            for (int i = 0; i < ListPointsX.Length; i++)
            {
                Ret += $"X: {ListPointsX[i]} \tY: {ListPointsY[i]} \n";
            }
            return Ret;

        }
    }
}
