using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    public Vector2 Hedef;//Hedefi "Transform" yerine "Vector2" oluşturdum çünkü "Z" ekseni hareketlerini dikkate almamam gerek.
    public Transform AtesPoz;
   
    public GameObject Füze;
    public Transform CıkısNok;
    public Transform Bak;
    public AudioSource FüzeSesiDos;
    public AudioClip FüzeSesi;
    public Transform ArkaCıkıs;
    public Transform ÖnCıkıs;
    public GameObject PatriotPatlama;
    public GameObject BaslangıcÜs;
    public GameObject AsilÜst;
    public GameObject Canvas;
    public RectTransform Hedefİcon;
    public int OyunSayaci = 0;


    // Start is called before the first frame update

     void Start()
    {
        
        AsilÜst.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log(OyunSayaci);
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("Jet(Clone)"), 6f);
        Destroy(GameObject.Find("JetSag(Clone)"), 6f);
        Destroy(GameObject.Find("JetSes(Clone)"), 6f);
        Destroy(GameObject.Find("Hedefİcon(Clone)"), 0.1f);
        Destroy(GameObject.Find("SehirPatlama(Clone)"),6f);
        Debug.Log(OyunSayaci);
        if (OyunSayaci>=3)
        {
            Debug.Log("3 Sehir Yok Oldu");
        }

        Hedef = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        Atesleme();
        HedefTespit();
    }
  public  void Atesleme()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(BaslangıcÜs);
            AsilÜst.GetComponent<SpriteRenderer>().enabled = true;
            Instantiate(Füze, CıkısNok.position, transform.rotation);
            
            GameObject YeniParÖn = Instantiate(PatriotPatlama, ÖnCıkıs.transform.position, ÖnCıkıs.transform.rotation);

            
            Destroy(YeniParÖn, 2.0f);
            FüzeSesiDos.PlayOneShot(FüzeSesi);



        }
        
        
    }
    public Transform HedefTespit()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
           Transform YeniPoz  = Instantiate(AtesPoz, Hedef , Quaternion.identity);//Bu fonksiyon her füze için bir eşsiz bir transform üreterek döndürüyor.
            RectTransform YeniHedefİcon = Instantiate(Hedefİcon, Input.mousePosition, Quaternion.identity);
            /*YeniHedefİcon.transform.parent = GameObject.Find("Canvas").transform*/;//Parent clone edilen objenin hangi gameobjenin childi oldugunu belirlemek icin.

            //Hedefİcon.position = Input.mousePosition;
            YeniHedefİcon.transform.SetParent(Canvas.transform);//Parent clone edilen objenin hangi gameobjenin childi oldugunu belirlemek icin.


            return YeniPoz;

        }
        else
        {
            return null;
        }
        
        
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;//Burada Gizmos görülen büyüklüğü 1f bir Küre oluşturuyoruz.
        Gizmos.DrawSphere(transform.position, 1.0f);
    }


}
