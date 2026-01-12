using UnityEngine;

public class Timer : MonoBehaviour
{
    public float t = 0;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        float y = curve.Evaluate(t);
        Vector2 newPosition = transform.position;
        newPosition.y = y;
        transform.position = newPosition;
    }
}
