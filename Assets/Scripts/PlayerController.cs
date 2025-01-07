using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] private Animator PlayerAnimator;
    // [SerializeField] private ParticleSystem ExplosionParticle;
    // [SerializeField] private ParticleSystem DirtParticle;
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
        // 不會有跳躍功能
        // DirtParticle.Play(); // 玩家在地面時，維持泥土飛濺特效
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
