using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class Commands 
{
    public abstract void Execute(Animator anim);
  
}
public class PerformJump : Commands
{
    public override void Execute(Animator anim  )
    {  
        
        bool isgrounded = Movements._instance.isgrounded;
     //   anim.SetFloat("yVelocity", Movements._instance.getValue());
        anim.SetBool("isGround",isgrounded );
    }
   
}

public class Move_animation : Commands
{
    public override void Execute(Animator anim)
    {   
        bool isMoving = Movements._instance.getisMoving();
        anim.SetBool("isRunning", isMoving);
       // Debug.Log(isMoving);
    }
}

public class Dash_Animation : Commands
{
    public override void Execute(Animator anim)
    {
        bool isDash = Player_Abilities.instance.isDashing;
        anim.SetBool("isDash", isDash);
    }
}