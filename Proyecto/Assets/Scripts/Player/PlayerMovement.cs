using UnityEngine;

namespace Player
{
	public class PlayerMovement : MonoBehaviour {

		public CharacterController2D controller;
		public Animator animator;

		public float runSpeed = 40f;

		float horizontalMove = 0f;
		bool jump = false;
		bool crouch = false;

		void Start()
		{
			ConservarVelocidad();
		}

		// Update is called once per frame
		void Update () {

			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
				animator.SetBool("IsJumping", true);
			}

			if (Input.GetButtonDown("Crouch"))
			{
				crouch = true;
			} else if (Input.GetButtonUp("Crouch"))
			{
				crouch = false;
			}

		}

		public void OnLanding ()
		{
			animator.SetBool("IsJumping", false);
		}

		public void OnCrouching (bool isCrouching)
		{
			animator.SetBool("IsCrouching", isCrouching);
		}

		void FixedUpdate ()
		{
			// Move our character
			controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
			jump = false;
		}
	
		private void ConservarVelocidad()
		{
			// Obtener el valor almacenado en PlayerPrefs
			float velocidadGuardada = PlayerPrefs.GetFloat("speed", -1f);

			// Usar el valor almacenado o el valor predeterminado
			runSpeed = (velocidadGuardada != -1f) ? velocidadGuardada : runSpeed;
		}
	}
}
