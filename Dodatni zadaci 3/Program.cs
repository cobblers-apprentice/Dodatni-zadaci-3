using System;

namespace Dodatni_zadaci_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodatni zadaci 3 \n\n");

            Console.WriteLine("Dodatni zadaci 3, zadatak 1 \n\n");
            // Napravi tablicu mnozenja 10 x 10

            int[,] matricaZad1 = new int[10, 10];
            int brojacZad1 = 0, brojacJedanZad1 = 1;

            for (int i = 0; i < 10; i++)
            {
                brojacZad1++;
                matricaZad1[i, 0] = brojacZad1;
                matricaZad1[0, i] = brojacZad1;
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    matricaZad1[i, j] = matricaZad1[i, 0] * matricaZad1[0, j];
                }
            }
            foreach (int item in matricaZad1)
            {
                Console.Write($"{item}   ");
                if (brojacJedanZad1 % 10 == 0)
                    Console.WriteLine();
                brojacJedanZad1++;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3, zadatak 2 \n\n");
            // 2.Napravi proizvoljnu matricu i ispisati najveći i najmanji član niza.

            int[,] matricaZad2 = new int[8, 8];
            int brojacZad2 = 1, minZad2 = 0, maxZad2 = 0, brojacJedanZad2 = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    brojacZad2++;
                    matricaZad2[i, j] = brojacZad2;
                    minZad2 = matricaZad2[0, 0];
                    maxZad2 = matricaZad2[0, 0];
                    if (matricaZad2[i, j] > maxZad2)
                        maxZad2 = matricaZad2[i, j];
                    if (matricaZad2[i, j] < minZad2)
                        minZad2 = matricaZad2[i, j];
                }
            }
            Console.WriteLine($"minimum matrice je {minZad2}, a maximum je {maxZad2}");

            foreach (int item in matricaZad2)
            {
                Console.Write($"{item}   ");
                if (brojacJedanZad2 % 8 == 0)
                    Console.WriteLine();
                brojacJedanZad2++;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3, zadatak 3 \n\n");
            // 3.Napravi proizvoljnu matricu i zameniti mesta najvećem i najmanjem članu niza.

            int[,] matricaZad3 = new int[7, 7];
            int brojacZad3 = 0, brojacJedanZad3 = 1, minZad3 = 0, maxZad3 = 0, koordinataIMin = 0,
                koordinataJMin = 0, koordinataIMax = 0, koordinataJMax = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    brojacZad3++;
                    matricaZad3[i, j] = brojacZad3;

                    minZad3 = matricaZad3[0, 0];
                    maxZad3 = matricaZad3[0, 0];
                    if (matricaZad3[i, j] < minZad3)
                    {
                        minZad3 = matricaZad3[i, j];
                        koordinataIMin = i;
                        koordinataJMin = j;
                    }
                    if (matricaZad3[i, j] > maxZad3)
                    {
                        maxZad3 = matricaZad3[i, j];
                        koordinataIMax = i;
                        koordinataJMax = j;
                    }
                }
            }

            matricaZad3[koordinataIMax, koordinataJMax] = minZad3;
            matricaZad3[koordinataIMin, koordinataJMin] = maxZad3;

            foreach (int item in matricaZad3)
            {
                Console.Write($"{item}   ");
                if (brojacJedanZad3 % 7 == 0)
                    Console.WriteLine();
                brojacJedanZad3++;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 4 \n\n");
            // 4. Napravi proizvoljnu matricu i ispisati najveći član ispod glavne dijagonale.

            int[,] matricaZad4 = new int[5, 5];
            int brojacZad4 = 0, brojacJedanZad4 = 1, maxZad4 = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    brojacZad4--;
                    matricaZad4[i, j] = brojacZad4;
                    maxZad4 = matricaZad4[0, 0];
                    if (matricaZad4[i, j] > maxZad4)
                        maxZad4 = matricaZad4[i, j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i > j)
                        matricaZad4[i, j] = maxZad4;
                }
            }

            foreach (int item in matricaZad4)
            {
                Console.Write($"{item}   ");
                if (brojacJedanZad4 % 5 == 0)
                    Console.WriteLine();
                brojacJedanZad4++;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 4 zadatak 6 \n\n");
            // 6.Napravi proizvoljnu matricu i naći u kojem redu je najveća aritmetička sredina.

            int[,] matricaZad6 = new int[5, 5];
            int brojacZad6 = 0, redZad6 = 1, averageZad6 = 0, sumaZad6 = 0, kucicaZad6, brojacJedanzad6 = 1, sumaJedanZad6 = 0;
            bool prvaProbaZad5 = true;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    brojacZad6--;
                    matricaZad6[i, j] = brojacZad6;
                    sumaZad6 += matricaZad6[i, j];
                }
                if (prvaProbaZad5)
                    for (int q = 0; q < 5; q++)
                    {
                        sumaJedanZad6 += matricaZad6[0, q];
                        averageZad6 = sumaJedanZad6 / 5;
                        prvaProbaZad5 = false;
                    }
                kucicaZad6 = sumaZad6 / 5;
                if (kucicaZad6 > averageZad6)
                {
                    redZad6 = i + 1;
                    averageZad6 = kucicaZad6;
                }

                sumaZad6 *= 0;
            }

            foreach (int item in matricaZad6)
            {
                Console.Write($"{item}   ");
                if (brojacJedanzad6 % 5 == 0)
                    Console.WriteLine();
                brojacJedanzad6++;
            }

            Console.WriteLine($"najveca aritmeticka sredina matrice se nalazi u {redZad6} redu, i iznosi {averageZad6}");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3, zadatak 5 \n\n");
            // 5.Izračunati i ispisati proizvod elemenata proizvoljne matrice koji nisu deljivi sa 3.

            int[,] matricaZad5 = new int[5, 5];
            int brojacZad5 = 0, proizvodZad5 = 1, brojacJedanZad5 = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    brojacZad5++;
                    matricaZad5[i, j] = brojacZad5;
                    if (matricaZad5[i, j] % 3 == 0)
                        proizvodZad5 *= matricaZad5[i, j];
                }
            }
            Console.WriteLine($"Proizvod clanova matrice deljivih sa 3 iznosi {proizvodZad5}");

            foreach (int item in matricaZad5)
            {
                Console.Write($"{item}   ");
                if (brojacJedanZad5 % 5 == 0)
                    Console.WriteLine();
                brojacJedanZad5++;
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 7 \n\n");
            // 7.Napraviti šemu rasporeda sedenja u avionu kao što je prikazano na slici1.Avion ima 24
            // reda sedišta, po 6 u redu, prolazom u sredini. Potrebno je prikazati izlaze na prednjem
            // delu i na sredini aviona.Nulama i jedinicama označiti da li je mesto rezervisano ili ne
            // (random generisati).

            int[,] matricaZad7 = new int[12, 12];
            int brojacZad7 = 0;
            Random rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                Console.Write("| |  ");
                for (int j = 0; j < 12; j++)
                {
                    matricaZad7[i, j] = rand.Next(2);
                    Console.Write($"{matricaZad7[i, j]}  ");
                    brojacZad7++;
                }

                if (brojacZad7 % 72 == 0)
                    Console.WriteLine("\n\n");

                else if (brojacZad7 % 24 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 8 \n\n");
            // 8. Napraviti jelku pomoću matrice po kojoj pada sneg kao na slici 2., random pahuljice oko drveta, da kazemo 6 pahuljica.

            string[,] matricaZad8 = new string[8, 9];
            int brojacZad8 = 0, brojacJedanZad8 = 0, brojacDvaZad8, brojacTriZad8 = 1, brojacCetiriZad8 = 4, brojacPetZad8 = 0;

            // ovde je jelka
            for (int i = 0; i < 8; i++)
            {
                for (brojacDvaZad8 = 4 - brojacZad8; brojacDvaZad8 <= brojacCetiriZad8; brojacDvaZad8++)
                {
                    matricaZad8[i, brojacDvaZad8] = "0";
                }

                // ovo je leva strana jelke
                brojacZad8++;
                if (brojacZad8 > 4 || brojacJedanZad8 > 0)
                {
                    brojacZad8 = 1;
                    brojacJedanZad8++;
                }
                // ovo je desna strana jelke
                brojacCetiriZad8++;
                if (brojacCetiriZad8 > 8 || brojacPetZad8 > 0)
                {
                    brojacCetiriZad8 = 5;
                    brojacPetZad8++;
                }
            }

            // ovde su pahulje

            int redNulaZad8 = 0, redJedanZad8 = 1, redDvaZad8 = 2, redTriZad8 = 3, randomZad8, randomJedanZad8 = 0;
            int[] kolonaZaRedNulaZad8 = { 0, 1, 2, 3, 5, 6, 7, 8 },
                  kolonaZaRedJedanZad8 = { 0, 1, 2, 6, 7, 8 },
                  kolonaZaRedDvaZad8 = { 0, 1, 7, 8 },
                  kolonaZaRedTriZad8 = { 0, 8 };

            for (int i = 0; i < 6; i++)
            {
                randomZad8 = rand.Next(0, 4);

                if (randomZad8 == 0)
                {
                    matricaZad8[randomZad8, kolonaZaRedNulaZad8[randomZad8 = rand.Next(0, 8)]] = "*";
                }
                else if (randomZad8 == 1)
                    matricaZad8[randomZad8, kolonaZaRedJedanZad8[randomZad8 = rand.Next(0, 6)]] = "*";
                else if (randomZad8 == 2)
                    matricaZad8[randomZad8, kolonaZaRedDvaZad8[randomZad8 = rand.Next(0, 4)]] = "*";
                else if (randomZad8 == 3)
                    matricaZad8[randomZad8, kolonaZaRedTriZad8[randomZad8 = rand.Next(0, 2)]] = "*";
            }

            // ovde je ispis, prazna polja i stablo
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matricaZad8[i, j] != "0" && matricaZad8[i, j] != "*")
                        matricaZad8[i, j] = " ";
                    if (i > 4 && j >= 3 && j <= 5)
                        matricaZad8[i, j] = "8";
                    Console.Write($" {matricaZad8[i, j]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 9 \n\n");
            // 9.Napraviti matricu 20x20, koja ispisuje iznad glavne dijagonala prosečne vrednosti
            // generisanih brojeva u intervalu od 1 do 30 koji su deljivi sa 5 i 10.

            // nije mi bas jasno sta se ovde trazi tako da cu da ga tretiram ovako:

            int[,] matricaZad9 = new int[20, 20];
            int brojacZad9 = 0, brojacJedanZad9 = 0, sumaZad9 = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    brojacZad9++;
                    matricaZad9[i, j] = brojacZad9;
                    if (matricaZad9[i, j] % 10 == 0 && matricaZad9[i, j] > 1 && matricaZad9[i, j] < 30)
                    {
                        brojacJedanZad9++;
                        sumaZad9 += matricaZad9[i, j];
                    }
                }
            }
            int averageZad9 = sumaZad9 / brojacJedanZad9;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j > i)
                        matricaZad9[i, j] = averageZad9;
                    Console.Write($" {matricaZad9[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Dodatni zadaci 3 zadatak 10 \n\n");
            //10. Napraviti proizvoljnu matricu koja ispisuje prosečnu vrednost najmanjeg i najvećeg člana.

            // nije mi jasno o cemu se ovde radi pa cu da ga tretiram ovako:

            int[,] matricaZad10 = new int[5, 5];
            int brojacZad10 = 0, maxZad10 = 0, minZad10 = 0, averageZad10;

            for (int i = 0; i < 5; i++)
            {
                maxZad10 = matricaZad10[0, 0];
                minZad10 = matricaZad10[0, 0];

                for (int j = 0; j < 5; j++)
                {
                    brojacZad10++;
                    matricaZad10[i, j] = brojacZad10;
                    if (matricaZad10[i, j] > maxZad10)
                        maxZad10 = matricaZad10[i, j];
                    if (matricaZad10[i, j] < minZad10)
                        minZad10 = matricaZad10[i, j];
                }
            }

            averageZad10 = (maxZad10 + minZad10) / 2;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matricaZad10[i, j] = averageZad10;
                    Console.Write($"{matricaZad10[i, j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Dodatni zadaci 3 zadatak 11 \n\n");
            // 11. Učitati matricu i naći u kojem redu je najveća suma.

            int[,] matricaZad11 = new int[5, 5];
            int brojacZad11 = 0, sumaZad11 = 0, kucicaZad11 = 0, redNajveceSumeZad11 = 0;
            bool probaZad11 = true;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    brojacZad11++;
                    matricaZad11[i, j] = brojacZad11;
                    kucicaZad11 += matricaZad11[i, j];
                }
                if (probaZad11)
                {
                    sumaZad11 = kucicaZad11;
                    probaZad11 = false;
                }
                if (kucicaZad11 > sumaZad11)
                {
                    redNajveceSumeZad11 = i;
                    sumaZad11 = kucicaZad11;
                }
                kucicaZad11 = 0;
            }

            Console.WriteLine($"Red sa najvecom sumom je {redNajveceSumeZad11}");

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 12 \n\n");
            // 12. Napravi matricu 10x10 i ispisati sumu svih neparnih brojeva u interval od 1 do 10 , iznad
            // dijagonale.

            // radim kao da treba prvo popuniti matricu i onda sumu neparnih brojeva npr 100 treba ispisati iznad dijagonale u ovom slucaju 45 puta. 
            // znaci 45 puta ispisati sumu(100)

            // Ovo je da izbrojim koliko ima mesta iznad dijagonale cisto radi preciznosti
            int[,] matricaZad12 = new int[10, 10];
            int brojacZad12 = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > i)
                    {
                        matricaZad12[i, j] = 1;
                        brojacZad12++;
                    }
                    Console.Write($"{matricaZad12[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(brojacZad12);

            Console.WriteLine();

            int[,] matricaJedanZad12 = new int[10, 10];
            int sumaNeparnihBrojeveZad12 = 0, brojacJedanZad12 = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matricaJedanZad12[i, j] = brojacJedanZad12++;
                    if (matricaJedanZad12[i, j] % 2 != 0 && matricaJedanZad12[i, j] < 11 && matricaJedanZad12[i, j] > 0)
                        sumaNeparnihBrojeveZad12 += matricaJedanZad12[i, j];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > i)
                        matricaJedanZad12[i, j] = sumaNeparnihBrojeveZad12;
                    Console.Write($"{matricaJedanZad12[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Dodatni zadaci 3 zadatak 13 \n\n");
            // Napravi prikaz kaoo ispod naveden
            // 0    0   0   0
            // 0    1   1   0
            // 0    1   1   0
            // 0    0   0   0

            int[,] matricaZad13 = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 1 || i == 2)
                        if (j == 1 || j == 2)
                            matricaZad13[i, j] = 1;
                    Console.Write($"  {matricaZad13[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("dalje?");
            Console.ReadKey();
            Console.Clear();












        }
    }
}
