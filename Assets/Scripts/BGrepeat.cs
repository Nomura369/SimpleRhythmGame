using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGrepeat : MonoBehaviour
{
    private Vector3 StartPos;
    private float repeatWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position; // 儲存背景圖片初始位置
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // 如果背景跑掉了一半以上，就要從頭開始播放
        if(transform.position.x < StartPos.x - repeatWidth){
            transform.position = StartPos;
        }
    }
}
