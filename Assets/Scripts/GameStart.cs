using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private GameObject StartUI;
    [SerializeField] private Button StartBtn;
    [SerializeField] private GameObject ScorePanel;
    // [SerializeField] private GameObject[] StoryTexts;
    // [SerializeField] private float repeatInterval = 5.5f;
    // private float timer = 0;
    // public static bool isStoryStart;
    public static bool isGameStart;

    void Start()
    {
        // isStoryStart = false;
        // for(int i = 0; i < StoryTexts.Length; i++){
        //     StoryTexts[i].SetActive(true);
        // }
        isGameStart = false;
        ScorePanel.SetActive(false);
        StartUI.SetActive(true);
        StartBtn.onClick.AddListener(StartGame);
    }

    void Update()
    {
        if(isGameStart){
            StartUI.SetActive(false);
            ScorePanel.SetActive(true);
        }
        // if(isStoryStart){
        //     StartUI.SetActive(false);
        //     timer += Time.deltaTime;
        // }
    }

    // public void StartStory(){
    //     isStoryStart = true; // 觸發遊戲開頭劇情
    // }

    public void StartGame(){
        isGameStart = true;
    }
}
