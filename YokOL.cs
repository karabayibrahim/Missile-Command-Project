using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokOL : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sehir"))
        {
            Destroy(gameObject);
        }
    }
}
