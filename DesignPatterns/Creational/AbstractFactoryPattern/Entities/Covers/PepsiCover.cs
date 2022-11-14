using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Covers
{
    public class PepsiCover : Cover
    {
        public PepsiCover()
        {
            Console.WriteLine("PepsiCover has been created");
        }
    }
}
