using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coconut"))
        {
            Debug.Log("Coconut collected!");
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("Hit by bomb!");
            Destroy(collision.gameObject);
        }
    }
}
