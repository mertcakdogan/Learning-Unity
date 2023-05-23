using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders4 : MonoBehaviour
{
    // string[] sinif = { "Mert Can", "Emre", "Berru", "Kevser", "Ali", "Ayþe", "Veli", "Leyla" };
    int sayi = 0;
    void Start()
    {
        /*
        foreach (var ogrenciler in sinif)
        {
            Debug.Log(ogrenciler);
        }
        // Daha çok oyun içerisinde örneðin bir dükkanda satýlan ürünlerin listelenmesi gibi durumlarda kullanýlýr.
        */

        /*
        while (sayi < 15)
        {
            Debug.Log(sayi);
            sayi++;
        }
        // Döngü içerisindeki koþul saðlandýðý sürece döngü devam eder.
        */

        do
        {
            Debug.Log("Ben Do While kullanýlarak yazýldým.");
            sayi++;
        } while (sayi < 10);
        // Normalde 9 defa yazýlmasý gerekiyordu ama 10 defa yazýldý. Çünkü koþul döngü baþýnda do sayesinde kontrol ediliyor.

        // while ve do while arasýndaki fark: while döngüsünde koþul saðlanmazsa hiçbir þey yazýlmaz. do while döngüsünde ise koþul saðlanmasa bile bir defa yazýlýr.

        // while ve do while döngülerinde de break ve continue kullanýlabilir.

        // break: Döngüyü sonlandýrýr. 

        // continue: Döngüyü sonlandýrmaz ama o anki döngüyü atlar ve bir sonraki döngüye geçer.
    }

    
}
