using System;

namespace PropertryPattern
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public DateTime ProducedAt { get; set; }
        }

        static string GetNickName(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
            $"The car {car.Model} was produced at {car.ProducedAt} and the nickname is {nickname}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
                return GenerateMessage(car, "Fastback");
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMessage(car, "Cobra");
            else
                return GenerateMessage(car, "Unknown");
        }
        static string GetNickName2(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
            $"The car {car.Model} was produced at {car.ProducedAt} and the nickname is {nickname}";
            return car switch
            {
                Car { Model: "Mustang", ProducedAt.Year: 1967 } => GenerateMessage(car, "Fastback"),
                Car { Model: "Mustang", ProducedAt.Year: 1976 } => GenerateMessage(car, "Cobra"),
                _ => GenerateMessage(car, "Unknown")
            };
        }
            static void Main(string[] args)
        {
            Console.WriteLine(
                GetNickName(
                    new Car() {Model = "Mustang", ProducedAt = new DateTime(1967, 11 ,23)})
                );
            Console.WriteLine(
                GetNickName(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 11, 23) })
                );
            Console.WriteLine(
                GetNickName(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(2000, 11, 23) })
                );

            Console.WriteLine(
                GetNickName2(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) })
                );
            Console.WriteLine(
                GetNickName2(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 11, 23) })
                );
            Console.WriteLine(
                GetNickName2(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(2000, 11, 23) })
                );
        }
    }
}
