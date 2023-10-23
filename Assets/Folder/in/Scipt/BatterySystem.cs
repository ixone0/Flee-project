using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BatterySystem : MonoBehaviour {

    public float battery = 100f;
    public float batteryMax = 100f;
    public float removeBattery = 1f; 
   // public float timeRemove = 1f; 
    public GameObject flashLight;
    public Slider batterySlider;
    private bool Toggle = true;
    public GameObject point;
    public GameObject Spotlight;

	void Start () {

        battery = batteryMax;
        batterySlider.GetComponent<Slider>().maxValue = batteryMax;
        batterySlider.GetComponent<Slider>().value = battery;
        Flashlightstart();
       // StartCoroutine(RemoveBattery(removeBattery,timeRemove));

    }
	
	
	void Update () {

        batterySlider.GetComponent<Slider>().value = battery;
    
        if (Toggle)
        {
            battery -= removeBattery * Time.deltaTime;

            if ( battery <= 0)
            {
                battery = 0;
                TurnOffFlashlight();
            }

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SystemFlashlight();
        }
    }


    void SystemFlashlight()
    {
        if (Toggle)
        {
            TurnOffFlashlight();
        }
        else
        {
            TurnOnFlashlight();
        }
    }

    void Flashlightstart()
    {
        Spotlight.SetActive(false);
        flashLight.transform.Find("Spotlight").GetComponent<Light>().intensity = 300f;
        point.GetComponent<Light>().intensity = 10f;       
        Toggle = false;
    }


    void TurnOnFlashlight()
    {
        Spotlight.SetActive(true);
        Toggle = true;
    }

    void TurnOffFlashlight()
    {
        Spotlight.SetActive(false);
        Toggle = false;
    }

    /*public IEnumerator RemoveBattery(float value,float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (battery>0)
            {
                battery -= value;
            }

        
        }
    }
    */
}
