using UnityEngine;

public class Monster : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 10)]
    public float Movespeed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int Attake = 100;
    [Header("血量"), Range(0, 200)]
    public float HP = 350;
    [Header("掉落道具(遊戲物件)"), Tooltip("掉落道具(遊戲物件)")]
    public bool Prop;
    [Header("掉落道具機率"), Range(0, 1)]
    public float PropProbability = 1f;
    [Header("掉落道具音效"), Tooltip("掉落道具音效")]
    public AudioClip AudC;

    private AudioSource Aud;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion
}
