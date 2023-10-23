using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOADINGSCENE : MonoBehaviour
{
    public GameObject UILOAD;

    void Start()
    {
        StartCoroutine(LOADSCENENE());
    }

    IEnumerator LOADSCENENE()
    {
        yield return new WaitForSeconds(2);
        UILOAD.SetActive(false);
    }
}
