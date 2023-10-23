using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonMon : MonoBehaviour {

    public float damage = 10;
    public float damageTime = 1;
    public GameObject player;
    public bool enableDisappear = false;
    public float timeHealth = 3.0f;
    IEnumerator damagePlayer = null;
    IEnumerator healthPlayer = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            enableDisappear = true;
            other.gameObject.transform.Find("Main Camera").GetComponent<GlitchEffect>().enabled = true;
            if (healthPlayer != null)
                StopCoroutine(healthPlayer);
            damagePlayer = other.GetComponent<HealthSystem>().RemoveHealth(damage,damageTime);
            GetComponent<AudioSource>().Play();
            StartCoroutine(damagePlayer);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            other.gameObject.transform.Find("Main Camera").gameObject.GetComponent<GlitchEffect>().enabled = false;
            StopCoroutine(damagePlayer);
            healthPlayer = other.gameObject.GetComponent<HealthSystem>().StartHealth(other.gameObject.GetComponent<HealthSystem>().health,timeHealth);
            StartCoroutine(healthPlayer);
        }
    }
}
