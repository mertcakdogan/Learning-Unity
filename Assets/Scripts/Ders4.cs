using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders4 : MonoBehaviour
{
    // string[] sinif = { "Mert Can", "Emre", "Berru", "Kevser", "Ali", "Ay�e", "Veli", "Leyla" };
    int sayi = 0;
    void Start()
    {

        // Foreach - While - Do While Döngüleri
        /*
        foreach (var ogrenciler in sinif)
        {
            Debug.Log(ogrenciler);
        }
        // Daha �ok oyun i�erisinde �rne�in bir d�kkanda sat�lan �r�nlerin listelenmesi gibi durumlarda kullan�l�r.
        */

        /*
        while (sayi < 15)
        {
            Debug.Log(sayi);
            sayi++;
        }
        // D�ng� i�erisindeki ko�ul sa�land��� s�rece d�ng� devam eder.
        */

        do
        {
            Debug.Log("Ben Do While kullan�larak yaz�ld�m.");
            sayi++;
        } while (sayi < 10);
        // Normalde 9 defa yaz�lmas� gerekiyordu ama 10 defa yaz�ld�. ��nk� ko�ul d�ng� ba��nda do sayesinde kontrol ediliyor.

        // while ve do while aras�ndaki fark: while d�ng�s�nde ko�ul sa�lanmazsa hi�bir �ey yaz�lmaz. do while d�ng�s�nde ise ko�ul sa�lanmasa bile bir defa yaz�l�r.

        // while ve do while d�ng�lerinde de break ve continue kullan�labilir.

        // break: D�ng�y� sonland�r�r. 

        // continue: D�ng�y� sonland�rmaz ama o anki d�ng�y� atlar ve bir sonraki d�ng�ye ge�er.
    }

    
}
