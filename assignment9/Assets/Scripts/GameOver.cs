using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2.0f)
        {
            Destroy(audioSource);
            MazeText.ResetMazeNumber();
            SceneManager.LoadScene("GameOver");
        }
    }
}
