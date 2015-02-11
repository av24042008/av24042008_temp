using UnityEngine;
using System.Collections;

public class EventDispatcherTest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		EventDispatcher.Instance.AddEventListener("SayHello", HelloWorld);
		EventDispatcher.Instance.DispatchEvent("SayHello");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void HelloWorld ()
	{
		Debug.Log("Hello World");
	}
}
