
using UnityEngine;

public class TransicionDialogos : MonoBehaviour
{
    public MonoBehaviour playerMovement;
    public MonoBehaviour playerWeapon;

    void Start()
    {
        Invoke("Desactivar", 1f);
    }

    void Desactivar()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
        if (playerWeapon != null)
        {
            playerWeapon.enabled = false;
        }
    }
}