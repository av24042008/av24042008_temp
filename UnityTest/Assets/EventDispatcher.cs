using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventDispatcher : MonoSingleton<EventDispatcher>
{
	public delegate void Listener();
	private Dictionary<string, Listener> _listeners = new Dictionary<string, Listener> ();

	public void AddEventListener (string eventName, Listener listener)
	{
		if (_listeners.ContainsKey (eventName)) {
			_listeners[eventName] += listener;
		} else {
			_listeners.Add (eventName, listener);
		}
	}

	public void RemoveEventListener (string eventName, Listener listener)
	{
		if (_listeners.ContainsKey (eventName)) {
			_listeners[eventName] -= listener;
			if (_listeners[eventName] == null) {
				_listeners.Remove (eventName);
			}
		}
	}

	public void DispatchEvent (string eventName)
	{
		if (_listeners.ContainsKey (eventName)) {
			_listeners[eventName] ();
		}
	}
}
