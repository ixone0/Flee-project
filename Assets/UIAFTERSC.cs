using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAFTERSC : MonoBehaviour
{
    public GameObject AfterScene;
    void Start()
    {
        StartCoroutine(TIMTIEMT());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TIMTIEMT()
    {
        yield return new WaitForSeconds(2);
        AfterScene.SetActive(true);
    }
}
