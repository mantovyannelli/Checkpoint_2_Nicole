using UnityEngine;

public class cameracontrol : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private float uplimit, downlimit, leftlimit, rightlimit;



void Awake()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 p = new Vector3 (target.transform.position.x, target.transform.position.y, -10);

        p.x = Mathf.Clamp(p.x, leftlimit, rightlimit);
        p.y = Mathf.Clamp(p.y, downlimit, uplimit);

        transform.position = Vector3.Lerp(transform.position, p, speed * Time.deltaTime);
    }
}
