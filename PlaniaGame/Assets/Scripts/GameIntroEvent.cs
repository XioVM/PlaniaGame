using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameIntroEvent : MonoBehaviour
{
    
    private void ChangeScenePlaniaGame()
    {
        SceneManager.LoadScene("NivelUnoPlania");

    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("NivelUnoPlania");

        }
    }
}
