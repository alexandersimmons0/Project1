using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("xAxis");
        float zInput = Input.GetAxis("zAxis");
        float yInput = Input.GetAxis("yAxis");
        Vector3 movement = new Vector3(xAxis, yAxis, zAxis);
        
    }
}
