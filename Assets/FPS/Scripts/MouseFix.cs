using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnlockMouse();
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
