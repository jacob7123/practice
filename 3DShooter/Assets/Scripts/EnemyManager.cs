using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy;
    public float delayTime  = 1f;
    public float repeatRate = 3f;
    public Transform[] spawnPoints;
    private bool playerIsDead = false;
    private void playerDeathAction()
    {
        playerIsDead = true;
    }
    private void OnEnable()
    {
        PlayerHealth.PlayerDeathEvent += playerDeathAction;
    }
    private void OnDisable()
    {
        PlayerHealth.PlayerDeathEvent -= playerDeathAction;
    }
    private void Spawn()
    {
        if (playerIsDead)
        {
            CancelInvoke("Spawn");
            return;
        }
        int pointIdx = Random.Range(0, spawnPoints.Length);
        int enemyIdx = Random.Range(0, enemy.Length);
        Instantiate(enemy[enemyIdx], spawnPoints[pointIdx].position, spawnPoints[pointIdx].rotation);

    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delayTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
