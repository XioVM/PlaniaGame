using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen1 : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = .5f;

    public GameObject StartScreen;
    public GameObject GameIntroExplication;
    public GameObject LevelLoader;

    // Start is called before the first frame update
    void Start()
    {
        LevelLoader.SetActive(true);
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

    IEnumerator LoadTransition()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
    }

}