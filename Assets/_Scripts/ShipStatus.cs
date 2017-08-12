using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipStatus : MonoBehaviour {

	public int shipSpeed;
	public float shipSpeedModifier;

	public Text rationsText;
	public int rationsAmount;
	public float rationsModifier;

	public Text crewText;
	public int crewAmount;
	public string[] crewNames;
	public int crewMood;
	
	public Text toolsText;
	public int toolsAmount;
	


	void Start () 
	{
			
		rationsAmount = 200;
		rationsText.text = rationsAmount + " rations";
		
		crewAmount = 40;
		crewText.text = crewAmount + " crew";
		crewMood = 4;
		
		toolsAmount = 50;
		toolsText.text = toolsAmount + " tools";
		
		 crewNames = new string[] {"Ælfgar", "Ælfgifu", "Beorhtric", "Cuthberht", "Cyneburga", "Cynefrith", "Deorwine", "Eadgar", "Eadgyth", "FriðswiÞ", "Glædwine", "Godgifu", "Harold", "Hild", "Leofric", "Leofflæd", "Mildburg", "Mildryð", "Osbeorn", "Osgar", "Oswald", "Sigeberht", "Wealhmær", "Wilfred", "Winfrith", "Wulfric", "Hrothgar", "Tostig", "Godwine", "Godric", "Eoforhild", "Eadric", "Hunwald", "Baldric", "Winstan", "Leofnoth", "Inga", "Wærhild", "Eowyn", "Eomer"};
	}
	
	void Awake ()
	{
	
	}

	void Update () 
	{
		
	}
	

}
