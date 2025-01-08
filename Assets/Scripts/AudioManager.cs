using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] ShotSound;
    [SerializeField] private AudioSource[] BulletAudio;
    [SerializeField] private AudioClip BgMusic;
    [SerializeField] private AudioSource BgAudio;
    [SerializeField] private int score;
    [SerializeField] private Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < BulletAudio.Length; i++){
            BulletAudio[i] = GetComponent<AudioSource>();
        }
        BgAudio = GetComponent<AudioSource>();

        score = 0;
        ScoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight.isEnemyShot){
            score += 100;
            int soundIndex = Random.Range(0, ShotSound.Length);
            BulletAudio[soundIndex].PlayOneShot(ShotSound[soundIndex]);
            MoveRight.isEnemyShot = false;
        }
        if(PlayerController.isGameOver){
            BgAudio.Stop(); // 停止播放背景音樂
        }

        ScoreText.text = score.ToString();
    }
}
