using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogmaNokKodu : MonoBehaviour
{
    
    
    
    public GameObject Jet;
    public int Secim;
    public int YönSecim;
    public Transform Nokta1;
    public Transform Nokta2;
    public Transform Nokta3;
    public Transform Nokta4;
    public Transform SagNokta1;
    public Transform SagNokta2;
    public Transform SagNokta3;
    public Transform SagNokta4;
    public GameObject SagJet;


    void Start()
    {
        
        InvokeRepeating("JetDog", 0.0f, 20.0f);
    }
    private void Update()
    {
        YönSecim = Random.Range(1, 3);
        Secim = Random.Range(1, 5);
    }

    // Update is called once per frame

    void JetDog()
    {
        if (Secim==1&&YönSecim==1)
        {
            Vector2 Nok = Nokta1.position;
            Instantiate(Jet, Nok, Nokta1.transform.rotation);
        }
       else if (Secim==2 && YönSecim == 1)
        {
            Vector2 Nok = Nokta2.position;
            Instantiate(Jet, Nok, Nokta2.transform.rotation);
        }
        else if (Secim == 3 && YönSecim == 1)
        {
            Vector2 Nok = Nokta3.position;
            Instantiate(Jet, Nok, Nokta3.transform.rotation);
        }
        else if (Secim == 4 && YönSecim == 1)
        {
            Vector2 Nok = Nokta4.position;
            Instantiate(Jet, Nok, Nokta4.transform.rotation);
        }
        else if (Secim == 1 && YönSecim == 2)
        {
            Vector2 Nok = SagNokta1.position;
            Instantiate(SagJet, Nok, SagNokta1.transform.rotation);
        }
        else if (Secim == 2 && YönSecim == 2)
        {
            Vector2 Nok = SagNokta2.position;
            Instantiate(SagJet, Nok, SagNokta2.transform.rotation);
        }
        else if (Secim == 3 && YönSecim == 2)
        {
            Vector2 Nok = SagNokta3.position;
            Instantiate(SagJet, Nok, SagNokta3.transform.rotation);
        }
        else if (Secim == 4 && YönSecim == 2)
        {
            Vector2 Nok = SagNokta4.position;
            Instantiate(SagJet, Nok, SagNokta4.transform.rotation);
        }

    }
}
