using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "BreakableBarrier")
        {
            Debug.Log("collide with barrier");
            if (Input.GetKeyDown(KeyCode.B))
            {
                
                Destroy(other.gameObject);
            }
        }
    }


}
