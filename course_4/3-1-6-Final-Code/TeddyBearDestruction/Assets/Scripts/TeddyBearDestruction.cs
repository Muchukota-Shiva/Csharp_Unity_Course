using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Game manager
/// </summary>
public class TeddyBearDestruction : MonoBehaviour
{
	// score support
	[SerializeField]
	TextMeshProUGUI scoreText;
	int score = 0;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {		
		// set initial score text
		scoreText.text = "Score: " + score;

		// add as listener for event
		EventManager.AddListener(AddPoints);
	}

	/// <summary>
	/// Adds the given points to the score
	/// </summary>
	/// <param name="points">points to add</param>
	void AddPoints(int points)
    {
		score += points;
		scoreText.text = "Score: " + score;
	}
}
