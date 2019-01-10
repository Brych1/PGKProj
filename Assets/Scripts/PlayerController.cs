using UnityEngine;

namespace Assets.Scripts
{
	public class PlayerController : MonoBehaviour
	{
		#region PublicFields

		public Quaternion TargetRotation { get; private set; }

		public Animator anim;
		public float inputDelay = 0.1f;
		public float forwardVel = 12;
		public float rotateVel = 100;

		#endregion

		#region PrivateFields

		private Rigidbody rBody;

		private float forwardInput,
			turnInput;

		#endregion

		#region UnityMethods

		private void Start()
		{
			TargetRotation = transform.rotation;
			rBody = GetComponent<Rigidbody>();
			forwardInput = turnInput = 0;
			anim = GetComponent<Animator>();
		}

		private void Update()
		{
			GetInput();
			Turn();
		}

		private void FixedUpdate()
		{
			Run();
		}

		#endregion

		#region PrivateMethods

		private void GetInput()
		{
			forwardInput = Input.GetAxis("Vertical");
			turnInput = Input.GetAxis("Horizontal");
		}

		private void Run()
		{
			if (Mathf.Abs(forwardInput) > inputDelay)
			{
				//move
				rBody.velocity = transform.forward * forwardInput * forwardVel;
			}
			else
			{
				rBody.velocity = Vector3.zero;
			}
		}

		private void Turn()
		{
			if (Mathf.Abs(turnInput) > inputDelay)
			{
				TargetRotation *= Quaternion.AngleAxis(rotateVel * turnInput * Time.deltaTime, Vector3.up);
			}

			transform.rotation = TargetRotation;
		}

		#endregion
	}
}
