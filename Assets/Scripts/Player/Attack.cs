using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Movements player;
    private void Start()
    {
        player = GetComponent<Movements>();
    }
    public void onAnimationTrigger()
    {
        player.onAttack();
       
    }
  
}
