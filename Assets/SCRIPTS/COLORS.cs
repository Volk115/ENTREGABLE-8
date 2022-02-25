using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLORS : MonoBehaviour
{
    //NOMBRE DE LOS TEXTOS
    public GameObject ROJO;
    public GameObject AZUL;   

    void OnMouseOver()
    {
        //OTORGA AL JUGADOR EL COLOR SELECCIONADO MEDIANTE LOS BOTONES
        if (gameObject.tag == "BOTON_ROJO")
        {
            ROJO.SetActive(true);
        }

        //AL PASAR EL CURSOR POR ENCIMA DEL BOTON, SE EXPLICA SU FUNCION
        if (gameObject.tag == "BOTON_AZUL")
        {
            AZUL.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        ROJO.SetActive(false);
        AZUL.SetActive(false);
    }
}
