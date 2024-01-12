using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class VelocidadDisplay : MonoBehaviour
    {
        public PlayerMovement playerVelocidad;  // Asigna la referencia al script PlayerHealth en el Inspector
        private TextMeshProUGUI _velocidadText;

        void Start()
        {
            _velocidadText = GetComponent<TextMeshProUGUI>();
            UpdateVelocidadDisplay();
        }

        void Update()
        {
            // Puedes actualizar el texto continuamente si lo deseas
            // En este ejemplo, lo actualizaremos solo cuando haya cambios en el valor de health
            if (float.TryParse(_velocidadText.text.Replace("Velocidad: ", ""), out float currentVelocidad) && currentVelocidad != playerVelocidad.runSpeed)
            {
                UpdateVelocidadDisplay();
            }
        }

        void UpdateVelocidadDisplay()
        {
            // Actualiza el texto con el valor actual de health
            _velocidadText.text = "Velocidad: " + playerVelocidad.runSpeed.ToString();
        }
    }
}