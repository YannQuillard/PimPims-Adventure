using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBDN : MonoBehaviour

{
	public Vector3 Deplacement = new Vector3 (0, 1, 0) ;
	public float Vitesse; 
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Deplacement.normalized * Vitesse * Time.deltaTime);
		
	}
}
