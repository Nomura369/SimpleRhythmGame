using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class PlayerController : MonoBehaviour
{
    public static bool IsSpacePushed = false;
    public float H_input;
    public GameObject BulletPrefab;
    public AudioClip BulletGo;
    public AudioSource AudioSrc;
    public Text TutorialText;

    [SerializeField] Vector3 BulletOffset = new Vector3(0, 0, 2);
    [SerializeField] float MoveSpeed = 5f;
    [SerializeField] float ScreenBoundary = 16f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
        TutorialText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // 確保角色不會超出攝影機範圍
        if(transform.position.x < -ScreenBoundary){
            transform.position = new Vector3(-ScreenBoundary, transform.position.y, transform.position.z);
        }
        if(transform.position.x > ScreenBoundary){
            transform.position = new Vector3(ScreenBoundary, transform.position.y, transform.position.z);
        }

        // 角色的左右移動
        H_input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed * H_input);

        // 發射食物（子彈）
        if(Input.GetKeyDown(KeyCode.Space)){
            if(!IsSpacePushed){
                TutorialText.enabled = false;
                IsSpacePushed = true;
            }
            print("發射子彈");
            // AudioSrc.PlayOneShot(BulletGo);
            Instantiate(BulletPrefab, transform.position + BulletOffset, transform.rotation); 
        }
    }
}
