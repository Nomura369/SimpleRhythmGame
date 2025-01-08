using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Vector3 BulletPos = new Vector3(1.71f, 1.53f, 0);
    // [SerializeField] private Animator PlayerAnimator;
    // [SerializeField] private ParticleSystem ExplosionParticle;
    [SerializeField] private ParticleSystem DirtParticle;
    // [SerializeField] private AudioClip CrashSound;
    // [SerializeField] private AudioSource PlayerAudio;

    // [SerializeField] private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // PlayerAnimator = GetComponent<Animator>();
        // PlayerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        DirtParticle.Play(); // 玩家跑步時維持泥土飛濺特效

        if(Input.GetKeyDown(KeyCode.Space)){ // 按下空白鍵發射子彈
            Instantiate(BulletPrefab, BulletPos, BulletPrefab.transform.rotation);
        }
    }

    // private void OnCollisionEnter(Collision collision) { // 撞到（有碰撞體的）東西就執行
    //     if(collision.gameObject.CompareTag("Obstacle")){
    //         isGameOver = true;
    //         print("Game Over");
    //         PlayerAudio.PlayOneShot(CrashSound, 0.05f); // 死亡音效＆音量
    //         // 設定死亡特效（確保不會多次觸發）
    //         if(isGameOver){
    //             ExplosionParticle.Play();
    //             DirtParticle.Stop();
    //         }
    //         // 設定死亡動畫
    //         PlayerAnimator.SetBool("Death_b", true);
    //         PlayerAnimator.SetInteger("DeathType_int", 1);
            
    //     }
    // }
}
