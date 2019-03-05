using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DigitalRuby.RainMaker; 

public class weatherOptions : MonoBehaviour
{
    public InputField rainText;
    public GameObject rain; 
    // Start is called before the first frame update
    void Start()
    {
        if (rainText == null || rain == null){
            print("rain/Rain-Text value is null");
        }
        gameObject.SetActive(false);
        rain.GetComponent<RainScript>().RainIntensity = 0f;  
    }

    public void updatRain(){
        int value = int.Parse(rainText.text);
        if (value == 0){
            Vector3 position = new Vector3(0, 0, 0);
            gameObject.transform.position = position;
            gameObject.SetActive(false);
            rain.GetComponent<RainScript>().RainIntensity = 0f;
        } else if (value > 10 || value < 0){
           print("You need to insert a number from 1 - 10"); 
        }  else {
            gameObject.SetActive(true); 
            Vector3 position = new Vector3(0, (value / 10.0f), 0);
            gameObject.transform.position = position;
            rain.GetComponent<RainScript>().RainIntensity = (value * 3) / 30.0f;
        }
    }
}
