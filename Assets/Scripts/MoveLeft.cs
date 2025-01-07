using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController PCscript;

    // Start is called before the first frame update
    void Start()
    {
        PCscript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PCscript.isGameOver == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(transform.position.x < -10 && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
