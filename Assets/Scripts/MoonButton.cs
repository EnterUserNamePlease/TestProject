using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonButton : MonoBehaviour, ISetLevelParams
{

	public void SetLevelSettings(){ // set gameplay parameters for level Moon
				
		StartGame.levelData.GravitySet (1.6F);
		StartGame.levelData.ColorSet (Color.gray);
				
	}

}
