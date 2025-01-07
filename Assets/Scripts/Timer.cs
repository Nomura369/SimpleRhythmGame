using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class Timer : MonoBehaviour
{
    public int seconds; // 倒計時總秒數，不須給予初始值
    public int min = 0; // 設定倒計時的分鐘
    public int sec = 10; // 設定倒計時的秒鐘
    public AudioClip CountDown;  public AudioSource CDAudioSrc;
    public AudioClip TimesUp;  public AudioSource TUAudioSrc;
    public Text TimerText;
    public GameObject GameOver;  // 設定 GAME OVER 物件（UI）
    private float counter = 0;

    void Start()
    {
        GameOver.SetActive(false);
        TimerText.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00")); // 設定計時器
        seconds = (min * 60) + sec; // 計算總秒數
    }

    void Update(){
        if(PlayerController.IsSpacePushed){
            counter += Time.deltaTime; 
            if (counter >= 1){
                counter = 0;
                Countdown();
            }
        }
    }

    void Countdown()
    {
        if(seconds != 0){
            seconds--;
            sec--; 
        }        

        if (sec < 0 && min > 0) // 如果秒數為 0 且分鐘大於 0         
        {
            min -= 1; 
            sec = 59; 
        }
        else if(sec == 3 && min == 0){
            CDAudioSrc.PlayOneShot(CountDown);
        }
        else if (sec < 0 && min == 0)   //如果秒數小於 0 且分鐘為 0（計時結束）
        {
            seconds = 0;
            sec = 0;
        }
        else if(seconds == 0 && sec == 0){ // 確定計時結束了
            TUAudioSrc.PlayOneShot(TimesUp);
            GameOver.SetActive(true); // 時間結束時，畫面出現 GAME OVER
            Time.timeScale = 0; // 時間結束時，控制遊戲暫停無法操作
        }
        
        TimerText.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00")); // 更新計時器
   
    }
}
