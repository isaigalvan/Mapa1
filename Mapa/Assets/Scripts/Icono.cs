﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icono : MonoBehaviour
{
    public Sprite[] sprite;
    public SpriteRenderer spriteR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AsignarTextura(Sprite _sprite)
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = _sprite;
    }
}
