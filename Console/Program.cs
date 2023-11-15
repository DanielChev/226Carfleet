namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck("VD 123 567","Volvo","FH16","VOL45-0157966");
            Car car = new Car("VD 123 567", "Mercedes-Benz", "Vito", "SV30-0169266");
            DisplayTruck(truck);
            DisplayCar(car);
        }

        static private void DisplayCar(Car car)
        {
            Console.WriteLine(car.ToString());
        }

        static private void DisplayTruck(Truck truck)
        {
            Console.WriteLine(truck.ToString());
        }
    }
}