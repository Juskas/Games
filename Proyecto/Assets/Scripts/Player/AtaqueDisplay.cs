using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class AtaqueDisplay : MonoBehaviour
    {
        public PrefabWeapon playerAtaque;  // Asigna la referencia al script PlayerHealth en el Inspector
        private TextMeshProUGUI _ataqueText;

        void Start()
        {
            _ataqueText = GetComponent<TextMeshProUGUI>();
            UpdateHealthDisplay();
        }

        void Update()
        {
            // Puedes actualizar el texto continuamente si lo deseas
            // En este ejemplo, lo actualizaremos solo cuando haya cambios en el valor de health
            if (int.TryParse(_ataqueText.text.Replace("Ataque: ", ""), out int currentAtaque) && currentAtaque != playerAtaque.damageAdicional)
            {
                UpdateHealthDisplay();
            }
        }

        void UpdateHealthDisplay()
        {
            // Actualiza el texto con el valor actual de health
            _ataqueText.text = "Ataque: " + (playerAtaque.damageAdicional + 40).ToString();
        }
    }
}