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

    private void Update()
    {
        Jump();
        
    }
    /// <summary>
    /// 小雞跳躍功能。
    /// </summary>
    /// 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
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

        }
        r2d.SetRotation(angle * r2d.velocity.y);
    }





    /// <summary>
    /// 小雞死亡功能。
    /// </summary>
    private void Dead()
    {
        isDead = true;
    }

    /// <summary>
    /// 通過水管。
    /// </summary>
    private void PassPipe()
    {

    }


}
