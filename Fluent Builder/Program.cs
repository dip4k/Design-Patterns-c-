namespace DotNetDesignPattern.Creational.Builder
{

    internal class Program
    {
        class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
        {

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("------------Fluent builder------------");
            var me = Person.New
              .Called("Deepak")
              .WorksAsA("Dev")
              .Born(DateTime.UtcNow)
              .Build();
            Console.WriteLine(me);

            Console.WriteLine("\n -------Stepwise builder--------------");
            var car = CarBuilder.Create()
                    .OfType(CarType.Crossover)
                    .WithWheels(18)
                    .Build();
            Console.WriteLine(car);
        }
    }
}