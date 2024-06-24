using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject section;
    public AudioSource background;
    public TMP_Text text;

    void OnCollisionEnter(Collision collinfo)
    {
        if (collinfo.collider.tag == "obstacle")
        {
            Time.timeScale = 0f;
            background.Stop();
            text.enabled = true;
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("newSection"))
        {
            Instantiate(section,new Vector3(-2.611841f, 138.8981f, 463),Quaternion.identity);
        }
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(section);
        }
    }
}
