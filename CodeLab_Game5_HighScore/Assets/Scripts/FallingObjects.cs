using System.Collections;
using System.Collections.Generic; 
using UnityEngine;


//this video is helping me with the random spawning! https://www.youtube.com/watch?v=j6p5Nh7JvmY

public class FallingObjects : MonoBehaviour
{

    [SerializeField] private GameObject[] coconutPrefab; 
    [SerializeField] private float secondSpawn = 0.5f;
    [SerializeField] public float minX;
    [SerializeField] public float maxX;
  

    public void Start()
    {
        StartCoroutine(CoconutSpawn());
    }
    
    
   public IEnumerator CoconutSpawn() //first time using enumerators!
    {
        while (true)
        {
            var wanted = Random.Range(minX, maxX); 
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(coconutPrefab[Random.Range(0, coconutPrefab.Length)], position,
                Quaternion.identity); //callin on them coconuts. Maybe I should be concerned that the coder in my video is calling them "friutPrefab." ..."friut." ....
            yield return new WaitForSeconds(secondSpawn); //do not spawn for .5f
            Destroy(gameObject, 1f);

        }
    }
}


//things to do: 
// destroy on collision with player
//destroy on collision with ground