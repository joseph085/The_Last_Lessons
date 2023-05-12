using Inheritance_and_Polymorphism.Constants;
namespace Inheritance_and_Polymorphism
{
    class Mercedes
    {
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        public int ReleaseDate { get; set; }
        public int SpeedBox { get; set; }  // 1-- Avto, 2-- Mexanika,3-- Robot 
        public float EngineValume { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Mercedes firstcar = new Mercedes
            {
                Color = Color.Green,
                MaxSpeed = 100,
                ReleaseDate = 2018,
                SpeedBox = SpeedboxTypes.A,
                EngineValume = 2.5f
            };
        }
    }
}