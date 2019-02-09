using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("got jetpack");
            RetainData.data.HasJetpack = true; //set variable to true 
            //player class checks this variable to see if it can fly
            Destroy(this.gameObject); //destroy the jetpack once it has been picked up
        }
       
    }
}
