using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherController : MonoBehaviour {

	public GameObject timeController;
	private WorldTime worldTime;
	
	[SerializeField] private Material midnightSky;
	[SerializeField] private Material morningSky;
	[SerializeField] private Material middaySky;
	[SerializeField] private Material eveningSky;
	[SerializeField] private Light sun;
	
	private Color midnight;
	private Color morning; 
	private Color midday;
	private Color evening;
	
	
	void Start () 
	{
		worldTime = timeController.GetComponent<WorldTime>();
		midnight = new Color(.170f, .190f, .35f);
		morning = new Color(.35f, .25f, .170f);
		midday = new Color( .7f, .7f, .7f);
		evening = new Color( .35f, .25f, .170f);
	}
	
	
	void Update () 
	{
		if (worldTime.currentTime == worldTime.times[0])
		{
			SkyBoxUpdate();
		}
		if (worldTime.currentTime == worldTime.times[1])
		{
			SkyBoxUpdate();
		}
		if (worldTime.currentTime == worldTime.times[2])
		{
			SkyBoxUpdate();
		}
		if (worldTime.currentTime == worldTime.times[3])
		{
			SkyBoxUpdate();
		}
	}
	
	void SkyBoxUpdate ()
	{
		if (worldTime.currentTime == worldTime.times[0])
		{
			RenderSettings.skybox = midnightSky;
			DynamicGI.UpdateEnvironment();
			sun.color = midnight;
		}
		if (worldTime.currentTime == worldTime.times[1])
		{
			RenderSettings.skybox = morningSky;
			DynamicGI.UpdateEnvironment();
			sun.color = morning;
		}
		if (worldTime.currentTime == worldTime.times[2])
		{
			RenderSettings.skybox = middaySky;
			DynamicGI.UpdateEnvironment();
			sun.color = midday;
		}
		if (worldTime.currentTime == worldTime.times[3])
		{
			RenderSettings.skybox = eveningSky;
			DynamicGI.UpdateEnvironment();
			sun.color = evening;
		}
	}
}
