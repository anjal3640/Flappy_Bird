using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    private float spawnrate=3;
    private float timer = 0;
    private float spawntime;
    private float heightoffset = 6; 
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        spawntime = ((birdScript.playerscore / 5) * 0.3f) + 1; 
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer= 0;
        }

        
    }
}
