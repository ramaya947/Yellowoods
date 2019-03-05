using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class menuControls : MonoBehaviour
{
    public GameObject menu; 
    public Sprite exitImage, menuImage; 
    private bool showing;
    // Start is called before the first frame update
    void Start()
    {
        if (menu == null){
            print("Menu not available");
        }
        showing = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (showing){
            menu.SetActive(true);
            gameObject.GetComponent<Image>().sprite = exitImage;
        } else {
            menu.SetActive(false);
            gameObject.GetComponent<Image>().sprite = menuImage;
        }
    }

    public void showOrHide(){
        if (showing){
            showing = false; 
        } else {
            showing = true; 
        }
    }
}
