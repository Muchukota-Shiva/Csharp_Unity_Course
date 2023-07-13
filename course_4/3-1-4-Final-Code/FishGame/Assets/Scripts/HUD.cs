using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    // score support
    TextMeshProUGUI scoreText;
    int score = 0;
    const string ScorePrefix = "Score: ";

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
        // initialize score text
        scoreText = GameObject.FindWithTag("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText.text = ScorePrefix + score;

        // add self as points added event listener
        Fish fishScript = GameObject.FindWithTag("Fish").GetComponent<Fish>();
        fishScript.AddPointsAddedEventListener(AddPoints);
	}

    /// <summary>
    /// Updates the score
    /// </summary>
    /// <param name="points">points to add</param>
    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score;
    }
}
