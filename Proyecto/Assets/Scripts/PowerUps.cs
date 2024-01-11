
using Player;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private PlayerHealth player; 
    public void IncrementarVida()
    {
        player.health += 50; // idea inicial +50,
        
        // Guardar el nuevo valor en PlayerPrefs
        PlayerPrefs.SetInt("health", player.health);

        // Guardar los cambios
        PlayerPrefs.Save();
    }

    public void ConservarVida()
    {
        int saludActual = player.health;
        Debug.Log("vida actual: " + saludActual);

        // Guardar el valor actual en PlayerPrefs
        PlayerPrefs.SetInt("health", saludActual);

        // Guardar los cambios
        PlayerPrefs.Save();
    }
    public void ResetearStats()
    {
        player.health = 100; // idea inicial +50,
        
        // Guardar el nuevo valor en PlayerPrefs
        PlayerPrefs.SetInt("health", player.health);

        // Guardar los cambios
        PlayerPrefs.Save();
    }
}
