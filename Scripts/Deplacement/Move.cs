using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed = 4;
    public float rotationSpeed = 720;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movDirection = new Vector3(horizontalInput, 0, verticalInput);
        movDirection.Normalize();
        transform.Translate(movDirection * MoveSpeed * Time.deltaTime, Space.World);
        if (movDirection != Vector3.zero){
            Quaternion toRotation = Quaternion.LookRotation(movDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }


}