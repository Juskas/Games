using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarBotones : MonoBehaviour
{
    [SerializeField] private GameObject botonEscena1;
    [SerializeField] private GameObject botonEscena2;
    [SerializeField] private GameObject botonEscena3;
    [SerializeField] private GameObject botonEscena4;

    public void DesactivarBotonesEscenas()
    {
        botonEscena1.SetActive(false);
        botonEscena2.SetActive(false);
        botonEscena3.SetActive(false);
        botonEscena4.SetActive(false);
        
    }
    
    
}
