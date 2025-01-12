using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody PlayerRb;

    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Vector3 BulletPos;
    [SerializeField] private Animator PlayerAnimator;
    // [SerializeField] private ParticleSystem ExplosionParticle;
    [SerializeField] private ParticleSystem DirtParticle;
    [SerializeField] private AudioClip DieSound;
    [SerializeField] private AudioSource PlayerAudio;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private Button GameOverBtn;

    // [SerializeField] private float jumpForce = 10;
    // [SerializeField] private float gravityModifier = 1;
    // [SerializeField] private bool isOnGround = true;
    public static bool isGameOver;
    [SerializeField] private Vector3 BulletOffset = new Vector3(1.71f, 1.53f, 0);

    void Start()
    {
        isGameOver = false;
        PlayerRb = GetComponent<Rigidbody>(); 
        // Physics.gravity *= gravityModifier; // 改變 Unity 的重力場（跳躍的手感）
        PlayerAnimator = GetComponent<Animator>();
        BulletPos = transform.position + BulletOffset;
        GameOverUI.SetActive(false);
        GameOverBtn.onClick.AddListener(RestartGame);
    }

    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver){ // 按下空白鍵跳躍
        //     PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //     isOnGround = false;
        //     PlayerAnimator.SetTrigger("Jump_trig"); // 跳躍動畫
        //     DirtParticle.Stop(); // 跳躍時停止泥土飛濺特效
        // }

        if(Input.GetKeyDown(KeyCode.Z) && !isGameOver && GameStart.isGameStart){ // 按下Z鍵發射子彈
            Instantiate(BulletPrefab, BulletPos, BulletPrefab.transform.rotation);
        }

        
    }

    private void OnCollisionEnter(Collision collision) { // 撞到（有碰撞體的）東西就執行
        if(collision.gameObject.CompareTag("Ground")){
            // isOnGround = true;
            DirtParticle.Play(); // 玩家在地面時，恢復泥土飛濺特效
        }
        
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Enemy")){
            isGameOver = true;
            print("Game Over");
            GameOverUI.SetActive(true);
            // 設定死亡音效＆特效
            PlayerAudio.PlayOneShot(DieSound);
            DirtParticle.Stop(); 
            // 設定死亡動畫
            PlayerAnimator.SetBool("Death_b", true);
            PlayerAnimator.SetInteger("DeathType_int", 1);
        }
    }
    
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
