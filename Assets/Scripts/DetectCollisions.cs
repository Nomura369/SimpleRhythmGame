using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    public static bool IsAnimalShot = false; // 全域變數

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) { // 引數為撞進去的其他物件（之collider）
        IsAnimalShot = true;
        GameManager.scores++;

        Destroy(gameObject); // 該腳本附屬的物件本身
        Destroy(other.gameObject); // 撞進去的其他物件
    }
}
