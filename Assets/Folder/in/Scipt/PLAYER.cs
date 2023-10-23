using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour 
{
    public float health = 100f;
    public float healthMax = 100f;
    public float damage = 40;
    public float time = 10;
    public Slider healthSlider;
    public GameObject MainCamera;
    public GameObject Gamecon;

    public GameObject anibear;
    public GameObject bear;
    public GameObject CamBear;
    public AudioSource SoundjBear;

    public GameObject aniduck;
    public GameObject duck;
    public GameObject CamDuck;
    public AudioSource SoundjDuck;
    //public AudioSource SoundWalkDuck;

    public GameObject anishadow;
    public GameObject shadow;
    public GameObject CamShadow;
    public AudioSource SoundjShadow;

    public GameObject aniWorm;
    public GameObject CamWorm;
    public AudioSource SoundjMonMain;

    public Rigidbody BookPrefab;
    public Transform pointt;
    public float speed;

    public GameObject UIdead;
    public GameObject UIplayer;
    public GameObject UIEndGame;



    
    void Start () {
        health = healthMax;
        healthSlider.GetComponent<Slider>().maxValue = healthMax;
        healthSlider.GetComponent<Slider>().value = health;
    }

    void Update () {

     
        healthSlider.GetComponent<Slider>().value = health;
        
        if(health <= 0)
        {
            health = 0;
        }


        if(health >= healthMax)
        {
            health = 100;
        }
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "monMain") //mon ที่วิ่งตามหลัง
        {      
            Destroy(col.gameObject);
            StartCoroutine(JumpScareMonMain());
        }

        if(col.gameObject.tag == "monShadow") //mon เงา
        {
           Destroy(col.gameObject);
           StartCoroutine(JumpScareMonShadow());
        }

        if(col.gameObject.tag == "monRun")
        {
            Destroy(col.gameObject);
            StartCoroutine(JumpScareMonRun());
        }


        if(col.gameObject.transform.tag == "monBear") //mon หมีน่ารักๆ
        {
            Destroy(col.gameObject);
            PlayerTakeDamage(60);
            StartCoroutine(JumpScareBear());

        }

        if(col.gameObject.tag == "shelf") //หนังสือ
        {
            var book = Instantiate(BookPrefab,pointt.position,pointt.rotation);
                book.AddForce(transform.forward*speed,ForceMode.Impulse);
        }

        if(col.gameObject.tag == "Finish")
        {
            FiNish();
        }

        if(col.gameObject.tag == "HAND")
        {
            PlayerTakeDamage(10);
        }
    }


    IEnumerator JumpScareBear()
    {
        anibear.GetComponent<Animator>().enabled = true;
        bear.GetComponent<Animator>().enabled = true;
        MainCamera.SetActive(false);
        CamBear.SetActive(true);
        SoundjBear.Play();
        yield return new WaitForSeconds(1);
        PlayerTakeDamage(15);
        anibear.GetComponent<Animator>().enabled = false;
        bear.GetComponent<Animator>().enabled = false;
        CamBear.SetActive(false);
        MainCamera.SetActive(true);
        if(health <= 0)
            {
                DEAD();
            }
        
    }

    IEnumerator JumpScareMonMain()
    {
        PlayerTakeDamage(100);
        aniWorm.GetComponent<Animator>().enabled = true;
        CamWorm.SetActive(true);
        SoundjMonMain.Play();
        yield return new WaitForSeconds(2);
        aniWorm.GetComponent<Animator>().enabled = false;
        CamWorm.SetActive(false);
        if(health <= 0)
            {
                DEAD();
            }
        
    }

    IEnumerator JumpScareMonShadow()
    {
        
        PlayerTakeDamage(20);
        anishadow.GetComponent<Animator>().enabled = true;
        shadow.GetComponent<Animator>().enabled = true;
        MainCamera.SetActive(false);
        CamShadow.SetActive(true);
        SoundjShadow.Play();
        yield return new WaitForSeconds(1);
        anishadow.GetComponent<Animator>().enabled = false;
        shadow.GetComponent<Animator>().enabled = false;
        MainCamera.SetActive(true);
        CamShadow.SetActive(false);
        if(health <= 0)
            {
                DEAD();
            }
    }
  
    IEnumerator JumpScareMonRun()
    {
        PlayerTakeDamage(15);
        SoundjDuck.Play();
        aniduck.GetComponent<Animator>().enabled = true;
        duck.GetComponent<Animator>().enabled = true;
        MainCamera.SetActive(false);
        CamDuck.SetActive(true);
        yield return new WaitForSeconds(1);
        aniduck.GetComponent<Animator>().enabled = false;
        duck.GetComponent<Animator>().enabled = false;
        MainCamera.SetActive(true);
        CamDuck.SetActive(false);
        if(health <= 0)
            {
                DEAD();
            }

    }


    void PlayerTakeDamage(int damage)
    {
        health -= damage;
    }

    public void DEAD()
    {
        Gamecon.GetComponent<Timer>().BoolTime = false;
        UIplayer.SetActive(false);
        UIdead.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
    }

    public void FiNish()
    {
        Gamecon.GetComponent<Timer>().BoolTime = false;
        UIplayer.SetActive(false);
        UIEndGame.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

/*
    IEnumerator StartHealth(float value, float time)
    {
        yield return new WaitForSeconds(time);
        if (health > 0 && health<healthMax)
        {
           health += Time.deltaTime*value;
        }
    }
*/



/*
    public IEnumerator JumpScareBear()
   {
    GameObject bear1 = GameObject.Find("anibear");
    GameObject bear2 = GameObject.Find("bear");
    GameObject mainCamera = GameObject.Find("Main Camera");
    GameObject camBear = GameObject.Find("CamBear");
    Debug.Log("111111111111111111111");

    if (bear1 != null && bear2 != null && mainCamera != null && camBear != null)
    {
        PlayerTakeDamage(60);
        Animator bear1Animator = bear1.GetComponent<Animator>();
        Animator bear2Animator = bear2.GetComponent<Animator>();
        Camera mainCameraComponent = mainCamera.GetComponent<Camera>();
        Camera camBearComponent = camBear.GetComponent<Camera>();
        Debug.Log("_______________");

        if (bear1Animator != null && bear2Animator != null && mainCameraComponent != null && camBearComponent != null)
        {
            bear1Animator.enabled = true;
            bear2Animator.enabled = true;
            mainCameraComponent.enabled = false;
            camBearComponent.enabled = true;
            yield return new WaitForSeconds(2);
            bear1Animator.enabled = false;
            bear2Animator.enabled = false;
            mainCameraComponent.enabled = true;
            camBearComponent.enabled = false;
            Debug.Log("XXXX");
        }
    }
    else
    {
        Debug.Log("objects not found!");
    }
  }
  */

    
    

    /*

    void OnTriggerExit(Collider other)
    {
        if(health <= 0)
        {
            if(other.gameObject.tag == "monBear")
            {
                StartCoroutine(JumpScareBear());
            }


            SceneManager.LoadScene("dead main");
        }
    }

    */
    


   
    
    

        

        
    
        /*
        PlayerTakeDamage(60);
        GameObject.Find("anibear").GetComponent<Animator>().enabled = true;
        GameObject.Find("bear").GetComponent<Animator>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = false;
        GameObject.Find("CamBear").GetComponent<Camera>().enabled = true;
        yield return new WaitForSeconds(2);
        GameObject.Find("anibear").GetComponent<Animator>().enabled = false;
        GameObject.Find("bear").GetComponent<Animator>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
        GameObject.Find("CamBear").GetComponent<Camera>().enabled = true;
        */




    

//ghghhghhgh


















    /*
    public float health = 100f;
    public float healthMax = 100f;
    public Slider healthSlider;
    public GameObject finishPanel;


    void Start () {
        health = healthMax;
        healthSlider.GetComponent<Slider>().maxValue = healthMax;
        healthSlider.GetComponent<Slider>().value = health;
    }
	
	void Update () {
        healthSlider.GetComponent<Slider>().value = health;
    }
    public IEnumerator RemoveHealth(float value, float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (health > 0)
            {
                health -= value;
            }
        }
    }
    public IEnumerator StartHealth(float value, float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (health > 0 && health<healthMax)
            {
                health += value;
            }
            else
            {
                health = healthMax;
            }
        }
    }
    */
}
