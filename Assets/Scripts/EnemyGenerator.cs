using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {
        InvokeRepeating("GenRock",1,0.5f);
    }

    void Update()
    {
        Instantiate(enemyPrefab,new Vector3(-2.5f+5*Random.value,6,0),Quaternion.identity);
    }
}
