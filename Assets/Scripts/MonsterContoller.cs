using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class MonsterContoller : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private Transform MarkerL;
    [SerializeField] private Transform MarkerR;
    //[SerializeField] private Transform sensorGround;
   //[SerializeField] private LifeUI lifeUI;

    private Rigidbody2D rb;
    private Animator anim;
    //private SpriteRenderer sr;
    private bool isRight = true;
    private int hp = 10;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponent<Animator>();
        // lifeUI = GetComponent<LifeUI>();
    }

    private void Update()
    {
        if (transform.position.x > MarkerR.position.x)
        {
            isRight = false;
        }
        else if (transform.position.x < MarkerL.position.x)
            {

            isRight = true;

        }
        if (isRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            sprite.flipX = false;
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            sprite.flipX = true;
        }
    }

 /*   void Turn()
    {
        if (isRight)
        {
            if(transform.position.x > MarkerR.position.x)
            {
                isRight = false;
                sr.flipX = true;
            }
            else
            {
                if (transform.position.x < MarkerL.position.x)
                {
                    isRight = true;
                    sr.flipX = false;
                }
            }
        }

    }
    private void FixedUpdate()
    {
        Turn();
        float move = isRight ? 1 : -1;
        rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);
       // anim.SetFloat("speedX", Mathf.Abs(move));
       
    }

    void Flip(float move)
    {
        if (move < 0 && isRight)
        { }

        else if (move > 0 && !isRight)
        { }
        
    }
 
    private void Damage()
    {
         hp--;
        lifeUI.RemoveHeart();
        if (hp == 0)
        {
            Time.timeScale = 0;
            lifeUI.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "monster")
        {
            hp -= 2;
            if (hp <= 0)
            {
                Destroy(transform.parent.gameObject);
            }
        }

    }*/

}
