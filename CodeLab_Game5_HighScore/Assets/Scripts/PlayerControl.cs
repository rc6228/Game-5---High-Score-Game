using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float minX;
    public float maxX;

	private Animator myAnimator;
    private SpriteRenderer myRenderer;

    // Update is called once per frame

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRenderer = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePosition.x > minX && mousePosition.x < maxX)
        {
            transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z); //this is changing x position but keeping the y and z
 			 myAnimator.SetBool("Walking", true); 
        } else
        {
            {
                myAnimator.SetBool("Walking", false);
              
            }

        }
    }

}