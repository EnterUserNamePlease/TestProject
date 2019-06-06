using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthButton : MonoBehaviour, ISetLevelParams
{

	public void SetLevelSettings(){ // set gameplay parameters for level Earth
				
		StartGame.levelData.GravitySet (9.8F);
		StartGame.levelData.ColorSet (Color.blue);
				
	}

}
