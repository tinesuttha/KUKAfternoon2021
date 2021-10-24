using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float rotSpeed = 10f;
    float newRotY = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float newX = transform.position.x;
        float newY = transform.position.y;
        //float newZ = transform.position.y + 0.01f;
        float newZ = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow))
        {

            newZ = transform.position.z + (speed * Time.deltaTime);
            newRotY = 360;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            newZ = transform.position.z - (speed * Time.deltaTime);
            newRotY = 180;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            newX =transform.position.x- (speed * Time.deltaTime);
            newRotY = -90;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            newX = transform.position.x +(speed * Time.deltaTime);
            newRotY = 90;
        }

        transform.position = new Vector3(newX, newY, newZ);
        //transform.rotation = Quaternion.Euler(0, newRotY, 0);
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, newRotY, 0) , transform.rotation , rotSpeed * Time.deltaTime);


    }


    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
         
    }
}
