using UnityEngine;
using UnityEngine.InputSystem;

public class P1 : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        
        if (Keyboard.current != null && Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }


    }
}
