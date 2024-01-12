using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

	public int health = 500;
	public int enfado = 0;
    public GameObject botonEscena;
    
    public GameObject deathEffect;

	public bool isInvulnerable = false;

	void Start()
	{
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		
		switch (sceneIndex)
		{
			case 1:
				enfado = 250;
				break;
			case 2:
				enfado = 250;
				break;
			case 3:
				enfado = 500;
				break;
			case 4:
				enfado = 1500;
				break;
		}
	}

    public void TakeDamage(int damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;

		if (health <= enfado)
		{
			GetComponent<Animator>().SetBool("IsEnraged", true);
		}

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		//botonEscena.SetActive(true);
		
		EnemigosConteo.instance.EnemyDied();
	}

}
