using UnityEngine;

public class Colors : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 1)
        {
            PickARandomColour();
            t = 0;
        }
    }
    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
