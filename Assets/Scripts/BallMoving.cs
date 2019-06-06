using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMoving : MonoBehaviour
{
	
	[SerializeField]
    private LevelData levelData;

	public GameObject ball;
	public float forceStrength;
	private Vector3 startPosition;
    
	
	void Start() {
		
		startPosition = ball.transform.position;
		
		Physics2D.gravity = new Vector2(0, -levelData.Gravity);
		
		gameObject.GetComponent<SpriteRenderer>().color = levelData.BackgroundColor;
		
	}
	
	
    void Update() {
		
		#if UNITY_EDITOR || UNITY_STANDALONE_WIN
		
			if (Input.GetMouseButton(0)){
			
				Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
						
				ball.GetComponent<Rigidbody2D>().AddForce((worldPosition-ball.transform.position) * forceStrength);
			
			}

		#else
		
			if (Input.touchCount > 0){
			
				Touch touch = Input.GetTouch(0);
			
				Vector3 worldPosition = Camera.main.ScreenToWorldPoint(touch.position);
							
				ball.GetComponent<Rigidbody2D>().AddForce((worldPosition-ball.transform.position) * forceStrength);
			}

		#endif
		
		
		
        
		// ball has fallen
		
		if (ball.transform.position.y<-10F){
			
			ball.transform.position = startPosition;
			
			ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0F,0F);
			
			ball.GetComponent<Rigidbody2D>().angularVelocity = 0F;
			
		}
		
		
		// esc to main menu
		
		 if (Input.GetKeyDown(KeyCode.Escape)) 
			SceneManager.LoadScene("Menu");
		
		
    }

	

}
