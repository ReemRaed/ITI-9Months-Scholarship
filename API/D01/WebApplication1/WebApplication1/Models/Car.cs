using WebApplication1.Validators;

namespace WebApplication1.Models
{
    public class Car
    {
        public int  ID { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        [DateInPastAttribute]
        public DateTime Model { get; set; }

        public string Type { get; set; }

        public Car(int iD, string name, string color, DateTime model)
        {
            ID = iD;
            this.name = name;
            this.color = color;
            Model = model;
        }
        public static List<Car> cars = new List<Car>()
        {
            new(1,"KIA","BLACK",DateTime.Now),
            new(2,"JEEP","BLACK",DateTime.Now),
            new(3,"NISSAN","WHITE",DateTime.Now),
            new(4,"TOYOTA","RED",DateTime.Now),


        };
    }
}
