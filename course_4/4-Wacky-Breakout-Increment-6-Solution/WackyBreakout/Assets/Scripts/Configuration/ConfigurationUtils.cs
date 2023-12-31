﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public static float BallLifeSeconds
    {
        get { return configurationData.BallLifeSeconds; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving
    /// </summary>
    public static float BallImpulseForce
    {
        get { return DifficultyUtils.BallImpulseForce; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    public static float MinSpawnSeconds
    {
        get { return DifficultyUtils.MinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    public static float MaxSpawnSeconds
    {
        get { return DifficultyUtils.MaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the number of balls per game
    /// </summary>
    public static int BallsPerGame
    {
        get { return configurationData.BallsPerGame; }
    }

    /// <summary>
    /// Gets how many points a standard block is worth
    /// </summary>
    public static int StandardBlockPoints
    {
        get { return configurationData.StandardBlockPoints; }
    }

    /// <summary>
    /// Gets how many points a bonus block is worth
    /// </summary>
    public static int BonusBlockPoints
    {
        get { return configurationData.BonusBlockPoints; }
    }

    /// <summary>
    /// Gets how many points an effect block is worth
    /// </summary>
    public static int EffectBlockPoints
    {
        get { return configurationData.EffectBlockPoints; }
    }

    /// <summary>
    /// Gets the probability that a standard block
    /// will be added to the level
    /// </summary>
    /// <value>standard block probability</value>
    public static float StandardBlockProbability
    {
        get { return configurationData.StandardBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a bonus block
    /// will be added to the level
    /// </summary>
    /// <value>bonus block probability</value>
    public static float BonusBlockProbability
    {
        get { return configurationData.BonusBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a freezer block
    /// will be added to the level
    /// </summary>
    /// <value>freezer block probability</value>
    public static float FreezerBlockProbability
    {
        get { return configurationData.FreezerBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a speedup block
    /// will be added to the level
    /// </summary>
    /// <value>speedup block probability</value>
    public static float SpeedupBlockProbability
    {
        get { return configurationData.SpeedupBlockProbability; }
    }

    /// <summary>
    /// Gets the duration of the freezer effect
    /// in seconds
    /// </summary>
    /// <value>freezer seconds</value>
    public static float FreezerSeconds
    {
        get { return configurationData.FreezerSeconds; }
    }

    /// <summary>
    /// Gets the speedup factor
    /// </summary>
    /// <value>speedup factor</value>
    public static float SpeedupFactor
    {
        get { return configurationData.SpeedupFactor; }
    }

    /// <summary>
    /// Gets the duration of the speedup effect
    /// in seconds
    /// </summary>
    /// <value>speedup seconds</value>
    public static float SpeedupSeconds
    {
        get { return configurationData.SpeedupSeconds; }
    }

    #endregion

    #region Properties for DifficultyUtils use only

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving in an easy game
    /// </summary>
    public static float EasyBallImpulseForce
    {
        get { return configurationData.EasyBallImpulseForce; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving in a medium game
    /// </summary>
    public static float MediumBallImpulseForce
    {
        get { return configurationData.MediumBallImpulseForce; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving in a hard game
    /// </summary>
    public static float HardBallImpulseForce
    {
        get { return configurationData.HardBallImpulseForce; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// in an easy game
    /// </summary>
    public static float EasyMinSpawnSeconds
    {
        get { return configurationData.EasyMinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// in a medium game
    /// </summary>
    public static float MediumMinSpawnSeconds
    {
        get { return configurationData.MediumMinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// in a hard game
    /// </summary>
    public static float HardMinSpawnSeconds
    {
        get { return configurationData.HardMinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// in an easy game
    /// </summary>
    public static float EasyMaxSpawnSeconds
    {
        get { return configurationData.EasyMaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// in a medium game
    /// </summary>
    public static float MediumMaxSpawnSeconds
    {
        get { return configurationData.MediumMaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// in a hard game
    /// </summary>
    public static float HardMaxSpawnSeconds
    {
        get { return configurationData.HardMaxSpawnSeconds; }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
