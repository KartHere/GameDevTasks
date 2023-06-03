using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float step;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            target = Player.transform.position;

        }
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}
