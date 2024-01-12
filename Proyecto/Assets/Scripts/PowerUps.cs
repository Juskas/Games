
using Player;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PrefabWeapon playerAtaque;
    public void IncrementarVida()
    {
        player.health += 50;
        PlayerPrefs.SetInt("health", player.health);
        PlayerPrefs.Save();
    }
    public void IncrementarVelocidad()
    {
        playerMovement.runSpeed += 20f;
        PlayerPrefs.SetFloat("speed", playerMovement.runSpeed);
        PlayerPrefs.Save();
    }
    public void IncrementarAtaque()
    {
        playerAtaque.damageAdicional += 20;
        PlayerPrefs.SetInt("ataque", playerAtaque.damageAdicional);
        PlayerPrefs.Save();
    }
    public void ConservarStats()
    {
        int saludActual = player.health;
        PlayerPrefs.SetInt("health", saludActual);
        
        float velocidadActual = playerMovement.runSpeed;
        PlayerPrefs.SetFloat("speed", velocidadActual);
        
        int ataqueActual = playerAtaque.damageAdicional;
        PlayerPrefs.SetInt("ataque", ataqueActual);
        
        PlayerPrefs.Save();
    }
    public void ResetearStats()
    {
        player.health = 100;
        playerMovement.runSpeed = 30f;
        playerAtaque.damageAdicional = 0;
        
        PlayerPrefs.SetInt("health", player.health);
        PlayerPrefs.SetFloat("speed", playerMovement.runSpeed);
        PlayerPrefs.SetInt("ataque", playerAtaque.damageAdicional);
        
        PlayerPrefs.Save();
    }
}
