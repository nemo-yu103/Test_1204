using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.01f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.01f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab,transform.position,Quaternion.identity);
        }

    }
}
