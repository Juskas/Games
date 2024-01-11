using UnityEngine;

namespace Player
{
	public class PrefabWeapon : MonoBehaviour {

		public Transform firePoint;
		public GameObject bulletPrefab;

		public int damageAdicional = 0;
	
		// Update is called once per frame
		void Start()
		{
			ConservarAtaque();
		}
		void Update () {
			if (Input.GetMouseButtonDown(0))  //(Input.GetButtonDown("Fire1"))
			{
				Shoot();
			}
		}

		void Shoot ()
		{
			GameObject nuevaBala = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
			
			Bullet scriptBala = nuevaBala.GetComponent<Bullet>();

			if (scriptBala != null)
			{
				// Modificar el valor de damage
				scriptBala.ModificarDamage(scriptBala.damage + damageAdicional);
			}
		}
		private void ConservarAtaque()
		{
			// Obtener el valor almacenado en PlayerPrefs
			int ataqueGuardado = PlayerPrefs.GetInt("ataque", -1);

			// Usar el valor almacenado o el valor predeterminado
			damageAdicional = (ataqueGuardado != -1) ? ataqueGuardado : damageAdicional;
		}
	}
}
