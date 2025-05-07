using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    private const double V = 4.2;
    public Transform target;
    float offsetX;

    float offsetY;
    void Start()
    {
        if (target == null)
            return;

        offsetX = transform.position.x - target.position.x;
        offsetY = transform.position.y - target.position.y;
    }


    void Update()
    {
        if (target == null) return;

        Vector3 pos = transform.position;
        if (target.position.x < 4 && target.position.x > -4)
        { 
           pos.x = target.position.x + offsetX;
        }

        if (target.position.y < 4.2 && target.position.y > -4.2)
        {
            pos.y = target.position.y + offsetY;
        }

        if (target.position.x > 4)
        {
            pos.x = 4;
        }
        if (target.position.x < -4)
        {
            pos.x = -4;
        }

        if (target.position.y > 4.2)
        {
            pos.y = (float)V;
        }
        if (target.position.y < -4.2)
        {
            pos.y = -(float)V;
        }

        transform.position = pos;
    }
}
