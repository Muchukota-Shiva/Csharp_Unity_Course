﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An explosion
/// </summary>
public class Explosion : MonoBehaviour
{
	// cached for efficiency
	Animator anim;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {		
		anim = GetComponent<Animator>();
        AudioManager.Play(AudioClipName.Explosion);
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// destroy the game object if the explosion has finished its animation
		if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
			Destroy(gameObject);
		}
	}
}
