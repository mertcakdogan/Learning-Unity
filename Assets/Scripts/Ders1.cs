using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders1 : MonoBehaviour
{
     string kanal_adi = "Mert Can";
     int abone_sayisi = 545;
     float boy = 1.75f;
     double dolar = 20.545455;
     bool oyun_bittimi = false;
     bool oyun_basladimi = true;

     void Start()
     {
         Debug.Log("Merhaba Unity");
         Debug.Log(kanal_adi);
         Debug.Log(abone_sayisi);
         Debug.Log(boy);
         Debug.Log(dolar);
         Debug.Log(oyun_bittimi);
         Debug.Log(oyun_basladimi);
     }
}
