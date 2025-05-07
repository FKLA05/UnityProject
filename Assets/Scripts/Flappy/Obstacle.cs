using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float hightPosY = 1f;
    public float lowPosY = -1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;  
    }

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfholeSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfholeSize);
        bottomObject.localPosition = new Vector3(0, -halfholeSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY, hightPosY);

        transform.position = placePosition;

        return placePosition;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player player = collision.GetComponent<player>();
        if (player != null)
        {
            gameManager.AddScore(1);
        }
    }
}
