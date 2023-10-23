using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonchange : MonoBehaviour
{
    public void ToScene()
    {
        SceneManager.LoadScene("In");
    }
}