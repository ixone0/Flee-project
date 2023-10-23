using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public GameObject[] section;
    public int Zpo;
    public bool createSec = false;
    public int SecNum;

    void Update()
    {
        if(createSec == false)
        {
            createSec = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        SecNum = Random.Range(0,10);
        Zpo += 200;
        Instantiate(section[SecNum], new Vector3(0,0,Zpo), Quaternion.identity);
        yield return new WaitForSeconds(0);
        createSec = false;
        if(Zpo >= 1400)
            {
                Zpo = 1400;
                createSec = true;
            }
    }
}
