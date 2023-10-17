using Serwis_Aut;

internal class Program
{
    private static void Main(string[] args)
    {
        CarService carService = new CarService();
        
        Car car = new Car(1, "Mercedes", "Yellow");
        Car car1 = new Car(0, "Mercedes B5", "Yellow");
        Car car2 = new Car(3, "Mercedes", "Yellow1");
        
        carService.InsertNewCar(car.CarId,car.Mark,car.Color);
        carService.InsertNewCar(car2.CarId,car2.Mark,car2.Color);
        carService.InsertNewCar(car1.CarId,car1.Mark,car1.Color);

    }
}