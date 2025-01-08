using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] ShotSound;
    [SerializeField] private AudioSource[] BulletAudio;
    [SerializeField] private AudioClip BgMusic;
    [SerializeField] private AudioSource BgAudio;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < BulletAudio.Length; i++){
            BulletAudio[i] = GetComponent<AudioSource>();
        }
        BgAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight.isEnemyShot){
            int soundIndex = Random.Range(0, ShotSound.Length);
            BulletAudio[soundIndex].PlayOneShot(ShotSound[soundIndex]);
            MoveRight.isEnemyShot = false;
        }
        if(PlayerController.isGameOver){
            BgAudio.Stop(); // 停止播放背景音樂
        }
    }
}
