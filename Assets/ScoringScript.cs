﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoringtextP1, scoringtextP2;
    private int scoreP1= 0, scoreP2= 0;
    void Start()
    {
        scoringtextP1.text = scoreP1.ToString();
        scoringtextP2.text = scoreP2.ToString();
    }

    public void UpdateScore(string namaWall){
        if (namaWall == "kiri"){
            scoreP2 +=1;
            scoringtextP2.text = scoreP2.ToString();
        }else if(namaWall == "kanan"){
            scoreP1 += 1;
            scoringtextP1.text = scoreP1.ToString();
        }
    }

    
}
