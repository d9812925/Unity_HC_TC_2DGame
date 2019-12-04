using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 1500)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;
    public float angle = 3;

    public GameObject goScore, goGM;
    public Rigidbody2D r2d;
    public GameManager gm;


    [Header("Sound")]
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundScore;
    

    private void Update()
    {
        Jump();
        
    }
    /// <summary>
    /// 小雞跳躍功能。
    /// </summary>
    /// 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="水管 - 上"|| collision.gameObject.name == "水管 - 下")
        {
            Dead();
            aud.PlayOneShot(soundHit);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PointArea" && !isDead)
        {
            gm.AddScore();
            aud.PlayOneShot(soundScore);
        }
    }


    private void Jump()
    {
        if (isDead) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);

            r2d.Sleep();
            r2d.gravityScale = 1;
            r2d.AddForce(new Vector2(0, jump));
            aud.PlayOneShot(soundJump);
        }
        r2d.SetRotation(angle * r2d.velocity.y);
    }

    private void Start()
    {
        Screen.SetResolution(720, 1280, false);
    }



    /// <summary>
    /// 小雞死亡功能。
    /// </summary>
    private void Dead()
    {
        if (isDead) return;
        gm.GameOver();
        isDead = true;
        aud.PlayOneShot(soundHit, 1);

        Ground.speed = 0;
    }

    /// <summary>
    /// 通過水管。
    /// </summary>
    private void PassPipe()
    {

    }


}
