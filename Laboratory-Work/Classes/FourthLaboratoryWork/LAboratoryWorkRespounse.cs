namespace Laboratory_Work.Classes.FourthLaboratoryWork
{
    public class LaboratoryWorkRespounse
    {
        public decimal Root { get; set; }

        public int CountIter { get; set; }
        public decimal Precition { get; set; }
        public LaboratoryWorkRespounse(decimal root, int countIter, decimal precition)
        {
            this.Root = root;
            this.CountIter = countIter;
            this.Precition = precition;
        }
        public override string ToString()
        {
            return $"{Root} {CountIter} {Precition}";
        }
    }
}
