namespace Dictionary_MenuComidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo diccionario general
            Dictionary<string, Dictionary<string, double>> menuPrincipal = new Dictionary<string, Dictionary<string, double>>();

            // Creo los demás diccionarios
            Dictionary<string, double> bebidasSinAlcohol = new Dictionary<string, double>();
            bebidasSinAlcohol.Add("Jugos", 90);
            bebidasSinAlcohol.Add("Gaseosas", 88);
            bebidasSinAlcohol.Add("Agua", 20);

            menuPrincipal.Add("Bebidas sin alcohol", bebidasSinAlcohol);

            Dictionary<string, double> bebidasAlcoholicas = new Dictionary<string, double>();
            bebidasAlcoholicas.Add("Vinos", 90);
            bebidasAlcoholicas.Add("Cervezas", 88);
            bebidasAlcoholicas.Add("Daikiri", 20);
            menuPrincipal.Add("Bebidas alcoholicas", bebidasAlcoholicas);

            Dictionary<string, double> entradas = new Dictionary<string, double>();
            entradas.Add("Picadas para dos", 90);
            entradas.Add("Sandwiches de miga", 88);
            entradas.Add("Empanadas de carne", 20);
            menuPrincipal.Add("Entradas", entradas);

            Dictionary<string, double> platos = new Dictionary<string, double>();
            platos.Add("Picadas para dos", 90);
            platos.Add("Sandwiches de miga", 88);
            platos.Add("Empanadas de carne", 20);
            menuPrincipal.Add("Platos", platos);

            Dictionary<string, double> postres = new Dictionary<string, double>();
            postres.Add("budin de pan", 90);
            postres.Add("Flan con crema", 88);
            postres.Add("Duraznos en almibar", 20);
            menuPrincipal.Add("Postres", postres);

            foreach (var seccion in menuPrincipal )
            {
                Console.WriteLine(seccion.Key);
                foreach (var item in seccion.Value)
                {
                    Console.WriteLine($"\t{item.Key}, PRECIO: ${item.Value}");
                }
            }
        }
    }
}