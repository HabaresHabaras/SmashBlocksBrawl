using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour {
    //how much it grows each time
    public float scaleFactor = 1.2f;

    //maximum scale
    public float maxScale = 3;

    void Start(){
        if(scaleFactor <= 1){
            print("It's too small");
        }
    }
    void OnMouseDown(){
        //access the scale   &&      //increase this value
        //class transform from the sphere in Unity
        transform.localScale *= scaleFactor;
        //check if we've passed the maxScale

        if(transform.localScale.x >= maxScale){
            //if so destroy the ballon
            Destroy(gameObject);

        }


        //else not do aything

    }


}
