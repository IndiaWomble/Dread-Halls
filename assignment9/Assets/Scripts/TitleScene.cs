using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audioSource = FindObjectsOfType<AudioSource>();
        foreach (AudioSource i in audioSource)
            Destroy(i.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Submit") == 1)
            SceneManager.LoadScene("Title");
    }
}
