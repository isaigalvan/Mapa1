using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidades : MonoBehaviour
{
    public GameObject dado, per;
    public float tiempo;
    public bool actTiempo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (actTiempo == true) { tiempo = Time.deltaTime + tiempo; }
        per = GameObject.FindGameObjectWithTag("PerPref");
        terhab1zor();
    }

    public void habilidad1()
    {
       
        switch (GetComponent<CrearPersonaje>().idPersonaje)
        {
            case 0:
                hab1zorem();
                break;
            case 1:
               
                break;
            case 2:
               
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            default:
                break;
        }
    }

    public void hab1zorem()
    {
            actTiempo = true;
            GetComponent<Dado>().esTurno = false;
            per.GetComponent<Animator>().SetBool("hab1", true);
    }

    public void terhab1zor()
    {
        if (tiempo >= 3.5f)
        {   
            per.GetComponent<Personaje>().casillaActual = per.GetComponent<Personaje>().casillaActual + 3;
            per.GetComponent<Animator>().SetBool("hab1", false);
            per.GetComponent<Personaje>().imprimeCasilla();
            per.GetComponent<Personaje>().verificaCasilla();
            GetComponent<Dado>().esTurno = true;
            actTiempo = false;
            tiempo = 0;
           
        }
    }
}
