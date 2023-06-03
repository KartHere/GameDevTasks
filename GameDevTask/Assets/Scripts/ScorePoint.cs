using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    public GameObject ScoreHandler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="Score")
        {
            ScoreHandler.GetComponent<ScoreDisplay>().AddScore();
            col.GetComponent<ChangeColor>().Changer();
            //Destroy(col.gameObject);
        }
        else if (col.tag == "Enemy")
        {
            gameObject.GetComponent<movement2D>().hitEnemy();
        }
    }
}
