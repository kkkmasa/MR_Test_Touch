using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSharkController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigi;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        rigi.velocity = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
