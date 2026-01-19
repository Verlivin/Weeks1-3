using UnityEngine;
using UnityEngine.InputSystem;

public class Sq : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite barrel0;
    public Sprite barrel1;
    public Sprite barrel2;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
        //    PickARandomColour();
        PickARandomSprite();
              
        }

         Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            spriteRenderer.color = col; 
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    
    }
    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
    void PickARandomSprite()
    {
        randomNumber = Random.Range(0, 3);
        if (randomNumber == 0)
        {
            spriteRenderer.sprite = barrel0;
        }
        else if (randomNumber == 1)
        {
            spriteRenderer.sprite = barrel1;
        }
        else if(randomNumber == 2)
        {
            spriteRenderer.sprite = barrel2;
        }
    }
}
