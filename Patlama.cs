using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patlama : MonoBehaviour
{
    public GameObject PatlamaParticle;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Roket"))
        {
            GameObject YeniParticle = Instantiate(PatlamaParticle, transform.position, transform.rotation);
            Destroy(YeniParticle, 4.0f);
            
            Vector2 Pozisyon = transform.position;
            Collider2D[] Küre = Physics2D.OverlapCircleAll(Pozisyon, 1.0f);//Burada bir Circle kollider dizisi oluşturduk
            
            foreach (Collider2D CarpilanNesne in Küre)
            {
                if (CarpilanNesne.transform.CompareTag("Roket"))
                {
                    
                    Destroy(CarpilanNesne.gameObject);
                }
            }
        }
        
    }
   


}
