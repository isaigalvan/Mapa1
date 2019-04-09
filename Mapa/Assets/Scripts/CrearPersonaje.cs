using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrearPersonaje : MonoBehaviour
{
    public float posx, posy;
    public int idPersonaje;
    public GameObject personajePrefab, per;
    public Transform personajeParent;
   
    // Start is called before the first frame update
    void Start()
    {
        Crear();
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Crear()
    {
        posy = 4.5f; posx = 6;
        AsignarCoord();
        GameObject personajeTemp = Instantiate(personajePrefab, new Vector3(posx, posy, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        personajeTemp.transform.parent = personajeParent;
        per = GameObject.FindGameObjectWithTag("PerPref");
        per.GetComponent<Personaje>().AsignarTamanos();
        AsignarTexturas();  
    }
    void AsignarCoord()
    {
        switch (idPersonaje)
        {
            case 0:
                posy = 4.7f;
                break;
            case 1:
                posy = 4.5f;
                break;
            case 2:
                posy = 4.4f;
                break;
            case 3:
                posy = 4.1f;
                break;
            case 4:
                posy = 4.7f;
                break;
            case 5:
                posy = 4.5f;
                break;
            default:
                break;
        }

    }
    void AsignarTexturas()
    {
        switch (idPersonaje)
        {
            case 0:
                per.GetComponent<Animator>().SetFloat("personaje", 1f);
                break;
            case 1:
                per.GetComponent<Animator>().SetFloat("personaje", 2f);
                break;
            case 2:
                per.GetComponent<Animator>().SetFloat("personaje", 3f);
                break;
            case 3:
                per.GetComponent<Animator>().SetFloat("personaje", 4f);
                break;
            case 4:
                per.GetComponent<Animator>().SetFloat("personaje", 5f);
                break;
            case 5:
                per.GetComponent<Animator>().SetFloat("personaje", 6f);
                break;
            default:
                break;
        }      

    }

   

}