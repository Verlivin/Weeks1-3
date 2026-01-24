using UnityEngine;

public class ShipLerp : MonoBehaviour
{
	public Transform start;
	public Transform end;
	public float t = 0;
	public float back = 0;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		t += Time.deltaTime;
		if (t > 1.5)
		{
			t = 0;
			if (back == 0) //I use float to create a boolean because I don't know if I could use boolean, works anyway
			{
				back = 1;
			}
			else if(back == 1)
			{
				back = 0;
			}
		}
		if (back==0)
		{
			transform.position = Vector2.Lerp(start.position, end.position, t);
		}
		else if(back==1)
		{
			transform.position = Vector2.Lerp(end.position, start.position, t);
		}
	}
}
