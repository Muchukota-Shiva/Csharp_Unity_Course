﻿using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour
{
	/// <summary>
	/// Awake is called before Start
	/// </summary>
	void Awake()
	{
        ConfigurationUtils.Initialize();
	}
}
