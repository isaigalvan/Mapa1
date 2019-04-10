using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidades : MonoBehaviour
{
    public GameObject scripts, per;
    public float tiempo;
    public bool actTiempo = false;
    public bool esHab1=false, esHab2=false, esHab3= false, condi = false;
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
        scripts = GameObject.Find("Scripts");
        terminarHabilidades();
    }

    public void habilidad1()
    {
        
        esHab1 = true;
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
        per.GetComponent<Personaje>().ph = per.GetComponent<Personaje>().ph - 1;
        per.GetComponent<Personaje>().imprimePh();
        scripts.GetComponent<Dado>().estadoHabilidades();
    }
    public void habilidad2()
    {
        esHab2 = true;
        switch (GetComponent<CrearPersonaje>().idPersonaje)
        {
            case 0:
                //hab2zorem();
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
        per.GetComponent<Personaje>().ph = per.GetComponent<Personaje>().ph - 2;
        per.GetComponent<Personaje>().imprimePh();
        scripts.GetComponent<Dado>().estadoHabilidades();
    }
    public void habilidad3()
    {
        esHab3 = true;
        switch (GetComponent<CrearPersonaje>().idPersonaje)
        {
            case 0:
                hab3zorem();
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
        per.GetComponent<Personaje>().ph = per.GetComponent<Personaje>().ph - 3;
        per.GetComponent<Personaje>().imprimePh();
        scripts.GetComponent<Dado>().estadoHabilidades();
    }
   

    public void hab1zorem()
    {
            actTiempo = true;
            GetComponent<Dado>().esTurno = false;
            per.GetComponent<Animator>().SetBool("hab1", true);
    }
    public void terhab1zor()
    {
        
        if (tiempo >= 2.5f)
        {
            
            if (condi == false&&tiempo >= 2f)
            {
                GetComponent<CrearPersonaje>().posx = GetComponent<CrearPersonaje>().posx + 6;
                per.transform.localPosition = new Vector3(scripts.GetComponent<CrearPersonaje>().posx, scripts.GetComponent<CrearPersonaje>().posy);
                condi = true;
            }
        }
        if (tiempo >= 3.5f)
        {
           
            per.GetComponent<Personaje>().casillaActual = per.GetComponent<Personaje>().casillaActual + 3;
            per.GetComponent<Animator>().SetBool("hab1", false);
            per.GetComponent<Personaje>().imprimeCasilla();
            per.GetComponent<Personaje>().verificaCasilla();
            GetComponent<Dado>().esTurno = true;
            actTiempo = false;
            tiempo = 0;
            esHab1 = false;
        }
    }
    public void hab3zorem()
    {
        actTiempo = true;
        GetComponent<Dado>().esTurno = false;
        per.GetComponent<Animator>().SetBool("hab3", true);
    }
    public void terhab3zor()
    {
        if (tiempo >= 3.5f)
        {
            scripts.GetComponent<Dado>().valorMax = 12;
            per.GetComponent<Animator>().SetBool("hab3", false);
            GetComponent<Dado>().esTurno = true;
            actTiempo = false;
            tiempo = 0;
            esHab3 = false;
        }
    }
   

    public void terminarHabilidades()
    {
        if (esHab1 == true)
        {
            terhab1zor();
            
        }
        if (esHab2 == true)
        {
            //terhab2zor();
            
        }
        if (esHab3 == true)
        {
            terhab3zor();
            
        }
    }
}
