using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int lives = 3;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private int coins;
    [SerializeField] private TextMeshProUGUI textMoney;
    [SerializeField] private LifeUI lifeUI;
   
    private bool isGrounded = false;
    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private int goldCount = 0;
 //   private int hearts = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coins")
        {
            coins+=100;
            goldCount+=100;
            textMoney.text = goldCount.ToString();
            
            print("Money: " + goldCount);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Floor")
        {
            Damage();
        }
        if (lives == 0)
        {
            var currSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene("Scene 0");
        }
        else if (collision.tag == "Slime")
        {
            lives -=1;
            lifeUI.RemoveHeart();
            Damage();
            

        }
    }
    private void Damage()
    {
       // lives--;
        //lifeUI.RemoveHeart();
        if (lives == 0)
        {
            Time.timeScale = 1;
            lifeUI.GameOver();
        }
    }
     
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponent<Animator>();
       // lifeUI = GetComponent<LifeUI>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }
    private void Update()
    {
        
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
       
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        if (Input.GetButton("Horizontal"))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
            sprite.flipX = dir.x < 0.0f;

        }
        anim.SetFloat("speedX", Mathf.Abs(dir.x));

        
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        
    }
    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position + Vector3.down*0.6f, 0.3f);
        isGrounded = collider.Length > 1;
        anim.SetBool("isGround", isGrounded);
        

    }
 

}


