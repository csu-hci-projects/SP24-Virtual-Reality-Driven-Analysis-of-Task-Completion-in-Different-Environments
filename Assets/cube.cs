using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        //im thinking abut naming the buckets the name of the object so then it will be easy to reuse this script
        // for the rest of the objects 
        if (other.gameObject.tag == "cubeBox"){
            print("cube has been placed correctly");
            //

        }
        else{
            // record the error and send message to partipant 
        }
    }
}
