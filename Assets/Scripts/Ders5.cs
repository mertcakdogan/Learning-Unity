using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders5 : MonoBehaviour
{
    // Ders5: Switch Case - List Kavram�

    public int sayi_degeri;

    void Start()
    {

        // if d�ng�s�
        /*
        if (sayi_degeri == 1)
        {
            print ("Say� de�eri 1'e e�ittir.");
        }
        else if (sayi_degeri == 2)
        {
            print ("Say� de�eri 2'ye e�ittir.");
        }
        else if (sayi_degeri == 3)
        {
            print ("Say� de�eri 3'e e�ittir.");
        }
        else
        {
            print ("Say� de�eri 1 ve 2 olarak girilmedi.");
        }

        */

        // Switch Case
        /*
        switch (sayi_degeri)
        {
            case 1:
                print ("Say� de�eri 1'e e�ittir.");
                break;
            case 2:
                print ("Say� de�eri 2'ye e�ittir.");
                break;
            case 3:
                print ("Say� de�eri 3'e e�ittir.");
                break;
            default:
                print ("Say� de�eri 1, 2 ve ya 3 olarak girilmedi.");
                break;
         }
        */

        // List Kavram�

        List<int> yaslar = new List<int>();

        yaslar.Add(25); yaslar.Add(30); yaslar.Add(35); yaslar.Add(40); yaslar.Add(45); yaslar.Add(50); yaslar.Add(55);

        List<string> isimler = new List<string>();

        isimler.Add("Mert Can"); isimler.Add("Emre"); isimler.Add("Berru"); isimler.Add("Kevser"); isimler.Add("Ahmet");

        //Debug.Log("Ya�lar listesinin 3. eleman�: " + yaslar[2]); // 35

        //Debug.Log("�simler listesinin 4. eleman�: " + isimler[3]); // Ahmet

        //Debug.Log("Toplam girilen ya� de�eri: " + yaslar.Count);

        //Debug.Log("Toplam girilen isim de�eri: " + isimler.Count);

        /*
        foreach (int yas in yaslar)
        {
            Debug.Log("Ya�lar listesinin elemanlar�: " + yas);
        }
        */

        

        yaslar.Insert(0, 20);

        yaslar.Remove(30);

        for (int i = 0; i < yaslar.Count; i++)
        {
            Debug.Log("Ya�lar listesinin elemanlar�: " + yaslar[i]);
        }

        if (isimler.Contains("Can"))
        {
            Debug.Log("�simler listesinde Can ismi bulunmaktad�r.");
        }
        else
        {
            Debug.Log("�simler listesinde Can ismi bulunmamaktad�r.");
        }
    }
}

   

