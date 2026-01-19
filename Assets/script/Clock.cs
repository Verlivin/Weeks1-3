using UnityEngine;

public class Clock : MonoBehaviour
{
    public float speed;
    public float side;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRoatation = transform.eulerAngles;
        newRoatation.z += side * speed * Time.deltaTime; 
        transform.eulerAngles = newRoatation;   
    }
}
