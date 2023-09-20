using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public bool grounded;
    public LayerMask groundLayer;
    public float jumpSpeed;
    private MovementBehavior _mvb;
    private Animator _anim;
    private SpriteRenderer _spr;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        _mvb = GetComponent<MovementBehavior>();
        _anim = GetComponent<Animator>();
        _spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        
        if(dir.x == 1)
        {
            _spr.flipX = true;
            //transform.localScale = new Vector3(1* transform.localScale.x, 1* transform.localScale.y, 1* transform.localScale.z);
        }
        if(dir.x == -1)
            //transform.localScale = new Vector3(-1* transform.localScale.x, 1* transform.localScale.y, 1* transform.localScale.z);
            _spr.flipX = false;

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            _mvb.Jump(jumpSpeed);
            _anim.SetInteger("state", 2);
        }

        if (dir.x != 0)
            _anim.SetInteger("state", 1);

        if (!Input.anyKey)
        {
            _mvb.StopMovement();
            _anim.SetInteger("state", 0);
        }

       RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, groundLayer);
        if (hit)
        {
            grounded = true;
        }
        else
            grounded = false;
    }
    public void FixedUpdate()
    {
        _mvb.MoveRB(dir);
    }

    public void PlayerGetDamage()
    {
        _anim.SetTrigger("hurt");
    }

    public void DiePlayer()
    {
        _anim.SetTrigger("die");
    }
}
