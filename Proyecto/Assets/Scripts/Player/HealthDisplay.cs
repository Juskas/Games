using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class HealthDisplay : MonoBehaviour
    {
        public PlayerHealth playerHealth;  // Asigna la referencia al script PlayerHealth en el Inspector
        private TextMeshProUGUI _healthText;

        void Start()
        {
            _healthText = GetComponent<TextMeshProUGUI>();
            UpdateHealthDisplay();
        }

        void Update()
        {
            // Puedes actualizar el texto continuamente si lo deseas
            // En este ejemplo, lo actualizaremos solo cuando haya cambios en el valor de health
            if (int.TryParse(_healthText.text.Replace("Health: ", ""), out int currentHealth) && currentHealth != playerHealth.health)
            {
                UpdateHealthDisplay();
            }
        }

        void UpdateHealthDisplay()
        {
            // Actualiza el texto con el valor actual de health
            _healthText.text = "Health: " + playerHealth.health.ToString();
        }
    }
}