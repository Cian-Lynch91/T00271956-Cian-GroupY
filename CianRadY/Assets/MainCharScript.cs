using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharScript : MonoBehaviour
{
    float runningSpeed = 3f;
    float turningSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.W)) 
            transform.position += runningSpeed*transform.forward * Time.deltaTime;
        
        
            if (Input.GetKey(KeyCode.S)) 
            transform.position -= runningSpeed*transform.forward* Time.deltaTime;
        
        
            if (Input.GetKey(KeyCode.D)) 
            transform.Rotate(transform.up, 45* Time.deltaTime);

            if(Input.GetKey(KeyCode.Space))
            transform.position += runningSpeed * transform.up * Time.deltaTime;
        
        
            //if (Input.GetKeyUp(KeyCode.A)) ;
        


      


    }
}
