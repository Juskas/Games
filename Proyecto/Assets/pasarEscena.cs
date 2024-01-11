using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string nombreDeLaEscena;
    public GameObject botonEscena;

    public void CambiarAEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscena);
        botonEscena.SetActive(false);

    }
}