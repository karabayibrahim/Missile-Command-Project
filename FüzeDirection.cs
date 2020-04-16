using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FüzeDirection : MonoBehaviour
{
    Rigidbody2D rg;
    //Transform Sehir;
    //Transform Sehir2;
    Transform S1;
    Transform S2;
    Transform S3;
    Transform S4;
    Transform S5;
    Transform S6;
    

    float MassSecim;
    int Secim;
    public float hiz;

    void Start()
    {
        
        S1 = GameObject.Find("S1").transform;
        S2 = GameObject.Find("S2").transform;
        S3 = GameObject.Find("S3").transform;
        S4 = GameObject.Find("S4").transform;

        S5 = GameObject.Find("S5").transform;
        S6 = GameObject.Find("S6").transform;
        
        rg = gameObject.GetComponent<Rigidbody2D>();
        
        Secim = Random.Range(1, 7);
        MassSecim = Random.Range(1, 6);
        rg = GetComponent<Rigidbody2D>();
        rg.mass = MassSecim;//Mass değerlerini değiştirdik
        #region RastgeleYönKonumlandırma
        if (Secim==1)
        {
            //Hedef yöne bakmasını sağladık.
            Vector3 Direction = S1.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
            

        }
        else if (Secim==2)
        {
            Vector3 Direction = S2.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        else if (Secim==3)
        {
            Vector3 Direction = S3.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        
        else if (Secim == 4 )
        {
            Vector3 Direction = S4.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        else if (Secim == 5 )
        {
            Vector3 Direction = S5.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        else if (Secim == 6 )
        {
            Vector3 Direction = S6.position - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        
        #endregion
        

    }

    
    void FixedUpdate()
    {
        #region RandomForce
        if (Secim == 1 )
        {
            //Force uyguluyoruz.
            rg.AddForce(S1.transform.position - transform.position);

        }
        else if (Secim == 2 )
        {

            rg.AddForce(S2.transform.position - transform.position);
        }
        else if (Secim == 3 )
        {

            rg.AddForce(S3.transform.position - transform.position);
        }
        else if (Secim == 4 )
        {

            rg.AddForce(S4.transform.position - transform.position);
        }
        else if (Secim == 5 )
        {

            rg.AddForce(S5.transform.position - transform.position);
        }
        else if (Secim == 6 )
        {

            rg.AddForce(S6.transform.position - transform.position);
        }
        
        #endregion

        

    }
}


