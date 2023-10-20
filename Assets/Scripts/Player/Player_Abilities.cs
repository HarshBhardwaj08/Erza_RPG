using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Abilities : MonoBehaviour
{   
    public static Player_Abilities instance;
    [Header("Dash")]
    public  float Dashtime;
    float Dash_cooldown = 0;
    public float Dash_cooldowntimer = 10;
    float intialspeed;
    float intialdashtime;
    public bool isDashing;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        intialspeed = Movements._instance.speed;
        intialdashtime = Dashtime;
    }
    private void Update()
    {
        
    }
    public void Player_Dash()
    {
        if (Dashtime <= 0)
        {
            Dash_cooldown += Time.deltaTime;
        }

        if (Dash_cooldown > Dash_cooldowntimer)
        {
            Dashtime = intialdashtime;
            Dash_cooldown = 0;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Dashtime -= Time.deltaTime;
            if (Dashtime > 0)
            {
                Movements._instance.speed = intialspeed * 4;
                isDashing = true;
            }
            else
            {
                Movements._instance.speed = intialspeed;

            }
        }
        else
        {
            isDashing = false;
        }

    }




}
