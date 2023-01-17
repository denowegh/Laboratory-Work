namespace Laboratory_Work.Classes.FirstlaboratoryWork
{
    public class LaboratoryWorkRespounse
    {

        public LaboratoryWorkRespounse(decimal x,decimal h)
        {
            X = x; H = h;
            for (decimal i = -1;i<5;i++)
            {
                decimal step = (h * i);
                XArray[(int)i+1] = x + step;
            }
        }
		private decimal[] xArray = new decimal[6];

		public decimal[] XArray
        {
			get { return xArray; }
			set { xArray = value; }
		}

        private decimal[] yArray;

        public decimal[] YArray
        {
            get { return yArray; }
            set { yArray = value; }
        }
        public decimal X { get; set; }
        public decimal H { get; set; }
    }
}
