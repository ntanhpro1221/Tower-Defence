using System;
using System.Collections.Generic;
using UnityEngine;

public class EventDispatcher : Singleton<EventDispatcher> {
    private Dictionary<EventId, Action<object>> listener = new();

    public void RegisterListener(EventId eventId, Action<object> callback) {
        if (!listener.ContainsKey(eventId)) {
            listener.Add(eventId, null);
        }
        listener[eventId] += callback;
    }

    public void PostEvent(EventId eventId, object param) {
        if (!listener.ContainsKey(eventId)) {
            return;
        }
        if (listener[eventId] != null) {
            listener[eventId].Invoke(param);
        } else {
            listener.Remove(eventId);
        }
    }

    public void RemoveListener(EventId eventId, Action<object> callback) {
        if (listener.ContainsKey(eventId)) {
            listener[eventId] -= callback;
        }
    }
}

public static class EventDispatcherExtentions {
    public static void RegisterListener(this MonoBehaviour listener, EventId eventId, Action<object> callback) {
        EventDispatcher.Instance.RegisterListener(eventId, callback);
    }
    
    public static void PostEvent(this MonoBehaviour sender, EventId eventId, object param) {
        EventDispatcher.Instance.PostEvent(eventId, param);
    }

    public static void RemoveListener(this MonoBehaviour listener, EventId eventId, Action<object> callback) {
        EventDispatcher.Instance.RemoveListener(eventId, callback);
    }
}
