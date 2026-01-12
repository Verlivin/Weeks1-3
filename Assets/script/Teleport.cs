using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        t += Time.deltaTime;
        if (t > 1)
        {
            newPosition.x = Random.Range(-8, 8);
            newPosition.y = Random.Range(-5, 5);
            transform.position = newPosition;
            t = 0;
        }

    }
}
