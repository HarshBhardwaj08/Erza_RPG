using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public static Movements _instance;
    [Range(0f, 50f)]
    public float speed;
    Animator anim;
    Rigidbody2D rg2d;
    SpriteRenderer renderer_2d;
    [SerializeField] float jumpforce;
    public bool isgrounded;

    [Header("CollisionInfo")]
    [SerializeField] float checkgrounddistance;
    [SerializeField] LayerMask whatisground;
    bool isMoving;
    [Header("Jump")]
    float value;
    int extrajump ;
    [SerializeField] int value_extrajump;
    int attackcounter;
    public bool isattack;
    // Start is called before the first frame update
    private void Awake()
    {

        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        rg2d = GetComponent<Rigidbody2D>();
        renderer_2d = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();    
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
       
    }

    public void Move()
    {
        if (isgrounded == true)
        {
            extrajump = value_extrajump;
        }
        isgrounded = Physics2D.Raycast(transform.position, Vector2.down, checkgrounddistance, whatisground);
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 movements = new Vector2(moveX * speed, rg2d.velocity.y);
        rg2d.velocity = movements;

        anim.SetBool("isAttacking", isattack);
        anim.SetInteger("attackCounter", attackcounter);


        if (Input.GetKeyDown(KeyCode.Space) && extrajump > 0)
        {

            rg2d.velocity = Vector2.up * jumpforce;
            extrajump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extrajump == 0 && isgrounded == true)
        {
            rg2d.velocity = Vector2.up * jumpforce;
        }
       

        if (moveX < 0)
        {
            renderer_2d.flipX = true;
        }
        else
        {
            renderer_2d.flipX = false;
        }
        value = rg2d.velocity.y;
        anim.SetFloat("yVelocity", rg2d.velocity.y);
        isMoving = rg2d.velocity.x != 0;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isattack = true;
           
         //   anim.SetTrigger("Attack1");
          
           
        
          
        }
       if(isgrounded == false)
        {
            Player_Abilities.instance.isDashing = false;
        }
        onattackCounter();
        Debug.Log(isattack);
        Debug.Log(attackcounter);
    }
   public float getValue()
    {
        return value;
    }
    void onattackCounter()
    {
        if (attackcounter > 2)
        {
            attackcounter = 0;
        }
    }
  
   
    public bool getisMoving()
    {
        return isMoving;
    }
    
    public void onAttack()
    {
        isattack = false;
        attackcounter++;
       
     

    }
}
