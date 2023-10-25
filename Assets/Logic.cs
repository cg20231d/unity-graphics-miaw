using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int score;
    public Text scoreboard;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score = score + 1;
        scoreboard.text = score.ToString();
    }
}
