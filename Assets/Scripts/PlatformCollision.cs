using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{

 
	
	private void OnCollisionEnter2D(Collision2D collision){
		
		Color platformColor = new Color(
			Random.Range(0f, 1f), 
			Random.Range(0f, 1f), 
			Random.Range(0f, 1f)
		);
				
		gameObject.GetComponent<SpriteRenderer>().color = platformColor;
		
		StartGame.PlayerScore++;
		
	}
	


}
