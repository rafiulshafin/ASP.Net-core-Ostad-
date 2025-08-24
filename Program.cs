using System;
using System.Diagnostics.Contracts;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }

    public Car(string brand, string model, int year, int milage) //Constructor
    {
        Brand = brand;
        Model = model;
        Year = year;
        Mileage = milage;
    }
    public void Drive(int kilometers)
    {
        Mileage += kilometers;
        Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km.");
    
}
    public void ShowCarInfo()
    {
        Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
    }
}
public class assignment
{
    public static void Main(string[] args)
    {
        
        Car toyota = new Car("Toyota", "Corolla", 2025, 0);
        Car tesla = new Car("Tesla", "Hybrid", 2024, 0);

       
        toyota.Drive(90);   
        tesla.Drive(180);  
        toyota.Drive(10);

        toyota.ShowCarInfo();
        tesla.ShowCarInfo();
    }
}