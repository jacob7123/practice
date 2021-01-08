using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int startHealth = 100;
    private int currentHealth;
    private Animator anim;
    private bool isDead;

    private bool isSinking;

    public AudioClip deadClip;
    private AudioSource enemyAudio;
    private ParticleSystem hitParticle; //去查ParticleSystem

    public int score = 10;
    void Awake()
    {
        anim          = GetComponent<Animator>();
        currentHealth = startHealth;
        enemyAudio    = GetComponent<AudioSource>();
        hitParticle   = GetComponentInChildren<ParticleSystem>();
    }
    private void Death()
    {
        isDead = true;
        anim.SetTrigger("isDead");
        enemyAudio.clip = deadClip;
        enemyAudio.Play();
        GetComponent<NavMeshAgent>().enabled  = false;
        GetComponent<EnemyMovement>().enabled = false;
        GetComponent<EnemyAttack>().enabled   = false;

        ScoreManager.score += score;
    }
    public void takeDamage(int amount, Vector3 position)
    {
        if (isDead) return;
        currentHealth -= amount;
        enemyAudio.Play();
        hitParticle.transform.position = position;
        hitParticle.Play();
        if (currentHealth <= 0)
        {
            //Call dead method
            Death();
        }
    }
    public void startSinking()
    {
        isSinking = true;
        Destroy(gameObject, 2f);
    }
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (isSinking)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
