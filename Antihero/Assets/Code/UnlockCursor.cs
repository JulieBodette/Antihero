using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    //use to unlock cursor in gameover and win screens
    //previosly the cursor was locked for better player movement in scene Poop
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("Unlocking Cursor");
    }

}
