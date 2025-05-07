using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bglooper : MonoBehaviour
{
    public int numBgCount = 5;
    public int obstacleCount = 0;
    public Vector3 obstacleLastPosition = Vector3.zero;


    void Start()
    {
        Obstacle[] obatacle = GameObject.FindObjectsOfType<Obstacle>();
        obstacleCount = obatacle.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPosition = obatacle[i].SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("BackGround"))
        {
            float WidthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += WidthOfBgObject * numBgCount;
            collision.transform.position = pos;
            return;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstacleLastPosition = obstacle.SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }
}
