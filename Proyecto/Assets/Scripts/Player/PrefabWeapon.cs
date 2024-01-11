using UnityEngine;

namespace Player
{
	public class PrefabWeapon : MonoBehaviour {

		public Transform firePoint;
		public GameObject bulletPrefab;
	
		// Update is called once per frame
		void Update () {
			if (Input.GetMouseButtonDown(0))  //(Input.GetButtonDown("Fire1"))
			{
				Shoot();
			}
		}

		void Shoot ()
		{
			Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		}
	}
}
