using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float minX;
    public float maxX;



    // Update is called once per frame

    void Start()
    {
       
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePosition.x > minX && mousePosition.x < maxX)
        {
            transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z); //this is changing x position but keeping the y and z

        }
    }

}