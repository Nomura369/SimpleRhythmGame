using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private float speed = 40f;
    public static bool isEnemyShot;
    
    // Start is called before the first frame update
    void Start()
    {
        isEnemyShot = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        if(transform.position.x > 50){ // 若子彈超出畫面則銷毀
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) {
        // 如果打中動物就銷毀子彈和動物
        if(other.gameObject.CompareTag("Enemy")){
            print("子彈打中了");
            isEnemyShot = true; // 音效設定
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
