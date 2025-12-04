using System.Security.Cryptography;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0.08f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();


        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
