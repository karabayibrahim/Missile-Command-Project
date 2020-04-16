using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Füze : MonoBehaviour
{
    Transform Hedef;
    Rigidbody2D rg;
    public Transform YokPoint;
    
    void Start()
    {
        Hedef = FindObjectOfType<Ates>().HedefTespit();
        
        
        rg = GetComponent<Rigidbody2D>();
         

    }

    // Update is called once per frame
    
     void FixedUpdate()
    {
        Bakma();
        

    }
    void Bakma()
    {
        
        Vector3 Direction = Hedef.position - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        rg.rotation = angle;
        rg.AddForce(Hedef.position - transform.position);
        

    }
}
