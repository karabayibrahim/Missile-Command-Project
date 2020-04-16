using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Üret : MonoBehaviour
{
    public GameObject HavaBomba;
    public Vector2 RandomPos;
    GameObject Sehir;
    int sayi;
    void Start()
    {
        
        InvokeRepeating("ÜretDüs", 0.0f, 2.0f);
        Sehir = GameObject.FindGameObjectWithTag("Sehir");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ÜretDüs()//Bu Fonksiyonda havadan düşen bombalar üretiyoruz belirli konumlar aralığında ve random sayilarda üretim söz konusu.
    {
        sayi = Random.Range(1, 8);
        for (int i = 0; i < sayi; i++)
        {
            Vector2 Vec = new Vector2(Random.Range(-RandomPos.x, RandomPos.x), 6f);

            GameObject YeniHavaBomba = Instantiate(HavaBomba, Vec, transform.rotation);
        }
       
        
        
    }
}