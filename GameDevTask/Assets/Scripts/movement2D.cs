using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2D : MonoBehaviour
{
    private Rigidbody2D rb2D;
    float x_dir, y_dir;
    public float duration = 1;
    public bool isMoving;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (!isMoving)
            Movement();
    }
    // Update is called once per frame
    void Movement()
    {
        Vector3 fixDist;
        x_dir = Input.GetAxis("Horizontal");
        y_dir = Input.GetAxis("Vertical");
        Vector2 curr_pos = new Vector2(transform.position.x, transform.position.y);
        //Head.transform.position = new Vector2(0.0f,1.35f+headBob*y_dir)+curr_pos;
        if (Input.GetKeyDown("a")|| Input.GetKeyDown("d"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(x_dir,0).normalized);
            fixDist = new Vector3(x_dir, 0,0).normalized*0.5f;
            if (hit.collider != null)
            {
                StartCoroutine(MovePlayer(new Vector3(hit.point.x,transform.position.y, 0) - fixDist));
            }
        }
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0,y_dir).normalized);
            fixDist= new Vector3(0, y_dir,0).normalized*0.5f;
            if (hit.collider != null)
            {
                StartCoroutine(MovePlayer(new Vector3(transform.position.x,hit.point.y,0) -fixDist));
            }
        }
    }

    public void hitEnemy()
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator MovePlayer(Vector3 targetPosition)
    {
        float timeElapsed = 0;
        isMoving = true;
        Vector3 startPosition = transform.position;
        while (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        isMoving = false;
    }
}
