namespace reservaHotel;
    public class Reserva
    {
        public Hospede HospedeDaReserva { get; set; } = new Hospede();
        public Quarto QuartoDaReserva { get; set; } = new Quarto();
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int CalcularDiarias()
        {
            return (DataCheckOut.Date - DataCheckIn.Date).Days;
        }

        public double CalcularValorTotal()
        {
            return QuartoDaReserva.Diaria * CalcularDiarias();
        }

        public bool ValidarReserva()
        {
            if (DataCheckOut.Date <= DataCheckIn.Date)
                return false;

            if (QuartoDaReserva.Diaria <= 0)
                return false;

            return true;
        }

        public void ExibirDados()
        {
            Console.WriteLine("=== RESUMO DA RESERVA ===");
            Console.WriteLine($"Hóspede: {HospedeDaReserva.Nome}");
            Console.WriteLine($"Documento: {HospedeDaReserva.Documento}");
            Console.WriteLine($"Quarto: {QuartoDaReserva.NumeroQuarto}");
            Console.WriteLine($"Categoria: {QuartoDaReserva.Categoria}");
            Console.WriteLine($"Check-in: {DataCheckIn:dd/MM/yyyy}");
            Console.WriteLine($"Check-out: {DataCheckOut:dd/MM/yyyy}");
            Console.WriteLine($"Diárias: {CalcularDiarias()}");
            Console.WriteLine($"Valor total: {CalcularValorTotal():C}");
        }
    }
