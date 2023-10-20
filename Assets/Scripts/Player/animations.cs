using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    public static animations insatance;
    public GameObject actor;
    Animator animator;
    Commands space,move,dash;
    private void Awake()
    {
        insatance = this;
    }
    void Start() 
    {
        space = new PerformJump();
        move = new Move_animation();
        dash = new Dash_Animation();
        animator = actor. GetComponent<Animator>();
    }

  
   
    public void animation_erza()
    {
        move.Execute(animator);

       
            space.Execute(animator);
        
       
           dash.Execute(animator);
        
    }

}
