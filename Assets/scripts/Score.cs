using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public TMP_Text scoreText;
    private int score = 0 ;
    public Transform shape;
    
    void Update()
    {

        scoreText.text = (int)(Math.Abs(shape.position.z - 61.60486)  )+ "";
    }
}
