using Laboratory_Work.Classes.FirstlaboratoryWork;
using System;

namespace Laboratory_Work.Classes.SecondLaboratoryWork
{
    public class LaboratoryWorkRespounse
    {
        //Обєкт відповіді яку я передаю на Фронтенд в форматі JSON 
        private string functionVariantSixString = "y = 1.5\\cdot(e^{x^2}+e^{-x^2})";
        

        public string FunctionVariantSixString
        {
            get { return functionVariantSixString; }
            set { functionVariantSixString = value; }
        }
        public decimal ResultMethodSimpson { get; set; }
        public decimal ResultMethodTrapezium { get; set; }
        public decimal Comparison { get; set; }
        public decimal A { get; set; }
        public decimal B { get; set; }
        public decimal N { get; set; }



    }
}
