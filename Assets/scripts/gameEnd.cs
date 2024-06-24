using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public sectionMovement mov;

    void OnCollisionEnter(Collision collinfo)
    {
        Debug.Log(collinfo.collider.tag);
        if (collinfo.collider.tag == "obstacle")
        {
            mov.enabled = false;
        }
    }
}
