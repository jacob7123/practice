using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int damageperShoot = 20;
    public float range        = 100f;
    private Ray shootRay;
    private RaycastHit shootHit;
    private int shootableMask;
    private Light gunLight;
    private ParticleSystem gunParticla;
    private AudioSource gunAudio;
    private LineRenderer gunLine;

    public float timeBetweenBullets = 0.15f;
    private float effectDisplayTime = 0.2f;
    float timer;

    void Awake()
    {
        shootableMask = LayerMask.GetMask("enemy");
        gunParticla   = GetComponent<ParticleSystem>();
        gunLine       = GetComponent<LineRenderer>();
        gunAudio      = GetComponent<AudioSource>();
        gunLight      = GetComponent<Light>();
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    private void Shoot()
    {
        timer = 0f;
        gunAudio.Play();
        gunLight.enabled = true;
        gunParticla.Stop();
        gunParticla.Play();

        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);

        /*
         * transform.forward is object forward, but Vector3.forward is world forward.
         */
        shootRay.origin    = transform.position;
        shootRay.direction = transform.forward;

        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            // 取得
            EnemyHealth enemyhealth = shootHit.collider.GetComponent<EnemyHealth>();
            enemyhealth.takeDamage(damageperShoot, shootHit.point);
            gunLine.SetPosition(1, shootHit.point);
        }
        else
        {
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }
    }
    void disableEffect()
    {
        gunLine.enabled  = false;
        gunLight.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timer >= timeBetweenBullets)
        {
            Shoot();
        }
        if (timer >= timeBetweenBullets * effectDisplayTime)
        {
            disableEffect();
        }
    }
}
