using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class inches_updater : MonoBehaviour
{

    private GameObject slider; 

    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("Slider");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateInches(){
        gameObject.GetComponent<Text>().text = "" + slider.GetComponent<Slider>().value;
    }

}
