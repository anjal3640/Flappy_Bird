using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMESTRAT : MonoBehaviour
{
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject pipe;
    [SerializeField] private GameObject canvasscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void gamestrat()
    {
        gameObject.SetActive(false);
        bird.SetActive(true);
        pipe.SetActive(true);
        canvasscore.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
