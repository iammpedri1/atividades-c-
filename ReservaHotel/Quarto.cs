   namespace reservaHotel;

    public class Quarto
    {
        private double diaria;

        public int NumeroQuarto { get; set; }
        public string Categoria { get; set; } = "";

        public double Diaria
        {
            get { return diaria; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A diária deve ser maior que zero.");

                diaria = value;
            }
        }
    }
