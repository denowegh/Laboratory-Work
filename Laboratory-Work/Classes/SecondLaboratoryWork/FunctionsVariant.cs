using DecimalMath;
namespace Laboratory_Work.Classes.SecondLaboratoryWork
{
    public class FunctionsVariant
    {
        //Функії по варіантам 
        public static decimal VariantSix(decimal x)
        {

            return (decimal)(1.5m*(DecimalEx.Exp(DecimalEx.Pow((decimal)x,2m))+DecimalEx.Exp(DecimalEx.Pow(-1*(decimal)x, 2m))));
        }
        

    }
}
