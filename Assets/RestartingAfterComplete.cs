using UnityEngine;

public class RestartingAfterComplete : MonoBehaviour
{
    void Restart()
    {
        FindObjectOfType<GameManager>().restart();
    }
}
