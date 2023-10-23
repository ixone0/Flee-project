using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
    private void Update() {
        {
            if(Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<ParticleSystem>().Play();
                CameraShaker.Invoke();
            }
        }
    }
}
