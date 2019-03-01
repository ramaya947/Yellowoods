using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class water_updates : MonoBehaviour
{

    private GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("Slider");
        gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateHeight(){
        if (slider.GetComponent<Slider>().value <= 1){
            Vector3 position = new Vector3(0, 0, 0);
            gameObject.transform.position = position;
            gameObject.SetActive(false);  
        } else {
            gameObject.SetActive(true); 
            Vector3 position = new Vector3(0, (slider.GetComponent<Slider>().value / 49.0f) * 2.0f, 0);
            gameObject.transform.position = position; 
        }
        
    }

    public void setHeight(int height){
        Vector3 position = new Vector3(0, height, 0);
        gameObject.transform.position = position;
    }

}
