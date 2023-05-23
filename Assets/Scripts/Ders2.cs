using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders2 : MonoBehaviour
{
   /*
    int miktar = 10;
    void Start()
    {
        for (int sayi = 0; sayi < miktar; sayi++)
        {
            if (sayi %2 != 0) continue;
            
            Debug.Log("Sayýmýzýn Deðeri: " + sayi);
            
        }
    }

   */

   void Start()
   {
       string[] isimler = new string[3];

       string[] arabalar = new string[] {"BMW", "Mercedes", "Audi"};

       string[] sehirler = {"Ankara", "Ýstanbul", "Ýzmir"};

       // Debug.Log("2. arabanýn markasý: " + arabalar[1]);

        string[][] sehirler2 = new string[3][];
        sehirler2[0] = new string[] {"Ankara", "Ýstanbul", "Ýzmir"};
        sehirler2[1] = new string[] {"Çankaya", "Kadýköy", "Buca"};
        sehirler2[2] = new string[] {"06", "34", "35"};

        Debug.Log("Ýl: " + sehirler2[0][0] + ", Ýlçe: " + sehirler2[1][0] + ", Plaka Kodu: " + sehirler2[2][0]);


    }

}
