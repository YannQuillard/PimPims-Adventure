using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform Cible;
    public Vector3 Offset;
    public Vector3 AxeRotate;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(AxeRotate);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Cible.transform.position + Offset;
    }
}
