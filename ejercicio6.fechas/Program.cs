using System.Security.Cryptography;

namespace ejercicio6.fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribame un nombre de la semana");
            string diaSemana = Console.ReadLine();

            if (Enum.TryParse(diaSemana, true, out DayOfWeek dia))
            {
                Console.WriteLine("Día de la semana no válido. Asegúrate de escribirlo correctamente.");
                return;
            }

            Console.Write("Introduce el número de mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Introduce el año (4 dígitos): ");
            int año = int.Parse(Console.ReadLine());

            DateTime DiaMes = new DateTime(año, mes, 1);

            DateTime DiaSemana = DiaMes.AddDays((7 + (int)dia - (int)DiaMes.DayOfWeek) % 7);

            while (DiaSemana.Month.Equals(mes))
            {
                Console.WriteLine(DiaSemana.ToShortDateString());
                DiaSemana = DiaSemana.AddDays(7);
            }

        }
    }
}