using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public AudioClip PlayingMusic; 
    AudioSource audiosound;

    public collectitem collecting;
    public Spawnpattern spawning1;
    public Spawnpattern spawning2;
    public Spawnpattern spawning3;
    public Spawnpattern spawning4;
    public movingplayer playerjump;
    public Button startbut;
    [SerializeField] GameObject startcanvas;
    [SerializeField] GameObject bar;

    // Start is called before the first frame update
    void Start()
    {
        collecting.enabled = false;
        spawning1.enabled = false;
        spawning2.enabled = false;
        spawning3.enabled = false;
        spawning4.enabled = false;
        playerjump.enabled = false;
        startbut.onClick.AddListener(onclick);
        audiosound = gameObject.GetComponent<AudioSource>();
    }
    
    private void onclick()
    {
        startcanvas.SetActive(false);
        bar.SetActive(true);
        collecting.enabled = true;
        spawning1.enabled = true;
        spawning2.enabled = true;
        spawning3.enabled = true;
        spawning4.enabled = true;
        playerjump.enabled = true;
        audiosound.clip = PlayingMusic;
        audiosound.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
