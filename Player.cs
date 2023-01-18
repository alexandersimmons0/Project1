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
        Vector3 pos = transform.position
        public float speed = 20f;
        if(Input.GetKey(KeyCode.w)){ //I dont know anything about C# but this should do something
            pos.z += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.s)){
            pos.z -= speed * Time.deltaTime
        }
        if(Input.GetKey(KeyCode.a)){
            pos.x += speed * Time.deltaTime;
        }
        if(Input.Getkey(KeyCode.d)){
            pos.x -= speed * Time.deltaTime;
        }
        // either KeyCode.w or Input.GetKey("W") not sure yet
        transform.position = pos;
    }
}
