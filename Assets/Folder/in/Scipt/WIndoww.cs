using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIndoww : MonoBehaviour
{
    /*void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag  == "")
        {
            StartCoroutine(WINDOW());
        }
    }
    */

    public GameObject window2;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Window")
        {
            StartCoroutine(WINDOW());
        }
    }

    IEnumerator WINDOW()
    {
        window2.SetActive(false);
        yield return null;
    }
}
