using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float thrust = 10f;
    public Rigidbody rb;
    public SphereCollider col;
    public LayerMask groundLayers; //set this to the default layer in the inspector so the player can jump off anythiung
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        if (isGrounded() || RetainData.data.HasJetpack) //if the player is on the ground, they can jump. Remove this requirement for jetpack.
        {
            Debug.Log("is grounded was true");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("jumping");
                rb.AddForce(Vector3.up * thrust);
            }
        }
        transform.Translate(straffe, 0, translation);



            if (Input.GetKeyDown(KeyCode.Escape))
                Cursor.lockState = CursorLockMode.None;
        
    }
    public bool isGrounded() //test if the player is on the ground (if they are above any object on the "default" layer)
    {
        Debug.Log("checking is grounded"+ Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers));
    //check a space smaller than the collider and also slightly underneath the collider
    //check groundlayers only
    //remember to set groundlayers to the default layer in the inspector so the player can jump off anything by default
    return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
    }
}
