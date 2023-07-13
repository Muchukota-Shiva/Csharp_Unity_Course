using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event manager
/// </summary>
public static class EventManager 
{
    static Fish invoker;
    static UnityAction<int> listener;

    /// <summary>
    /// Adds script as the invoker of the event
    /// </summary>
    /// <param name="script">invoker</param>
    public static void AddEventInvoker(Fish script)
    {
        invoker = script;
        if (listener != null)
        {
            invoker.AddPointsAddedEventListener(listener);
        }
    }

    /// <summary>
    /// Adds listener to the event
    /// </summary>
    /// <param name="handler">listener</param>
    public static void AddEventListener(UnityAction<int> handler)
    {
        listener = handler;
        if (invoker != null)
        {
            invoker.AddPointsAddedEventListener(listener);
        }
    }
}
