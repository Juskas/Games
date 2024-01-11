using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteEscena : MonoBehaviour
{
    public string nombreDeLaEscena;
    public GameObject botonEscena;

    public void CambiarAEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscena);
        botonEscena.SetActive(false);

    }
}