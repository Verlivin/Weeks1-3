using UnityEngine;

public class Trick : MonoBehaviour
{
    float speedX = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speedX;
        transform.position = newPosition;

        //make screen friendly?
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //add jump when press space

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

    }
}

