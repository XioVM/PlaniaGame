using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class AudioItemClass
{
    public string key;
    public AudioClip audio;
}

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;

    public static SoundManager instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundManager>();
            }

            return _instance;
        }
    }

    public AudioSource bgmAudioSource;
    [Header("Lista de música de fondo")]
    public List<AudioItemClass> bgmAudioItems;


   // public void PlayBGMAudioClip(string _key)
   // {
       // AudioClip searchedAudio = SearchBGMAudioClip(_key);
       // if (searchedAudio != null)
       // {
         //   bgmAudioSource.clip = searchedAudio;
           // bgmAudioSource.Play();
        //}
        //else
        //{
          //  Debug.LogWarning("Audio Clip no encontrado");
        //}
    //}












    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
