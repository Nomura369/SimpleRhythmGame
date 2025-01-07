using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBullet : MonoBehaviour
{
    [SerializeField] float TopBoundary = 30f;
    [SerializeField] float BottomBoundary = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > TopBoundary){
            Destroy(gameObject); // 銷毀超出畫面的子彈
        } else if(transform.position.z < BottomBoundary){
            Destroy(gameObject); // 銷毀超出畫面的動物
        }
    }
}
