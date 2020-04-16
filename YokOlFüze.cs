using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokOlFüze : MonoBehaviour
{
    public GameObject PatlamaParticle;
    public bool KontrolPatlama = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Füze"))
        {
            KontrolPatlama = true;
            GameObject YeniParticle = Instantiate(PatlamaParticle, transform.position, transform.rotation);
            Destroy(YeniParticle, 4.0f);
            
            Vector2 Pozisyon = transform.position;
            Collider2D[] Küre = Physics2D.OverlapCircleAll(Pozisyon, 1.0f);//Burada bir Circle kollider dizisi oluşturduk.Bu sayede patlama alanı oluşturarak o alan içene giren nesneleri algılayabilir ve yok edebiliriz.

            foreach (Collider2D CarpilanNesne in Küre)
            {
                if (CarpilanNesne.transform.CompareTag("Roket"))
                {
                    
                    Destroy(CarpilanNesne.gameObject);
                    
                }
            }
            Destroy(collision.gameObject);
            Destroy(gameObject,0.5f);
        }
        if (collision.gameObject.CompareTag("Sehir"))
        {
            Destroy(gameObject);
        }
    }
}
