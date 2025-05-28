namespace LashaMurgvaLominadzeShraieri.Quiz3.Models
{
    public class Car
    {
        private static int _nextId = 1; 

        public int ID { get; private set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }

        public Car(string model, double weight, double speed)
        {
            ID = _nextId++; 
            Model = model;
            Weight = weight;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"{ID} {Model}";
        }
    }
}
