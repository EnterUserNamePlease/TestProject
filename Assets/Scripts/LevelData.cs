using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New LevelData", menuName = "Level Data", order = 51)]
public class LevelData : ScriptableObject
{
	
    private float gravity;
    private Color backgroundColor;
	
	
	public float Gravity
    {
        get
        {
            return gravity;
        }
    }
	
	public Color BackgroundColor
    {
        get
        {
            return backgroundColor;
        }
    }
	
	public void GravitySet(float setGravity)
    {
       gravity = setGravity;
    }
	
	public void ColorSet(Color setColor)
    {
       backgroundColor = setColor;
    }
	

}
