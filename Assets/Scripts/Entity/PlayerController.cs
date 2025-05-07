using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera maincamera;

    protected override void Start()
    {
        base.Start();
        maincamera = Camera.main;
    }
   
    

     void OnMove()
     {
         float horizontal = Input.GetAxisRaw("Horizontal");
         float vertial = Input.GetAxisRaw("Vertical");
         movementDirection = new Vector2(horizontal, vertial).normalized;
     }

     void OnLook()
     {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}










