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



 void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
