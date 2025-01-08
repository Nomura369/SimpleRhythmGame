using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 30;
    // private PlayerController PCscript;

    // Start is called before the first frame update
    void Start()
    {
        // PCscript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerController.isGameOver){
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }
        else{
            if(gameObject.name == "Background"){ // 停止移動背景
                transform.position = transform.position; 
            }
            if(gameObject.CompareTag("Enemy")){ // 銷毀離開畫面的動物
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
                if(transform.position.x < -5){
                    Destroy(gameObject);
                }
            }
        }
    }
}
