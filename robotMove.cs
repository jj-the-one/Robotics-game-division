using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotMove : MonoBehaviour
{
    public bool isRight;
    public float speed = 10f;
    public float jump = 10f;
    public GameObject  rightBullet;
    public GameObject leftBullet;
    public float bulletspeed;
    [SerializeField] private Rigidbody2D rb;

    public bool Grounded;


    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
        Grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetAxisRaw("Horizontal") < 0)
        {
            isRight = false;
            transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, 0);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetAxisRaw("Horizontal") > 0)
        {
            isRight = true;
            transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, 0);
        }

        if(Input.GetKeyUp(KeyCode.C))
        {
            if(isRight)
            {
                Instantiate(rightBullet, new Vector3(transform.position.x + 4, transform.position.y), transform.rotation);
                bulletspeed = 10f;
            }
            else
            {
                Instantiate(leftBullet, new Vector3(transform.position.x - 4, transform.position.y), transform.rotation);
                bulletspeed = -10f;
            }
        }
        if(Grounded && Input.GetKeyUp(KeyCode.M))
        {
            Grounded = false;
            rb.AddForce(Vector2.up*jump, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
            Grounded = true;
        else
            Grounded = false;
    }
}
