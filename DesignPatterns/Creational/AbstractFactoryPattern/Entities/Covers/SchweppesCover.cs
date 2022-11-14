using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Covers
{
    internal class SchweppesCover : Cover
    {
        public SchweppesCover()
        {
            Console.WriteLine("SchweppesCover has been created");
        }
    }
}
