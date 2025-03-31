using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Start is called befor
    // e the first frame update

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Invoke("FirstLevelLoad", 2f);
    }

    // Update is called once per frame
    void FirstLevelLoad()
    {
        SceneManager.LoadScene(1);
    }
}
