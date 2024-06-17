

    internal class Program
    {
        static int nummer2;
        static int nummer1;

        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu mein Zahlraten-Spiel! Klicken Sie Enter, um zu beginnen!");
            Console.WriteLine("So lautet die Regeln! Am Erstens geben Sie ein Zahlenbereich");
            Console.WriteLine("Und dann nimmt die Programm ein Zufallszahl von dein Zahlenbereich");
            Console.WriteLine("Und denn mussen Sie raten, einfach oder?");
            methoden();

            while (true)
            {
                Console.WriteLine("Wollen sie nochmal spielen?");
                var Wiederspielen = Console.ReadLine();
                Wiederspielen = Wiederspielen.ToLower();

                if (Wiederspielen == "ja")
                {
                    methoden();
                }

                else if (Wiederspielen == "nein")
                {
                    Console.WriteLine("auf Wiedersehen!");
                    break;
                }

                else
                {
                    Console.WriteLine("Bitte geben Sie eine richtige angabe ein");
                }

            }

        }



        static void methoden()
        {
            BerechneNummer1();
            BerechneNummer2();
            ErzeugeMeinzahl();
            Vergleich();

        }

        static void BerechneNummer1()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Jetzt schreiben Sie Sein Anfangszahl");
                    nummer1 = Convert.ToInt32(Console.ReadLine());
                    if (nummer1 > 0)
                        break;
                    else
                        Console.WriteLine("Bitte geben Sie eine richtige angabe ein");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte geben Sie eine richtige angabe ein");

                }

            }
        }

        static void BerechneNummer2()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Jetzt schreiben Sie Sein Endzahl");
                    nummer2 = Convert.ToInt32(Console.ReadLine());
                    if (nummer2 <= 0 || nummer2 > nummer1)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Bitte geben Sie eine richtige angabe ein");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte geben Sie eine richtige angabe ein");
                }
            }
        }
        static int meinZahl;
        static int antwort;
        static void ErzeugeMeinzahl()
        {
            Random meinRandom = new Random();


            meinZahl = meinRandom.Next(nummer1, nummer2);



        }
        static void Vergleich()
        {

            try
            {
                Console.WriteLine("Raten sie eine zahl jetzt");
                antwort = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Bitte geben sie ein richtige angabe ein");
            }



            while (true)
            {

                if (antwort < meinZahl)
                {
                    Console.WriteLine("Sein Zahl ist kleiner als mein Zahl");
                    Console.WriteLine("Bitte raten Sie nochmal");
                    antwort = Convert.ToInt32(Console.ReadLine());
                }

                if (antwort > meinZahl)
                {
                    Console.WriteLine("Sein Zahl ist großer als mein Zahl");
                    Console.WriteLine("Bitte raten Sie nochmal");
                    antwort = Convert.ToInt32(Console.ReadLine());
                }

                if (antwort == meinZahl)
                {
                    Console.WriteLine("Sie haben die Zahl richtig geraten!");
                    break;
                }
            }
        }
    }

