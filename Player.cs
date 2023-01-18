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
    public float speed = 20f;
    void Update()
    {
        Vector3 pos = transform.position;    
        if (Input.GetKey(KeyCode.W)){ //I dont know anything about C# but this should do something
            pos.z += speed* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)){
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)){
            pos.x += speed * Time.deltaTime;
        }
// either KeyCode.w or Input.GetKey("W") not sure yet
        transform.position = pos;
    }
}
