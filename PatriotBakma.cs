using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatriotBakma : MonoBehaviour
{
    Transform Hedef;
    Rigidbody2D rg;
    void Start()
    {
        
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Hedef = FindObjectOfType<Ates>().HedefTespit();
        if (Hedef!=null)
        {
            Vector3 Direction = Hedef.position-transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
            rg.rotation = angle;
        }
        
    }
}
