using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterButton : MonoBehaviour, ISetLevelParams
{

	public void SetLevelSettings(){ // set gameplay parameters for level Jupiter
				
		StartGame.levelData.GravitySet (24.5F);
		StartGame.levelData.ColorSet (Color.yellow);
				
	}

}
