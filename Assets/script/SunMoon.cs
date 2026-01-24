using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEditor.PlayerSettings;

public class SunMoon : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
		Vector3 newPosition = transform.position;
		newPosition.y = mousePos.y;
		if (newPosition.y < 4 && newPosition.y> -7.5)
		{
			transform.position = newPosition;
		}

	}
}
