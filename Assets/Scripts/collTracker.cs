using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halo : MonoBehaviour
{
    int col = 0;
    int err = 0;
    void OnCollisionEnter(Collision other){
        col += 1;
    if (other.gameObject.tag == gameObject.tag){
        print("halo correct\n");
        print("coll count: " + col);
       // Destroy(other.gameObject);
    }
    else{
        print("wrong selection");
        err += 1;
    }
    
    }   
}