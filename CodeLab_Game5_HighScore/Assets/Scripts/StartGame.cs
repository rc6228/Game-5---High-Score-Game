using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void StartPressed()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("CLICKED BUTTON");
    }

}
