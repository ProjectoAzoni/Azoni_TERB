using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Provisional : MonoBehaviour
{
    public GameObject boton;
    public GameObject level2;
    public int var=0;

    private void Update()
    {
       
        if (var == 1)
        {
            boton.SetActive(false);
            level2.SetActive(false);
        }
        else
        {
            boton.SetActive(true);
            level2.SetActive(true);
        }

    }
    
    
}

