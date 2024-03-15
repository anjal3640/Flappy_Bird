using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class middlescrpt : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag("logicm").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            
            birdScript.playerscore++;
            if (birdScript.playerscore > birdScript.highscore)
            {
                birdScript.highscore = birdScript.playerscore;
                PlayerPrefs.SetInt("HighScore", birdScript.highscore);
            }
        }
        
    }
}
