using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    public GameObject BallePrefab;
    public Transform BalleSpawnPoint;
    public float SpawnInterval;


    float TimeAccum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeAccum += Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && TimeAccum > SpawnInterval){
             Instantiate(BallePrefab, BalleSpawnPoint.position, transform.rotation);
             TimeAccum = 0;
        }   
    }
}