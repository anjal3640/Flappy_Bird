using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class birdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidBody;
    [SerializeField] private Text score;
    [SerializeField] private Text hiscore;
    [SerializeField] private GameObject gameoverscreen;
    [SerializeField] private GameObject scoretextscreen;
    [SerializeField] private Text gameoverscore;
    [SerializeField] private Text gameoverhiscore;
    [SerializeField] private AudioSource sound;
    [SerializeField] private AudioSource whoosh;

    public static int playerscore;
    public static int highscore;
    private bool dead=false;
    private int temp=0;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highscore = 0;
            PlayerPrefs.SetInt("HighScore", highscore);
        }
        dead = false;
        playerscore = 0;
        hiscore.text = "High Score: " + highscore.ToString();
    }

    public void Resatrtgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        gameover();
    }

    public void gameover()
    {
        dead = true;
        setscore();
        scoretextscreen.SetActive(false);
        gameoverscreen.SetActive(true);
    }

    

    void setscore()
    {
        gameoverscore.text = "Score: " + playerscore.ToString();
        gameoverhiscore.text = "High Score: " + highscore.ToString();
    }
    // Update is called once per frame
    void Update()
    {

        if (temp != playerscore)
        {
            sound.Play();
            temp= playerscore;
        }

        score.text = playerscore.ToString();
        hiscore.text = "High Score: " + highscore.ToString();
        //if ((Input.GetKeyDown(KeyCode.Space)) && !dead)
        if (((Input.GetKeyDown(KeyCode.Mouse0))|| (Input.GetKeyDown(KeyCode.Space))) && !dead)
        {
            whoosh.Play();
            birdRigidBody.velocity = Vector2.up * 12;
        }
        if(transform.position.y < -17) {
            gameover();
        }
        
    }
}
