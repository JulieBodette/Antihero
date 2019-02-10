using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")//if player touches lava
        {
            RetainData.data.health = 0; //auto kill player 
        }
    }
}
