using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen1 : MonoBehaviour
{
    
    public GameObject StartScreen;
    public GameObject GameIntroExplication;
    
    // Start is called before the first frame update
    void Start()
    {
        GameIntroExplication.SetActive(false);
    }

    public void GameIntroExplicationPanel()
    {
        GameIntroExplication.SetActive(true);
        StartScreen.SetActive(false);
        
        
    }

    public void ChangeSceneAnimaticIntro()
    {
        
        SceneManager.LoadScene("GameIntro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
