using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    #region Fields

    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    TextMeshProUGUI healthText;

    // score support
    int score = 0;
    const string ScorePrefix = "Score: ";

    // health support
    int health = 100;
    const string HealthPrefix = "Health: ";

    #endregion

    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        // initialize text values
        scoreText.text = ScorePrefix + score;
        healthText.text = HealthPrefix + health;
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Adds the given number of points to the score
    /// </summary>
    /// <param name="points">points to add</param>
    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score;
    }

    /// <summary>
    /// Sets the health
    /// </summary>
    /// <value>health</value>
    public void SetHealth(int health)
    {
        this.health = health;
        healthText.text = HealthPrefix + health;
    }

    #endregion
}
