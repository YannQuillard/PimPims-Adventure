using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
		public Vector3 JumpForce = new Vector3(0, 220, 0);

		public bool grounded = true;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetButtonDown("Jump") && grounded == true) {
			// Debug.Log(grounded);
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(JumpForce);
			grounded = false;
		} 
	}


	public void canJump(){
		grounded = true;
	}
}