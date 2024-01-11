using UnityEngine;

public class CamaraSeguimiento : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Puedes ajustar este offset según tus necesidades

    void Update()
    {
        if (playerTransform != null)
        {
            // Actualiza la posición de la cámara para que coincida con la posición del jugador más el offset
            transform.position = playerTransform.position + offset;
        }
    }
}