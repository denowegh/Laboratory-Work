namespace Laboratory_Work.Classes.FifthLaboratoryWork
{
    public class MyException : Exception
    {

        public decimal From { get; set; }
        public decimal To { get; set; }
        public MyException(string? message,decimal x,decimal h,decimal count) : base(message)
        {
            From = x;
            To = x + (h * count);
        }

        
    }
}
