using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIGHTLIGHT : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "monShadow")
        {
            Destroy(col.gameObject);
            Debug.Log("LIGHT");
        }
    }
    


    
    


}
