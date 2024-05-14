using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class Sort
    {
        private int[] t = new int[10];
        
    /************************************* 
    * nazwa funkcji: <Sort> 
    * parametry wejściowe:<brak> - <brak> 
    * wartość zwracana:  <sortuje -(opis )Przyjmuje  10 liczb>
    *************************************/
        public Sort()
        {
            Console.WriteLine("Podaj 10 liczb całkowitych ");
            int licznik = 0;
            do
            {
                Console.WriteLine((licznik + 1).ToString() + ": ");
                t[licznik] = int.Parse(Console.ReadLine());
                licznik++;
            } while (licznik < 10);

        }

     /************************************* 
    * nazwa funkcji: <PokazTablice> 
    * parametry wejściowe:<brak> - <brak> 
    * wartość zwracana:  <Pokazuje liczby wpisane przez użytkownika.> 
    *************************************/
    public void PokazTablice()
        {
            for (int i = 0; i < t.Length; i++)
                Console.WriteLine(String.Format("{0}", t[i]));
        }

    /************************************* 
    * nazwa funkcji: <SzukajIndeksuMaxa> 
    * parametry wejściowe:<int j> - <> 
    * wartość zwracana:  <funkcja szuka najwyższwej liczby.> 
    *************************************/
    private int SzukajIndeksuMaxa(int j)
        {
            int id = j;
            for (int k = j; k < t.Length; k++)
                if (t[k] > t[id]) id = k;
            return id;
        }

    /************************************* 
    * nazwa funkcji: <Sortuj> 
    * parametry wejściowe:<brak> - <brak> 
    * wartość zwracana:  <Funkcja sortuje wszystkie liczby od najwiękzej.> 
    * autor: <Oliwia Strzelczyk 3d> 
    *************************************/
    public void Sortuj()
        {
            for (int i = 0; i < t.Length; i++)
            {
                int id = SzukajIndeksuMaxa(i);
                int bufor = t[i];
                t[i] = t[id];
                t[id] = bufor;
            }
        }
}

   
