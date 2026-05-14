namespace Test1.Models
{
    public class ProduktClass
    {
        private double cena;
        private int mnozství;
        public string ErrorMessage { get; set; } = "";

        public string Jmeno { get; set; }
        public double Cena
        {
            get => cena; set
            {
                if (value>=0&&value<10001)
                {
                    cena = value;
                    return;
                }
                ErrorMessage = "Cena musí být v rozsahu 0 až 10000";
                return;


            }
        }
        public int Mnozství
        {
            get => mnozství; set
            {
                if (value > 0 && value < 1001)
                {
                    mnozství = value;
                    return;
                }
                ErrorMessage = "Mnozství musí být v rozsahu 1 až 1000";
                return;
            }
        }


         

        public ProduktClass()
        {
            Jmeno = "";
            Mnozství = 1;
            Cena = 1;
        }

        public double TotalValue => mnozství * cena;
       

    }
}
