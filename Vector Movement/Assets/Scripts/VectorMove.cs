using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Vector3.up;
        //We want our cube to move up and down between y = -10 and y =10
        //if we reached y = 10 and we were moving up, then we now move down
        if(transform.position.y >= 10 && speed > 0)
        {
            speed *= -1;
        }    
        else if(transform.position.y <= -10 && speed < 0){
            speed *= -1;
        }
        // also, if we reached y = -10 and were moving down, then 
    }
}
