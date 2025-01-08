using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip ShotSound;
    [SerializeField] private AudioSource BulletAudio;
    [SerializeField] private AudioClip BgMusic;
    [SerializeField] private AudioSource BgAudio;


    // Start is called before the first frame update
    void Start()
    {
        BulletAudio = GetComponent<AudioSource>();
        BgAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight.isEnemyShot){
            BulletAudio.PlayOneShot(ShotSound);
            MoveRight.isEnemyShot = false;
        }
    }
}
