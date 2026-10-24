namespace std
{
    // Klasa: notatka
    // Opis: wyświetla treść i tytuł notatki, wypisuje która to notatka z kolei i każdej dodaje id
    // Pola: licznik, identyfikator, tytul, tresc
    // Metody: wyswietlanie, wyswietlanieDiagnostyki
    // imie i nazwisko: Seweryn Malczak
    class Notatka
    {
        private static int licznik = 0;
        private int identyfikator;

        protected string tytul;

        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            identyfikator = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void wyswietlanie()
        {
            Console.WriteLine($"zadanie: {tytul}");
            Console.WriteLine($"treść {tresc}");
        }

        public void wyswietlanieDiagnostyki()
        {
            Console.WriteLine($"{identyfikator}, {tytul}, {tresc}");
        }

        static void Main(string[] args)
        {
            Notatka notatka1 = new Notatka(
                "Podlac rosliny",
                "pierwsze i drugie piętro"
            );

            Notatka notatka2 = new Notatka(
                "pojechać do sklepu",
                "kupić wodę i chleb"
            );

            notatka1.wyswietlanie();

            notatka1.wyswietlanieDiagnostyki();

            Console.WriteLine();

            notatka2.wyswietlanie();

            notatka2.wyswietlanieDiagnostyki();

            Console.WriteLine() ;

            Console.WriteLine(Notatka.licznik);
        }

    }
}
