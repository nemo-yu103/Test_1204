using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    void Start()
    {
        this.fallSpeed = 0.005f + 0.008f * Random.value;
        this.rotSpeed = 0.1f + 1f * Random.value;
    }

    void Update()
    {
        transform.Translate(0, -fallSpeed, 0,Space.World);
        transform.Rotate(0, 0,rotSpeed);
        if (transform.position.y < -5.5f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}
