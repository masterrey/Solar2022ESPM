using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosCopia : MonoBehaviour
{
    public GameObject alvo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alvo.transform.position;
    }
}
