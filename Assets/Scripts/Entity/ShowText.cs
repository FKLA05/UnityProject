using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowText : MonoBehaviour
{
    public GameObject uiTextObject;
    private bool isPlayerInZone = false;

    void Update()
    {
        if (isPlayerInZone && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("æ¿ ¿Ãµø");
            SceneManager.LoadScene("Flappy");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiTextObject.SetActive(true);
            isPlayerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            uiTextObject.SetActive(false);
            isPlayerInZone = false;
        }
    }
}



