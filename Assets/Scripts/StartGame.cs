using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{	
	[SerializeField]
	private LevelData levelDataInitialization;
	
    public static LevelData levelData;
	
	public static int PlayerScore;
	
	public GameObject PlayerScoreUI;
	
	
	void Start(){
		
		levelData = levelDataInitialization;
				
		PlayerScoreUI.GetComponent<Text>().text = "BallHit : " + PlayerScore.ToString(); // show text with player score in main menu
		
	}
	

	public void ClickedOn(GameObject button){
				
		ISetLevelParams levelParams = button.GetComponent<ISetLevelParams>(); // use C# interface for clickable objects; (task)
		
		if(levelParams!=null){
			
			levelParams.SetLevelSettings();
			
		}
				
		SceneManager.LoadScene("GameplayScene"); // load gameplay scene
				
	}

}
