using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CustomEvent : UnityEvent<Component, object> { }
public class EventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public Event Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public CustomEvent response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(Component sender, object data)
    {
        response.Invoke(sender, data);
    }

}
