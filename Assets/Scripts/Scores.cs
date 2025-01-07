using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class GameManager : MonoBehaviour
{
    public AudioClip GetScore;
    public AudioSource AudioSrc;
    public Text ScoreNum;
    public static int scores; // 全域變數

    // Start is called before the first frame update
    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
        scores = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreNum.text = scores.ToString();
        if(DetectCollisions.IsAnimalShot){
            DetectCollisions.IsAnimalShot = false;
            AudioSrc.PlayOneShot(GetScore);
        }
    }
}
