using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders2 : MonoBehaviour
{

    // For Döngüsü
   /*
    int miktar = 10;
    void Start()
    {
        for (int sayi = 0; sayi < miktar; sayi++)
        {
            if (sayi %2 != 0) continue;
            
            Debug.Log("Say�m�z�n De�eri: " + sayi);
            
        }
    }

   */

   void Start()
   {
       string[] isimler = new string[3];

       string[] arabalar = new string[] {"BMW", "Mercedes", "Audi"};

       string[] sehirler = {"Ankara", "�stanbul", "�zmir"};

       // Debug.Log("2. araban�n markas�: " + arabalar[1]);

        string[][] sehirler2 = new string[3][];
        sehirler2[0] = new string[] {"Ankara", "�stanbul", "�zmir"};
        sehirler2[1] = new string[] {"�ankaya", "Kad�k�y", "Buca"};
        sehirler2[2] = new string[] {"06", "34", "35"};

        Debug.Log("�l: " + sehirler2[0][0] + ", �l�e: " + sehirler2[1][0] + ", Plaka Kodu: " + sehirler2[2][0]);


    }

}
