using UnityEngine;
using System.Collections;

public class EventDispatcherTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		EventDispatcher.Instance.AddEventListener("SayHello", Hello);
		EventDispatcher.Instance.DispatchEvent("SayHello", this);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Hello (object target)
	{
		Debug.Log("Hello from " + target);
	}
}
