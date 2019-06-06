using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{	
	[SerializeField]
    private LevelData levelData;
	
	public static int PlayerScore;
	
	public GameObject PlayerScoreUI;
	
	
	void Start(){
		
		PlayerScoreUI.GetComponent<Text>().text = "BallHit : " + PlayerScore.ToString();
		
	}
	

	public void ClickedOn(string planet){
		
		if (planet=="Earth"){
			
			levelData.GravitySet (9.8F);
			levelData.ColorSet (Color.blue);
			
		}
		else if(planet=="Moon"){
			
			levelData.GravitySet (1.6F);
			levelData.ColorSet (Color.gray);
			
		}
		else if(planet=="Jupiter"){
			
			levelData.GravitySet (24.5F);
			levelData.ColorSet (Color.yellow);
			
		}
				
		SceneManager.LoadScene("GameplayScene");
				
	}

}
