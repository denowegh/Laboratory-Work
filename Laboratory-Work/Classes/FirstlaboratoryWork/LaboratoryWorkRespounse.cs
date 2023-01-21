using Laboratory_Work.Classes.FirstlaboratoryWork;
using System;

namespace Laboratory_Work.Classes.FirstlaboratoryWork
{
    public class LaboratoryWorkRespounse
    {
       //Обєкт відповіді яку я передаю на Фронтенд в форматі JSON 
        private const int Points = 6;
		private decimal[] xArray = new decimal[Points];

        private decimal[] yArray = new decimal[Points];
        

        private string functionVariantSixString = "y = 1.5\\cdot(e^{x^2}+e^{-x^2})";

        private string fivePointSchemeForCalculatingTheCostA = "f'(x_{0}) = \\frac{3f(x_{-1})-10f(x_{0})+18f(x_{1})-6f(x_{2})+f(x_{3})} {12\\cdot h}";

        private string fivePointSchemeForCalculatingTheCostB = "f'(x_{0}) = \\frac{-25f(x_{0})+48f(x_{1})-36f(x_{2})+16f(x_{3})-3f(x_{4})} {12\\cdot h}";

        private string functionForSerchingSecondDerivative = "f''(x_{0}) \\approx \\frac{f(x_{0}+h)-2f(x_{0})+f(x_{0}-h)} {h^2}";

        private decimal a5Vaue;

        private decimal b5Vaue;


        public decimal X { get; set; }
        public decimal H { get; set; }




        public decimal[] XArray
        {
			get { return xArray; }
			set { xArray = value; }
		}

        public decimal[] YArray
        {
            get { return yArray; }
            set { yArray = value; }
        }


        public string FunctionVariantSixString
        {
            get { return functionVariantSixString; }
            set { functionVariantSixString = value; }
        }

        public string FivePointSchemeForCalculatingTheCostA
        {
            get { return fivePointSchemeForCalculatingTheCostA; }
            set { fivePointSchemeForCalculatingTheCostA = value; }
        }


        public string FivePointSchemeForCalculatingTheCostB
        {
            get { return fivePointSchemeForCalculatingTheCostB; }
            set { fivePointSchemeForCalculatingTheCostB = value; }
        }

        public string FunctionForSerchingSecondDerivative
        {
            get { return functionForSerchingSecondDerivative; }
            set { functionForSerchingSecondDerivative = value; }
        }



        public decimal A5Value
        {
            get { return a5Vaue; }
            set { a5Vaue = value; }
        }


        public decimal B5Value
        {
            get { return b5Vaue; }
            set { b5Vaue = value; }
        }
        private decimal derivativeValue;

        public decimal DerivativeValue
        {
            get { return derivativeValue; }
            set { derivativeValue = value; }
        }

        private decimal secondDerivative;
        
        public decimal SecondDerivative
        {
            get { return secondDerivative; }
            set { secondDerivative = value; }
        }



        public LaboratoryWorkRespounse(decimal x, decimal h)
        {
            X = x; H = h;
            Func<double, double> func = FunctionsVariant.VariantSix;
            for (decimal i = -1; i < 5; i++)
            {


                decimal step = (h * i);
                XArray[(int)i + 1] = x + step;
                YArray = SuportFunc.DataFunction(func, XArray).ToArray();
            }


        }


    }
}
