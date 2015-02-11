using UnityEngine;
using System.Collections;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	private static T _instance = null;

	public static T Instance {
		get {
			_instance = _instance ?? (FindObjectOfType(typeof(T)) as T);
			_instance = _instance ?? new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
			return _instance;
		}
	}

	private void OnApplicationQuit ()
	{
		_instance = null;
	}
}
