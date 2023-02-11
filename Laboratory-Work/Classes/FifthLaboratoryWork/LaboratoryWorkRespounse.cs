namespace Laboratory_Work.Classes.FifthLaboratoryWork
{
    public class LaboratoryWorkRespounse
    {
        public decimal Root { get; set; }

        public int CountIter { get; set; }

        public LaboratoryWorkRespounse(decimal root, int countIter)
        {
            this.Root = root;
            this.CountIter = countIter;
        }
        public override string ToString()
        {
            return $"{Root} {CountIter} ";
        }
    }
}
