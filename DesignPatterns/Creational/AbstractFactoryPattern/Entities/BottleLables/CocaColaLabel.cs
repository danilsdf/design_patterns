using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.BottleLables
{
     public class CocaColaLabel : BottleLabel
    {
        public CocaColaLabel()
        {
            Console.WriteLine("CocaColaLabel has been created");
        }
    }
}
