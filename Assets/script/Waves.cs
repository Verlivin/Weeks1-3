using UnityEngine;

public class Waves : MonoBehaviour
{
	public float t = 0;
	public float pos = 0;
	public float layer = 0;
	public AnimationCurve curve;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		t += Time.deltaTime;
		if (t > 2)
		{
			t = 0;
		}
		float y = curve.Evaluate(t);
		Vector3 newPosition = transform.position;
		newPosition.y = y + pos ;
		newPosition.z = layer;
		transform.position = newPosition;
	}
}