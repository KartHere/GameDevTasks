using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject barrel;
    public GameObject triangle;
    private Vector2 bound;
    private Vector2 Vel;
    public float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
        StartCoroutine(espawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawn()
    {
        GameObject object1 = Instantiate(Bullet) as GameObject;
        object1.transform.position = barrel.transform.position;
        Vel = new Vector2(barrel.transform.position.x - triangle.transform.position.x, barrel.transform.position.y - triangle.transform.position.y);
        object1.GetComponent<Bullet>().SetVelocity(Vel);
    }
    IEnumerator espawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            spawn();
        }
    }
}
