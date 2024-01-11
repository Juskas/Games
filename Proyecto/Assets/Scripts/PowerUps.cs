
using Player;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PrefabWeapon playerAtaque;
    public void IncrementarVida()
    {
        player.health += 50; // idea inicial +50,
        
        // Guardar el nuevo valor en PlayerPrefs
        PlayerPrefs.SetInt("health", player.health);

        // Guardar los cambios
        PlayerPrefs.Save();
    }

    public void IncrementarVelocidad()
    {
        // Incrementar la velocidad del jugador
        playerMovement.runSpeed += 20f;

        // Guardar el nuevo valor de velocidad en PlayerPrefs
        PlayerPrefs.SetFloat("speed", playerMovement.runSpeed);

        // Guardar los cambios
        PlayerPrefs.Save();
    }

    public void IncrementarAtaque()
    {
        playerAtaque.damageAdicional += 20;
        PlayerPrefs.SetInt("ataque", playerAtaque.damageAdicional);

        // Guardar los cambios
        PlayerPrefs.Save();
    }

    public void ConservarStats()
    {
        int saludActual = player.health;
        //Debug.Log("vida actual: " + saludActual);

        // Guardar el valor actual en PlayerPrefs
        PlayerPrefs.SetInt("health", saludActual);
        
        float velocidadActual = playerMovement.runSpeed;
        //Debug.Log("Velocidad actual: " + velocidadActual);

        // Guardar el valor actual de velocidad en PlayerPrefs
        PlayerPrefs.SetFloat("speed", velocidadActual);

        int ataqueActual = playerAtaque.damageAdicional;
        
        PlayerPrefs.SetInt("ataque", ataqueActual);

        // Guardar los cambios
        PlayerPrefs.Save();
    }
    public void ResetearStats()
    {
        player.health = 100; // idea inicial +50,
        
        playerMovement.runSpeed = 40f;

        playerAtaque.damageAdicional = 0;

        // Guardar los nuevos valores en PlayerPrefs
        PlayerPrefs.SetInt("health", player.health);
        PlayerPrefs.SetFloat("speed", playerMovement.runSpeed);
        PlayerPrefs.SetInt("ataque", playerAtaque.damageAdicional);

        // Guardar los cambios
        PlayerPrefs.Save();
    }
}
