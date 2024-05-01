using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Halo : MonoBehaviour
{
    //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int col = 0;
    int err = 0;
    void OnCollisionEnter(Collision other){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        col += 1;
    if (other.gameObject.tag == gameObject.tag){
        print( "Collison object: " + gameObject.tag + "coll count: " + col + "Curr Secne Index: " + currentSceneIndex);
      //  print("coll count: " + col); "other gameobject : " + other.gameObject.tag +
       Destroy(other.gameObject);
       // Debug.Log("collision count : " + col + "testing");
    }
    else{
        err += 1;
        print("wrong selection for object: " + gameObject.tag + "total ,wrong colliusions: " + col + " , " + err + "Curr Secne Index: " + currentSceneIndex);

    }
    
    }   
}