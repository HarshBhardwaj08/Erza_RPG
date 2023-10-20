using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erza : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Movements._instance.Move();
        animations.insatance.animation_erza();
        Player_Abilities.instance.Player_Dash();
    }
}
