using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollect : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coconut"))
        {
            Debug.Log("Coconut collected!");
            GameManager.Instance.AddPoint(); // points go up when coconut collected
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("Hit by bomb!");
            SceneManager.LoadScene("End"); //game ends when player collects a bomb
        }


    }
}