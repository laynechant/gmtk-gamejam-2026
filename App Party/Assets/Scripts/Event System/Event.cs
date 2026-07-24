using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu]
public class Event : ScriptableObject
{
    private readonly List<EventListener> _eventListeners = new List<EventListener>();

    public void Raise(Component sender, object data)
    {

        for (int i = _eventListeners.Count - 1; i >= 0; i--)
        {
            _eventListeners[i].OnEventRaised(sender, data);
        }
    }

    public void RegisterListener(EventListener listener)
    {
        if (!_eventListeners.Contains(listener))
        {
            _eventListeners.Add(listener);
        }
    }

    public void UnregisterListener(EventListener listener)
    {
        if (_eventListeners.Contains(listener))
        {
            _eventListeners.Remove(listener);
        }
    }

}
