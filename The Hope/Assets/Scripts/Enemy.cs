using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 7.5f;
    public float rotationSpeed = 5.0f;
    private CharacterController _charCtrl;
    private Animator _animator;

    // Jump
    public float jumpSpeed = 15.0f;
    public float gravity = -9.8f;
    public float terminalVelocity = -10.0f;
    public float minFall = -1.5f;
    private float _vertSpeed;
    public bool jumP = false;

    //Attack
    public bool atk;

    private void Start()
    {
        _charCtrl = GetComponent<CharacterController>();
        _vertSpeed = minFall;
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Vector3 movement = Vector3.zero;

        float verInput = Input.GetAxis("Vertical");
        // Jump begin
        this.jump();
        movement.y = _vertSpeed;
        // Jump end

        //Attack
        this.attack();


        movement *= Time.deltaTime;
        _charCtrl.Move(movement);
    }
    // Start is called before the first frame update
    public void Active()
    {
        Debug.Log("AntiAirAc");
            if (!jumP)
            {
                jumP = true;
                print("Jump!!!");
            }
    }
    public void Deactive()
    {
        Debug.Log("Deactive");
        if (jumP)
        {
            jumP = false;
        }
    }


    public void AtkActive()
    {
        Debug.Log("Atk");
        print("atk!!!");
        if (!atk)
        {
            atk = true;
            
        }
    }
    public void AtkDeactive()
    {
        Debug.Log("DeAtk");
        if (atk)
        {
            atk = false;
        }
    }

    public bool attack()
    {
        if (atk)
        {
            _animator.SetBool("Attacking", true);
            atk = false;
            
        }
        else
        {
            _animator.SetBool("Attacking", false);
           
        }
        return atk;
    }

    public void jump()
    {
        if (_charCtrl.isGrounded) // check if player on ground
        {
            if (jumP)
            {
                _vertSpeed = jumpSpeed;  // set jump force if press "jump"
                _animator.SetBool("Jumping", true);
                jumP = false;
            }
            else
            {
                _vertSpeed = minFall;    // set jump force to fall
                _animator.SetBool("Jumping", false);
            }
        }
        else
        { // if not in Jump state
            _vertSpeed += gravity * 5 * Time.deltaTime; // drag player to ground
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }
        }
    }
}
