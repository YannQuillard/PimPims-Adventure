using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string name){
		SceneManager.LoadScene("Game");
	}
	// void OnCollisionEnter(Collision collision){
	// 	if (collision.gameObject){
	// 		SceneManager.LoadScene("Test");
	// 	}
	// }
}
