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
    }

    void FixedUpdate()
    {
        OnMove();
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
}
