using System;

namespace ConvercsionDeMoneda
{
    internal class Program
    {
        //Este es el método principal
        static void Main(string[] args)
        {
            //Creamos un ciclo infinito
            while (true)
            {
                //Llamamos al método MostrarMenu
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    case "3":
                        ConvertirPesosAEuros();
                        break;
                    case "4":
                        ConvertirEurosAPesos();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.ReadKey();
            }
        }

        //Este es un método que me imprime las opciones para el usuario
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a pesos");
            Console.WriteLine("3) Pesos a Euros");
            Console.WriteLine("4) Euros a pesos");
            Console.WriteLine("");
        }

        //Método para convertir Pesos a Dólares
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("Pesos a Dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en Dolares: {dolares.ToString("N2")}");
        }

        //Método para convertir Dólares a Pesos
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoCambio, dolares);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }

        //Método para convertir Pesos a Euros
        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("Pesos a Euros");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal euros = PesosAEuros(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en Euros: {euros.ToString("N2")}");
        }

        //Método para convertir Euros a Pesos
        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("Euros a Pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en euros");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal euros);

            decimal pesos = EurosAPesos(tipoCambio, euros);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }

        //Función que recibe un tipo de cambio y cantidad en pesos y devuelve el resultado en dolares
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;
            return dolares;
        }

        //Función que recibe un tipo de cambio y cantidad en dolares y devuelve el resultado en pesos
        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * dolares;
            return pesos;
        }

        //Función que recibe un tipo de cambio y cantidad en pesos y devuelve el resultado en euros
        static decimal PesosAEuros(decimal tipoCambio, decimal pesos)
        {
            decimal euros = 0.00m;
            euros = pesos / tipoCambio;
            return euros;
        }

        //Función que recibe un tipo de cambio y cantidad en euros y devuelve el resultado en pesos
        static decimal EurosAPesos(decimal tipoCambio, decimal euros)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * euros;
            return pesos;
        }

    }
}

