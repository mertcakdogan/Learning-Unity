using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders3 : MonoBehaviour
{
    int a = 2, b = 3;
    void Start()
    {

        // İf - Else Yapısı
      /*
       if (a > b)
        {
            Debug.Log("a, b'den b�y�kt�r.");
        }
        else 
        {
            Debug.Log("a, b'den k���kt�r.");
        }
      */

        if (a == b)
        {
            Debug.Log("a, b'ye e�ittir.");
        }
        else 
        {
            Debug.Log("a, b'ye e�it de�ildir.");
        }

        /*
           
        Kar��la�t�rma Operat�rleri

        < K���kse
        > B�y�kse
        <= K���k veya e�itse
        >= B�y�k veya e�itse
        == E�itse
        != E�it de�ilse
         */

        /*
         
         Mant�ksal Operat�rler

        && Ve
        || Veya
        ! De�il

         */
    }
}
