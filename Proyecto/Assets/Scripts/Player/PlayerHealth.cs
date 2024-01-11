using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
	public class PlayerHealth : MonoBehaviour
	{

		public int health = 100;

		public GameObject deathEffect;
		
		void Start()
		{
			// Obtener el valor almacenado en PlayerPrefs
			int saludGuardada = PlayerPrefs.GetInt("health", 100);

			// Asignar el valor a la salud del jugador
			health = saludGuardada;
		}

		public void TakeDamage(int damage)
		{
			health -= damage;

			StartCoroutine(DamageAnimation());

			if (health <= 0)
			{
				Die();
			}
		}

		void Die()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		IEnumerator DamageAnimation()
		{
			SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

			for (int i = 0; i < 3; i++)
			{
				foreach (SpriteRenderer sr in srs)
				{
					Color c = sr.color;
					c.a = 0;
					sr.color = c;
				}

				yield return new WaitForSeconds(.1f);

				foreach (SpriteRenderer sr in srs)
				{
					Color c = sr.color;
					c.a = 1;
					sr.color = c;
				}

				yield return new WaitForSeconds(.1f);
			}
		}

	}
}
