using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders3 : MonoBehaviour
{
    int a = 2, b = 3;
    void Start()
    {
      /*
       if (a > b)
        {
            Debug.Log("a, b'den büyüktür.");
        }
        else 
        {
            Debug.Log("a, b'den küçüktür.");
        }
      */

        if (a == b)
        {
            Debug.Log("a, b'ye eþittir.");
        }
        else 
        {
            Debug.Log("a, b'ye eþit deðildir.");
        }

        /*
           
        Karþýlaþtýrma Operatörleri

        < Küçükse
        > Büyükse
        <= Küçük veya eþitse
        >= Büyük veya eþitse
        == Eþitse
        != Eþit deðilse
         */

        /*
         
         Mantýksal Operatörler

        && Ve
        || Veya
        ! Deðil

         */
    }
}
