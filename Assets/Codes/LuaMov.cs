using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaMov : MonoBehaviour
{
    public GameObject terra;
    public float trans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(terra.transform.position, Vector3.up, trans);
    }
}
