using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Waters
{
     public class CocaColaWater : Water
    {
        public CocaColaWater()
        {
            Console.WriteLine("CocaColaWater has been created");
        }
    }
}
