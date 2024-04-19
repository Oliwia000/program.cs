using System;

internal class Program
{
    static Sortownia sortownia;
    static void Main(string[] args)
    {
        sortownia = new Sortownia();
        Console.ReadKey();
    }

    private int SzukajIndeksuMaxa(int j)
    {
        int id = j;
        for (int k = j; k < t.Length; k++)
            if (t[k] > t[id]) id = k;
        return id;
    }

    
}

    //*void selection_sort(int tab[], int i)
      //  int mn_index;
       // for (int z = 0; i < i - 1; i++)
         //   for (int j = i + 1; j < i; j++)
           //     if (tab[] < tab[mn_index])
            //        mn_index = j;
         //   mn_index = i;
          //  for (int z2 = 0; i < i - 1; i++) ;
 


/************************************* 
* nazwa funkcji: <> 
* parametry wejściowe:<> - <> 
* wartość zwracana:  <> 
* autor: <> 
*************************************/