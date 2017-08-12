using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventControllerScript : MonoBehaviour {


	public GameObject timeController;
	private WorldTime worldTime;
	public GameObject gameController;
	private ShipStatus shipStatus;
	
	public GameObject player;
	
	public GameObject eventBG;
	public Text eventText;
	
	public string[] crew;
	public int randomCrewIndex;
	public string crewAffected;
	public string eventEffect;
	
	private int eventSeed;
	
	private string[] shipMalus;
	private string[] crewMalus;
	private int shipMalusIndex;
	private int crewMalusIndex;
	
	private string[] shipBonus;
	private string[] crewBonus;
	private int shipBonusIndex;
	private int crewBonusIndex;
	
	
	void Awake ()
	{
		shipMalus = new string[] {"The ship has caught fire!", "The ship is leaking!"};
		shipBonus = new string[] {"The sails are full and we are flying!", "The crew is calm and contented"};
		
		crewMalus = new string[] {"has fallen ill.", "is depressed"};
		crewBonus = new string[] {"is inspiring the others with tales.", "has sailed these waters before!"};
	}
	
	void Start () 
	{
		worldTime = timeController.GetComponent<WorldTime>();
		shipStatus = player.GetComponent<ShipStatus>();	
		crew = shipStatus.crewNames;
		RandomCrewSelector();
	}
	
	void Update () 
	{

	}
	
	public void RandomCrewSelector()
	{
		randomCrewIndex = Random.Range(0, crew.Length);
		crewAffected = crew[randomCrewIndex];
	}
	
	void EventRoller()
	{
		eventSeed = Random.Range(1,100);
		
		shipMalusIndex = Random.Range(0,shipMalus.Length);
		crewMalusIndex = Random.Range(0,crewMalus.Length);
		
		shipBonusIndex = Random.Range(0,shipBonus.Length);
		crewBonusIndex = Random.Range(0,crewBonus.Length);
		
		//EventChooser();
	}
	
	//void EventChooser()
	//{
		//if (eventSeed >= 1 && eventSeed <= 30)
		//{
			//badEvent();
		//}
		//if (eventSeed >= 31 && eventSeed <= 70)
		//{
			//neutralEvent();
		//}
		//if (eventSeed >= 71 && eventSeed <= 100)
		//{
			//goodEvent();
		//}
	//}
	
	void badEvent()
	{
		StartCoroutine(DisableEventText());
		eventBG.SetActive(true);
		eventText.text = crewAffected + " " + crewMalus[crewMalusIndex];
		
		worldTime.EventTime();
		RandomCrewSelector();		
	}
	
	void neutralEvent()
	{	
		StartCoroutine(DisableEventText());
		eventBG.SetActive(true);
		eventText.text = "wyrd bið ful aræd.";
		
		worldTime.EventTime();
		RandomCrewSelector();
	}
	
	void goodEvent()
	{
		StartCoroutine(DisableEventText());
		eventBG.SetActive(true);
		eventText.text = crewAffected + " " + crewBonus[crewBonusIndex];
		
		worldTime.EventTime();
		RandomCrewSelector();
	}	
	
	
	
	void EventDisplayer()
	{


	}
	
	IEnumerator DisableEventText()
	{
		yield return new WaitForSeconds(7.0f);
		eventBG.SetActive(false);
	}

}
