using Unity.VisualScripting;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{

    [Header("Configurações pulo")]
    [SerializeField] private float jumpforce;
    [SerializeField] private Transform sensorGround;
    [SerializeField] private Vector3 sensorSize;
    [SerializeField] private float jumptime;
    [SerializeField] private float localgravity;
    

    

    private Vector2 direction;
    private float currentjump;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    [SerializeField] private LayerMask layerGround;
    [SerializeField] private float speed;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
       
    }
    void Start()
    {
        rb.gravityScale = localgravity;
    }


    void Update()
    {
        Move();
        Jump();
    }

    void FixedUpdate()
    {
        OnMove();
        OnJump();
    }

    void Move()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        if (direction.x > 0)
        {
            sr.flipX = false;
        }
        else if (direction.x < 0)
        {
            sr.flipX = true;
        }
    }

    void OnMove()
    {
        rb.linearVelocity = new Vector2(direction.x, rb.linearVelocityY);
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && OnGround()==true)
        {
            currentjump = jumptime;
        }
        else if (Input.GetButton("Jump") && currentjump > 0)
        {
            currentjump -= Time.deltaTime;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            currentjump = 0;
        }
    }

    void OnJump()
    {
        if (currentjump > 0)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    public bool OnGround()
    {
        return Physics2D.OverlapBox(sensorGround.position, sensorSize, 0);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(sensorGround.position, sensorSize);
    }

    public int MoveValueX()
    {
        return (int)direction.x;
    }

    public int JumpValue()
    {
        return (int)rb.linearVelocityY;
    }

  void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject, 0.5f);
        }
      
    }

    
}
