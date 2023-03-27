using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hrana
    {
        private string hrana;
        private string velicina;
        private int kolicina;

        public Hrana(string hrana, string velicina, int kolicina)
        {
            this.hrana = hrana;
            this.velicina = velicina;
            this.kolicina = kolicina;
        }

        public string Kolicina
        {
            get { return velicina; }
            set 
            {
                if (value == "Mala" || value == "mala")
                    velicina = value;
                else if (value == "Velika" || value == "velika")
                    velicina = value;
                else
                    Console.WriteLine("Greska!");
            }
        }

        public void ispis()
        {
            Console.WriteLine();
            Console.WriteLine("Hrana: " + hrana);
            Console.WriteLine("Velicina: " + velicina);
            Console.WriteLine("Kolicina: " + kolicina);
        }
    }

    class Prilozi
    {
        private string salata;
        private string namaz;
        private string zacin;

        public Prilozi(string salata, string namaz, string zacin)
        {
            this.salata = salata;
            this.namaz = namaz;
            this.zacin = zacin;
        }

        public void ispis()
        {
            Console.Write("Prilozi: "+salata+" "+namaz+" "+zacin+"\n");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Podaci
    {
        private string ime;
        private string prezime;

        public Podaci(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public void ispis()
        {
            Console.WriteLine("Ime: "+ime);
            Console.WriteLine("Prezime: "+prezime);
        }
    }

    class Narudzbina : Podaci
    {
        private Hrana hrana;
        private Prilozi prilozi;

        public Narudzbina(string hrana, string velicina, int kolicina, string salata, string namaz, string zacin, string ime, string prezime) :base (ime, prezime)
        { 
            this.hrana = new Hrana(hrana, velicina, kolicina);
            this.prilozi = new Prilozi(salata, namaz, zacin);
        }

        public new void ispis()
        {
            base.ispis();
            Console.WriteLine("Vasa porudzbina:");
            hrana.ispis();
            prilozi.ispis();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Narudzbina n1 = new Narudzbina("Pljeskavica", "Mala", 1, "Zelena", "Pavlaka", "Tucana", "Marko", "Markovic");
            n1.ispis();

            Narudzbina n2 = new Narudzbina("Belo meso", "Velika", 1, "Kupus", "Pavlaka", "Kecap", "Pera", "Peric");
            n2.ispis();

        }
    }
}
