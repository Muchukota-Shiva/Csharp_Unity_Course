using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Jumps the game object to a new location every second
/// </summary>
public class Jumper : MonoBehaviour
{
    // jump location support
    const float minX = -5;
    const float maxX = 5;
    const float minY = -2.5f;
    const float maxY = 2.5f;

    // timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position = position;
        }
    }
}
