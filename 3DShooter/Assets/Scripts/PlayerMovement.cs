using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 movement;
    private Animator anim;
    private Rigidbody playerRigidbody;

    private float camRayLength = 100f;
    private int floorMask;
    /*
     * We use awak here because awake is earlier than start in lifecycle
     * 可以去生命週期複習
     * 
    void Start()
    {
        
    }
    */
    void Awake() //initial data
    {
        anim            = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        floorMask       = LayerMask.GetMask("floor");
    }
    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse  = floorHit.point - transform.position;
            playerToMouse.y        = 0; //We do not need y value
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playerRigidbody.MoveRotation(newRotation);
        }
    }
    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }
    /*
     * 加入走路動作腳本
     */
    void Animating(float h, float v)
    {
        bool working = h != 0 || v != 0;
        anim.SetBool("isWalking", working);
    }

    /*
     * Do not need update
    // Update is called once per frame
    void Update()
    {
        
    }
    */
    void FixedUpdate()
    {
        /*
         * 慢慢漸前進1個單位。
         * 例子:搖桿操作，蘑菇頭慢慢前進。
         *
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        */

        /*
         * 直接往前移一個單位
         */
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        //Debug.Log(h + ":" + v);
        Move(h, v);
        Turning();
        Animating(h, v);
    }
}
