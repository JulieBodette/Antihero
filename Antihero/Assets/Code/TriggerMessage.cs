using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMessage : MonoBehaviour
{
    public GameObject messagebox; //the UI panel with text, attach in inspector
    public GameObject Player; //attatch player in inspector
    public string message;

    private void Start()
    {
        messagebox.transform.GetChild(0).GetComponent<Text>().text = message;
        //this.gameObject.transform.GetChild(0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("set message active");
            messagebox.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            messagebox.SetActive(false);
        }
    }
}
