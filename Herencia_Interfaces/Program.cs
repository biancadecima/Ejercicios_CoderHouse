namespace Herencia_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messi lionelMessi = new Messi(90, 89, 87, 97, 88, 99);
            Ronaldo cristianoRonaldo = new Ronaldo(91, 87, 87, 90, 81, 96);

            lionelMessi.correr();
            lionelMessi.defender();
            lionelMessi.regatear();
            lionelMessi.rematar();
            lionelMessi.colocarPase();
            lionelMessi.soportarEmbate();

            cristianoRonaldo.correr();
            cristianoRonaldo.defender();
            cristianoRonaldo.regatear();
            cristianoRonaldo.rematar();
            cristianoRonaldo.colocarPase();
            cristianoRonaldo.soportarEmbate();
        }
    }
}