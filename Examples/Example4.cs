using Example.Iterative.Yield.Entities;
using System;
using System.Collections.Generic;

namespace Example.Iterative.Yield.Examples
{
    public static class Example4
    {
        public static void ShowCars()
        {
            var cars = GeneratorCar();
            var count = 0;

            foreach (var car in cars)
            {
                Console.WriteLine($"Id: {car.Id} - Chassi: {car.Chassis}");
                count++;

                if (count == 5) break;
            }
        }

        private static IEnumerable<Car> GeneratorCar()
        {
            Console.WriteLine("Gerando lista de carros");

            for (int i = 1; i < 100; i++)
                yield return new Car(i, Guid.NewGuid());
        }
    }
}
