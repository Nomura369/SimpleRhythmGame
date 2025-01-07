using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public Animator PlayerAnimator;
    public ParticleSystem ExplosionParticle;
    public ParticleSystem DirtParticle;
    public AudioClip JumpSound;
    public AudioClip CrashSound;
    public AudioSource PlayerAudio;

    public float jumpForce = 10;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>(); 
        Physics.gravity *= gravityModifier; // 改變 Unity 的重力場（跳躍的手感）
        PlayerAnimator = GetComponent<Animator>();
        PlayerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver){
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // 玩家向上跳躍 
            isOnGround = false;
            PlayerAudio.PlayOneShot(JumpSound, 0.05f); // 跳躍音效＆音量
            PlayerAnimator.SetTrigger("Jump_trig"); // 跳躍動畫
            DirtParticle.Stop(); // 跳躍時停止泥土飛濺特效
        }
    }

    private void OnCollisionEnter(Collision collision) { // 撞到（有碰撞體的）東西就執行
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
            DirtParticle.Play(); // 玩家在地面時，恢復泥土飛濺特效
        }
        else if(collision.gameObject.CompareTag("Obstacle")){
            isGameOver = true;
            print("Game Over");
            PlayerAudio.PlayOneShot(CrashSound, 0.05f); // 死亡音效＆音量
            // 設定死亡特效（確保不會多次觸發）
            if(isGameOver){
                ExplosionParticle.Play();
                DirtParticle.Stop();
            }
            // 設定死亡動畫
            PlayerAnimator.SetBool("Death_b", true);
            PlayerAnimator.SetInteger("DeathType_int", 1);
            
        }
    }
}
