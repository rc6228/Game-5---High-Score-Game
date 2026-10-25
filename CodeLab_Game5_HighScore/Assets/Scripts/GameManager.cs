using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

//My score list doesn't work but I don't have time to fix it. For our next assignment I will go to code help desk and get my shit together, I really just can't afford to spend any more time on this. :/ 

public class GameManager : MonoBehaviour
{

	public static GameManager Instance; //Thank you Ahan
	[SerializeField] public TMP_Text scoreText;
 	[SerializeField] public TMP_Text highScore0Text;
	[SerializeField] public TMP_Text highScore1Text;
	[SerializeField] public TMP_Text highScore2Text;
	[SerializeField] public TMP_Text highScore3Text;
	[SerializeField] public TMP_Text highScore4Text;

//Ahan helped me so this might look a lot like what he did. EDIT: except it doesnt work with the way I tried to apply it...
 	static int score;
    int highScore0;
	int highScore1; 
	int highScore2;
	int highScore3;
	int highScore4;
    


 
    void Awake()
    {

		Instance = this;
		highScore0 = 0;
		highScore1 = 0;
		highScore2 = 0;
		highScore3 = 0;
		highScore4 = 0;
        highScore0Text.text = highScore0.ToString();
		highScore1Text.text = highScore1.ToString(); 
		highScore2Text.text = highScore2.ToString();	
		highScore3Text.text = highScore3.ToString();
		highScore4Text.text = highScore4.ToString();
        scoreText.text = "0";
    }


	public void AddPoint()
	{
		score++;
		scoreText.text = score.ToString(); //Add a point to the ui
	}



	void ScoreList(int score) //store the scores and order them by value
       {
    		if (score > highScore0)
    		{
        		highScore4 = highScore3;
       			highScore3 = highScore2;
        		highScore2 = highScore1;
       			highScore1 = highScore0;
       			highScore0 = score;
   		 	}
   		 	else if (score > highScore1)
   		 	{
      		  	highScore4 = highScore3;
        		highScore3 = highScore2;
        		highScore2 = highScore1;
       			highScore1 = score;
   		 	}		
    		else if (score > highScore2)
    		{
        		highScore4 = highScore3;
        		highScore3 = highScore2;
        		highScore2 = score;
    		}
    		else if (score > highScore3)
    		{
        		highScore4 = highScore3;
        		highScore3 = score;
    		}
    		else if (score > highScore4)
    		{
        		highScore4 = score;
    		}
    			highScore0Text.text = highScore0.ToString();
    			highScore1Text.text = highScore1.ToString();
   				highScore2Text.text = highScore2.ToString();
   				highScore3Text.text = highScore3.ToString();
   				highScore4Text.text = highScore4.ToString();
		}

	public void EndGame()
	{
		ScoreList(score); 
	}

}


