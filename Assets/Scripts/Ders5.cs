using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders5 : MonoBehaviour
{
    // Ders5: Switch Case - List Kavramý

    public int sayi_degeri;

    void Start()
    {

        // if döngüsü
        /*
        if (sayi_degeri == 1)
        {
            print ("Sayý deðeri 1'e eþittir.");
        }
        else if (sayi_degeri == 2)
        {
            print ("Sayý deðeri 2'ye eþittir.");
        }
        else if (sayi_degeri == 3)
        {
            print ("Sayý deðeri 3'e eþittir.");
        }
        else
        {
            print ("Sayý deðeri 1 ve 2 olarak girilmedi.");
        }

        */

        // Switch Case
        /*
        switch (sayi_degeri)
        {
            case 1:
                print ("Sayý deðeri 1'e eþittir.");
                break;
            case 2:
                print ("Sayý deðeri 2'ye eþittir.");
                break;
            case 3:
                print ("Sayý deðeri 3'e eþittir.");
                break;
            default:
                print ("Sayý deðeri 1, 2 ve ya 3 olarak girilmedi.");
                break;
         }
        */

        // List Kavramý

        List<int> yaslar = new List<int>();

        yaslar.Add(25); yaslar.Add(30); yaslar.Add(35); yaslar.Add(40); yaslar.Add(45); yaslar.Add(50); yaslar.Add(55);

        List<string> isimler = new List<string>();

        isimler.Add("Mert Can"); isimler.Add("Emre"); isimler.Add("Berru"); isimler.Add("Kevser"); isimler.Add("Ahmet");

        //Debug.Log("Yaþlar listesinin 3. elemaný: " + yaslar[2]); // 35

        //Debug.Log("Ýsimler listesinin 4. elemaný: " + isimler[3]); // Ahmet

        //Debug.Log("Toplam girilen yaþ deðeri: " + yaslar.Count);

        //Debug.Log("Toplam girilen isim deðeri: " + isimler.Count);

        /*
        foreach (int yas in yaslar)
        {
            Debug.Log("Yaþlar listesinin elemanlarý: " + yas);
        }
        */

        

        yaslar.Insert(0, 20);

        yaslar.Remove(30);

        for (int i = 0; i < yaslar.Count; i++)
        {
            Debug.Log("Yaþlar listesinin elemanlarý: " + yaslar[i]);
        }

        if (isimler.Contains("Can"))
        {
            Debug.Log("Ýsimler listesinde Can ismi bulunmaktadýr.");
        }
        else
        {
            Debug.Log("Ýsimler listesinde Can ismi bulunmamaktadýr.");
        }
    }
}

   

