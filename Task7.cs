using System;
class Automobile{
    public string Name {get;}
    public int MaxSpeed {get;}
    public int Spaciousness {get;}
public Automobile (string name, int maxSpeed, int spaciousness){
    Name = name;
    MaxSpeed = maxSpeed;
    Spaciousness = spaciousness;
}       
public virtual void AboutMe(){
    Console.WriteLine($"Моя марка -- {Name}");
    Console.WriteLine($"Моя максимальна швидкість -- {MaxSpeed}");
    }
}
class Car: Automobile{
    public Car(string name, int maxSpeed, int spaciousness):base(name, maxSpeed, spaciousness){ }
    public override void AboutMe(){
        Console.WriteLine($"Я легковий автомобіль i маю кількість місць для пасажирів = {Spaciousness}");
        base.AboutMe();
    }
}
class Vehicle: Automobile{
    public Vehicle(string name, int maxSpeed, int spaciousness):base(name, maxSpeed, spaciousness){ }
    public override void AboutMe(){
        Console.WriteLine($"Я вантажний автомобіль i можу перевезти -- {Spaciousness}");
        base.AboutMe();
        }
    }
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Введіть назву авто");
            string carName = Console.ReadLine();
        
            Console.WriteLine("Введіть максимальну швидкість авто");
            int carMaxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість місць для пасажирів у авто");
            int carNumberOfSeats = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Введіть назву вантажівки");
            string vehicleName = Console.ReadLine();
        
            Console.WriteLine("Введіть максимальну швидкість вантажівки");
            int vehicleMaxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть максимальну вагу вантажу, який може перевозити вантажівка");
            int vehicleCargoWeight = int.Parse(Console.ReadLine());

            Automobile[] cars ={
                new Car(carName, carMaxSpeed, carNumberOfSeats),
                new Vehicle(vehicleName, vehicleMaxSpeed, vehicleCargoWeight)
            };

            if (cars[0].MaxSpeed > cars[1].MaxSpeed){
                (cars[0] as Automobile).AboutMe();
            }
            else if (cars[1].MaxSpeed > cars[0].MaxSpeed){
                (cars[1] as Automobile).AboutMe();
            }
            else {
                Console.WriteLine("У авто однакова максимальна швидкість");
                foreach(Automobile auto in cars){
                    Console.WriteLine();
                    auto.AboutMe();
                }
            }
        }
    }
