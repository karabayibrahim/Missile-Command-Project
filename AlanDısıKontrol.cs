using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlanDısıKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Füze"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Jet"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Roket"))
        {
            Destroy(collision.gameObject);
        }

    }
}
