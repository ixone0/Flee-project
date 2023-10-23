using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afercutscene : MonoBehaviour
{
   public GameObject UIPLAYER;
   public GameObject PLAYER;
   public Timer Timer;
   public GameObject GAMECONTROLLER;
   public GameObject UIANYKEY;
   public GameObject Wormm;

    void Update()
    {
        if(Input.anyKeyDown)
        {
            UIPLAYER.SetActive(true);
            Timer.BoolTime = true;
            UIANYKEY.SetActive(false);
            Wormm.GetComponent<Worm>().enabled = true;
            enabled = false;
        }

    }
}
