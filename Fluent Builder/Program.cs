namespace DotNetDesignPattern.Creational.Builder
{

    internal class Program
    {
        class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
        {

        }

        public static void Main(string[] args)
        {
            var me = Person.New
              .Called("Deepak")
              .WorksAsA("Dev")
              .Born(DateTime.UtcNow)
              .Build();
            Console.WriteLine(me);
        }
    }
}