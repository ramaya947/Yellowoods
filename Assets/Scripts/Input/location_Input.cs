using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mapbox.Unity.Map;

public class location_Input : MonoBehaviour
{

	private GameObject citySimMap;
	private AbstractMap mapOptions;
	public GameObject lat, lon, ocean;
	public Slider slider; 
	private double latt, lonn; 
	private bool change; 
	//private Component[] components; 

	void Awake(){
        citySimMap = GameObject.Find("CitySimulatorMap");
		latt = 0;
		lonn = 0;
		change = false; 
		//components = citySimMap.GetComponents(typeof(Component));
	}

    // Start is called before the first frame update
    void Start()
    {
		mapOptions = citySimMap.GetComponent<AbstractMap>();
		citySimMap.transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void search(){
		//Read input of coordinates and update the map with the new coordinates.  
		latt = double.Parse(lat.GetComponent<Text>().text); 
		lonn = double.Parse(lon.GetComponent<Text>().text);
		mapOptions.SetCenterLatitudeLongitude(new Mapbox.Utils.Vector2d(latt,lonn));
		mapOptions.UpdateMap(); 
		//Reset dependent fields
		ocean.GetComponent<water_updates>().setHeight(0); 
		slider.value = 0;  
		citySimMap.transform.position = new Vector3(0,0,0);
		//Log change to console
		print("Setting the coordinates to " + latt + ", " + lonn);
	}
}
