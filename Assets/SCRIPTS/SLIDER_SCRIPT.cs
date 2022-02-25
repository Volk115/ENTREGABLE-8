using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLIDER_SCRIPT : MonoBehaviour
{
    //PERMITE LA ROTACION DEL PERSONAJE GRACIAS AL SLIDER
    public void Rotation(float sizeRotation)
    {
        gameObject.transform.rotation = Quaternion.Euler(0, sizeRotation * 15, 0);
    }

}
