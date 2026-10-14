using System;
namespace reservaHotel
{
    public static class Program
    {
        public static void Main()
        {
            Quarto q = new Quarto
            {
                NumeroQuarto = 3,
                Categoria = "Luxo",
                Diaria = 200.00
            };

            Hospede h = new Hospede
            {
                Nome = "Pedro",
                Documento = "166666666"
            };

            Reserva r = new Reserva
            {
                HospedeDaReserva = h,
                QuartoDaReserva = q,
                DataCheckIn = new DateTime(2026, 10, 20),
                DataCheckOut = new DateTime(2026, 10, 25)
            };

            if (r.ValidarReserva())
            {
                r.ExibirDados();
                Console.WriteLine("Reserva confirmada!");
            }
            else
            {
                Console.WriteLine("Reserva inválida!");
            }
        }
    }
}