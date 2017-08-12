using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoemReader : MonoBehaviour 
{
	
	public bool poemStart;

	public GameObject gameStartMenu;
	
	public Text oldEnglishLineOne;
	public Text modernEnglishLineOne;
	public Text oldEnglishLineTwo;
	public Text modernEnglishLineTwo;

	public GameObject poemMenu;
	private AudioSource poemSound;
	
	void Awake () 
	{
		poemSound = poemMenu.GetComponent<AudioSource>();
		
		poemStart = false;
	}
	
	
	void Update () 
	{

	}
	
	public void PoemStart()
	{
		poemStart = true;
		gameStartMenu.SetActive(false);
		poemMenu.SetActive(true);
		StartCoroutine(ReadPoem());
	}
	
	IEnumerator ReadPoem()
	{
		Debug.Log("Lines 1 and 2");
		oldEnglishLineOne.text = "Mæg ic be mē sylfum; sōðgied wrecan";
		modernEnglishLineOne.text = "I sing my own true story, tell my travels";
		oldEnglishLineTwo.text = "sīÞas secgan, hū ic geswincdagum";
		modernEnglishLineTwo.text = "how I have often suffered times of hardship";
				
		yield return new WaitForSeconds(2f);
		
		Debug.Log("Playing sound.");
		poemSound.enabled = true;
		
		yield return new WaitForSeconds(7f);
		
		Debug.Log("Lines 3 and 4");
		oldEnglishLineOne.text = "earfoðhwile oft þrowade,";
		modernEnglishLineOne.text = "in days of toil, and have experienced";
		oldEnglishLineTwo.text = "bitre breostceare gebiden hæbbe,";
		modernEnglishLineTwo.text = "bitter anxiety, my troubled home";
		
		yield return new WaitForSeconds(7f);
		
		Debug.Log("Lines 5 and 6");
		this.oldEnglishLineOne.text = "gecunnad in cēole cearselda fela,";
		modernEnglishLineOne.text = "on many a ship has been the heaving waves";
		oldEnglishLineTwo.text = "atol ȳþa gewealc, þǣr mec oft bigeat";
		modernEnglishLineTwo.text = "where grim night-watch has often been my lot";
		
		yield return new WaitForSeconds(7f);
		
		Debug.Log("Lines 7 and 8");
		oldEnglishLineOne.text = "nearo nihtwaco æt nacan stefnan,";
		modernEnglishLineOne.text = "at the ships prow";
		oldEnglishLineTwo.text = "þonne he be clifum cnossað. Calde geþrungen";
		modernEnglishLineTwo.text = "as it beat past the cliffs. Oppressed by cold";
				
		yield return new WaitForSeconds(7f);
		
		Debug.Log("Lines 9 and 10");
		oldEnglishLineOne.text = "wǣron mine fet, forste gebunden";
		modernEnglishLineOne.text = "my feet were bound by frost";
		oldEnglishLineTwo.text = "caldum clommum, þǣr þā ceare seofedun";
		modernEnglishLineTwo.text = "in icy bonds, while worries simmered hot";
	}
}
