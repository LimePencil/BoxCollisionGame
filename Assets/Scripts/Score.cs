using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((int) playerPosition.position.z).ToString();
    }
}
