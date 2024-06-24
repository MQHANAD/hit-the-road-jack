using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class movment : MonoBehaviour
{
    public Rigidbody rb;
    private int currentXpos = -3;
    private bool clicked = false;


    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            if (currentXpos > -9 && !clicked)
            {
                currentXpos = currentXpos - 6;
                clicked = true;
            }
        }
        else if (Input.GetKey("d"))
        {
            if (currentXpos < 9 && !clicked)
            {
                currentXpos = currentXpos + 6;
                clicked = true;
            }
        }
        else
        {
            clicked = false;
        }
        move();
    }

    private void move()
    {
        Vector3 dest = new Vector3(currentXpos, rb.position.y, rb.position.z);
        rb.transform.position = Vector3.MoveTowards(rb.transform.position, dest, 0.08f);
    }
    
}
