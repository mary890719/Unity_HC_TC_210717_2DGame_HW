using UnityEngine;

public class Monster : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 10)]
    public float Movespeed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public int Attake = 100;
    [Header("��q"), Range(0, 200)]
    public float HP = 350;
    [Header("�����D��(�C������)"), Tooltip("�����D��(�C������)")]
    public bool Prop;
    [Header("�����D����v"), Range(0, 1)]
    public float PropProbability = 1f;
    [Header("�����D�㭵��"), Tooltip("�����D�㭵��")]
    public AudioClip AudC;

    private AudioSource Aud;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion
}
