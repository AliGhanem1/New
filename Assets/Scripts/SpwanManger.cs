using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManger : MonoBehaviour
{
    public GameObject[] EnemyPrefab;
    public GameObject PowerUpPrefab;

    private float spwanPosX = 13.5f;
    private float spwanEnemyPosZ = 7.5f;
    private float spwanPowerposZ = 2.5f;

    private float startSpwan = 0.5f;
    private float RepetSpwan = 2f;
    private float powerupRepetSpwan = 5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanEnemy", startSpwan, RepetSpwan);
        InvokeRepeating("SpwanPowerUp", startSpwan, powerupRepetSpwan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpwanEnemy()
    {
        float randomx = Random.Range(-spwanPosX, spwanPosX);
        int randomEnemy = Random.Range(0, EnemyPrefab.Length);
        Vector3 instanPos = new Vector3(randomx, 0.5f, spwanEnemyPosZ);

        Instantiate(EnemyPrefab[randomEnemy], instanPos, EnemyPrefab[randomEnemy].transform.rotation);
    }

    void SpwanPowerUp()
    {
        float randomx = Random.Range(-spwanPosX, spwanPosX);
        Vector3 instanPos = new Vector3(randomx, 0.5f, spwanPowerposZ);

        Instantiate(PowerUpPrefab, instanPos, PowerUpPrefab.transform.rotation);
    }
}
