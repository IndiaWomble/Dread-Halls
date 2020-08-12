using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeText : MonoBehaviour
{
    static int maze = 1;
    Text mazeText;

    // Start is called before the first frame update
    void Start()
    {
        mazeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mazeText.text = "Maze - " + maze.ToString();
    }

    public static void IncrementMaze()
    {
        maze++;
    }

    public static void ResetMazeNumber()
    {
        maze = 1;
    }
}
