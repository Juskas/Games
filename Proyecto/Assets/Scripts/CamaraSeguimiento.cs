using UnityEngine;

public class CamaraSeguimiento : MonoBehaviour
{
    public Transform playerTransform;
    public float smoothSpeed = 1.5f;
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Puedes ajustar este offset según tus necesidades

    void LateUpdate()
    {
        if (playerTransform != null)
        {
            // Actualiza la posición de la cámara para que coincida con la posición del jugador más el offset
            //transform.position = playerTransform.position + offset;
            Vector3 desiredPosition = playerTransform.position + offset;

            // Solo actualiza la posición en el eje X
            desiredPosition.y = transform.position.y;
            desiredPosition.z = transform.position.z;
            
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Aplica la nueva posición a la cámara
            transform.position = smoothedPosition;
        }
    }
}