using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Mapbox.Unity.Map;
using UnityEngine;

public class locationSelect : MonoBehaviour
{
    public Dropdown dropdown; 
    public GameObject map, ocean; 
    private AbstractMap mapOptions;
    private Mapbox.Utils.Vector2d miami, newYork, chicago, paris; 
    // Start is called before the first frame update
    void Start()
    {
        mapOptions = map.GetComponent<AbstractMap>(); 
        map.transform.position = new Vector3(0,0,0);
        miami = new Mapbox.Utils.Vector2d(25.761681f, -80.191788f);
        newYork = new Mapbox.Utils.Vector2d(40.785091f, -73.968285f);
        chicago = new Mapbox.Utils.Vector2d(41.881832f, -87.623177f);
        paris = new Mapbox.Utils.Vector2d(48.864716f, 2.349014f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dropDownLocationChanged(){
        switch (dropdown.value){
            case 0: 
                mapOptions.SetCenterLatitudeLongitude(miami);
		        mapOptions.UpdateMap(); 
                break;
            case 1:
                mapOptions.SetCenterLatitudeLongitude(newYork);
		        mapOptions.UpdateMap();     
                break;
            case 2:
                mapOptions.SetCenterLatitudeLongitude(chicago);
		        mapOptions.UpdateMap(); 
                break;
            case 3:
                mapOptions.SetCenterLatitudeLongitude(paris);
		        mapOptions.UpdateMap(); 
                break; 
        }
        ocean.GetComponent<water_updates>().setHeight(0); 
		map.transform.position = new Vector3(0,0,0);
    }
}
