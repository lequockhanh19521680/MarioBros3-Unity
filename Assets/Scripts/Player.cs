using System;
using Unity.VisualScripting;
using UnityEngine;



public class Player : MonoBehaviour
{
    public const int iStateIdle = 1;
    public const int iStateWalkingLeft = 2;
    public const int iStateWalkingRight = 3;
    public const int iStateRunLeft = 4;
    public const int iStateRunRight = 5;
    public const int iStateJump = 6;

    [SerializeField] private float moveSpeed = 5f;        // Tốc độ di chuyển
    [SerializeField] private float acceleration = 10f;    // Gia tốc
    [SerializeField] private float jumpForce = 10f;       // Lực nhảy
    [SerializeField] private float gravityScale = 2f;     // Trọng lực
    [SerializeField] private float minVelocityIsGround = 0.01f;       // Điều kiện để là mặt đất
    [SerializeField] private Transform groundCheck;       // Kiểm tra đất
    [SerializeField] private LayerMask groundLayer;       // Layer của mặt đất

    private float velocityX;
    private int iState;
    private Rigidbody2D rb;

    private static Player instance;

    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Player>();

                if (instance == null)
                {
                    // Nếu không tìm thấy, tạo mới một instance mới
                    GameObject singletonObject = new GameObject("PlayerSingleton");
                    instance = singletonObject.AddComponent<Player>();
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
        iState = iStateIdle;
    }

    public bool GetIsGround()
    {
        return (Math.Abs(rb.velocity.y) < Math.Abs(minVelocityIsGround));
    }
    private void Update()
    {
        //Debug vận tốc
        Vector2 v2Velocity = rb.velocity;
        Debug.Log("Speed: " + v2Velocity.magnitude);
        Debug.Log("X Speed: " + v2Velocity.x);
        Debug.Log("Y Speed: " + v2Velocity.y);
    }

    private void FixedUpdate()
    {
        // Cập nhật vận tốc của Rigidbody2D
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }

    public int GetState()
    {
        return iState;
    }

    public void SetState(int l)
    {
        switch (l)
        {
            case iStateIdle:
                velocityX = Mathf.Lerp(velocityX, 0f, Time.deltaTime * acceleration);
                break;
            case iStateWalkingLeft:
                velocityX = Mathf.Lerp(velocityX, -moveSpeed, Time.deltaTime * acceleration);
                break;
            case iStateWalkingRight:
                velocityX = Mathf.Lerp(velocityX, moveSpeed, Time.deltaTime * acceleration);
                break;
            case iStateJump:
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                break;
            default: break;
        }
        iState = l;
    }
}