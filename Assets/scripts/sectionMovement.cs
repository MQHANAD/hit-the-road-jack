using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Collections.Specialized.BitVector32;

public class sectionMovement : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -25) * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
    }
}
