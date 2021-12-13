using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGameButtons : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject LostPanel;
    public GameObject ExitPanel;

    public GameObject LevelLoader;
    // Start is called before the first frame update
    void Start()
    {
        LevelLoader.SetActive(true);
    }

    public void ButtonStartScene()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void ButtonRestartGame()
    {
        SceneManager.LoadScene("NivelUnoPlania");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
