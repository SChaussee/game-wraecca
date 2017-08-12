using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldTime : MonoBehaviour {

	public GameObject gameController;
	public GameStart gameStart;
	
	public GameObject eventController;
	public EventControllerScript eventControllerScript;
	
	public Text timeAtSeaText;
	public Text dateTimeText;

	
	public int gameSpeed;
	public float eventTime;

	private int totalDays;
	private int totalHours;
	private int totalMinutes;
	private float totalSeconds;
	
	private int dailyHours;
	private int dailyMinutes;
	private float dailySeconds;	
	
	public string[] months;
	public string currentMonth;
	private int currentMonthIndex;
	
	public string[] days;
	public string currentDay;
	private int currentDayIndex;
	
	private int monthDay;
	
	public string[] times;
	public string currentTime;
	

	
	void Awake ()
	{
		totalDays = 0;
		totalHours = 0;
		totalMinutes = 0;
		totalSeconds = 0;
		
		dailyHours = 0;
		dailyMinutes = 0;
		dailySeconds = 0;

		currentMonthIndex = 9;
		currentDayIndex = 2;
		
		monthDay = 17;
		
		gameSpeed = 45;
	}
	

	void Start () 
	{
		gameStart = gameController.GetComponent<GameStart>();
		eventControllerScript = eventController.GetComponent<EventControllerScript>();
		EventTime();
		
		currentMonth = months[currentMonthIndex];
		currentDay = days[currentDayIndex];
	}
	
	
	void Update () 
	{
		if(gameStart.startGame == true)
		{
			totalSeconds += Time.deltaTime * gameSpeed;
			dailySeconds += Time.deltaTime * gameSpeed;

			if(totalSeconds >= 60)
			{
				totalMinutes += 1;
				totalSeconds = 0;
			}
			if(totalMinutes >= 60)
			{
				totalHours += 1;
				totalMinutes = 0;
			}
			if(totalHours >= 24)
			{
				totalDays += 1;
				totalHours = 0;
			}
			
			if (monthDay >= 30)
			{
				monthDay = 0;
				currentMonthIndex += 1;
			}
			
			if(dailySeconds >= 60)
			{
				dailyMinutes += 1;
				dailySeconds = 0;
			}
			
			if(dailyMinutes >= 60)
			{
				dailyHours += 1;
				dailyMinutes = 0;
			}
			
			if(dailyHours >= 24)
			{
				currentDayIndex += 1;
				currentDay = days[currentDayIndex];
				Debug.Log(currentDayIndex + " - " + currentDay);
				monthDay += 1;
				dailyHours = 0;
			}
			
			if(dailyHours >= 0 && dailyHours < 5)
			{
				currentTime = times[0];
			}
			if(dailyHours >= 5 && dailyHours < 8)
			{
				currentTime = times[1];
			}
			if(dailyHours >= 10 && dailyHours < 15)
			{
				currentTime = times[2];
			}
			if(dailyHours >= 17 && dailyHours < 20)
			{
				currentTime = times[3];
			}
			if(dailyHours >= 20)
			{
				currentTime = times[0];
			}
			
			timeAtSeaText.text = "Æt sæ: " + "\n" + totalDays + " dægum, " + "\n" + totalHours + " hwila, " + "\n" + totalMinutes + " mynne ";
			dateTimeText.text = currentTime + "; " + currentDay + ", \n" + " " + monthDay + " " + currentMonth + " " + " 1066";
			
			if(totalMinutes == eventTime)
			{
				eventControllerScript.SendMessage("EventRoller");
			}
		}
	}
	
	public void EventTime()
	{
		eventTime = Random.Range(10,60);
	}
}
