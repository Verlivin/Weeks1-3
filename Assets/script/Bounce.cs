using UnityEngine;

public class Bounce : MonoBehaviour
{
    float speedX = 0.01f;
    float speedY = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speedX;
        newPosition.y += speedY;
        transform.position = newPosition;

        //make screen friendly?
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }
    
            if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY= speedY * -1;
        }
    }
}
