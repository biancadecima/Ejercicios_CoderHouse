namespace Class_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto autoFord = new Auto(02556498, 36000.32f, "Ford");
            Moto motoBmw = new Moto(07589642, 0.00f, "BMW");

            Console.WriteLine(autoFord.ToString());
            autoFord.Arrancar();
            autoFord.Frenar();
            autoFord.Apagar();

            Console.WriteLine(motoBmw.ToString());
            motoBmw.Arrancar();
            motoBmw.Frenar();
            motoBmw.Apagar();

        }

    }
}

