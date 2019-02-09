using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetainData : MonoBehaviour
{
    public static RetainData data;//nice static reference
    // Start is called before the first frame update
    public bool HasJetpack;//set to true if player has jetpack
    void Awake()
    {
        if (data == null)
        {
            DontDestroyOnLoad(gameObject);
            data = this;
        }
        else if (data != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
