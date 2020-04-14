using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : AttackingSystemPlayer
{
    public float dodgeRate = 0.9f;
    private float nextDodge;
    public float attackRate = 0.9f;
    private float nextAttack;
    

    public float InputX;
    public float InputZ;
    public Vector3 desiredMoveDirection;
    public bool blockRotationPlayer;
    public float desiredRotationSpeed;
    public Animator anim;
    public float Speed;
    public float allowPlayerRotation;
    public Camera cam;
    public CharacterController controller;
    public bool isGrounded;
    private float verticalVel;
    private Vector3 moveVector;
    public float moveSpeed = 2f;

    [SerializeField] Interactable focusedOn = null;
    [SerializeField] Transform playerTransform;
    bool isFocus = false;
    void Start()
    {
        anim = this.GetComponent<Animator>();
        cam = Camera.main;
        controller = this.GetComponent<CharacterController>();
        //poniezsze na wszelki wypadek, zaczecia nowej gry nie po raz pierwszy
        anim.SetBool("IsDeath", false);
        anim.SetBool("IsAttack", false);
        playerTransform = PlayerManger.instance.player.transform;
    }

    public void CheckInput()
    {
        InputMagnitude(); //ogolnie sila nacisku na drazku i klawiaturze(klawiatura slabo dziala na tym)
                          //sprawdzenie czy jestesmy na ziemi(character controller bez tego sie buguje)
        isGrounded = controller.isGrounded;
        if (isGrounded) verticalVel -= 0;
        else verticalVel -= 2;

        moveVector = new Vector3(0, verticalVel, 0);
        controller.Move(moveVector);
    }

    void PlayerMoveAndRotation()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        var camera = Camera.main;
        var forward = cam.transform.forward;
        var right = cam.transform.right;
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        desiredMoveDirection = forward * InputZ + right * InputX;

        if (!blockRotationPlayer)
        {//poruszenie
            controller.Move(desiredMoveDirection * Time.deltaTime * moveSpeed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), desiredRotationSpeed);
        }
    }

    public void InputMagnitude()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        anim.SetFloat("Vertical", InputZ, 0.0f, Time.deltaTime * 2f);
        anim.SetFloat("Horizontal", InputX, 0.0f, Time.deltaTime * 2f);

        Speed = new Vector2(InputX, InputZ).sqrMagnitude;

        if (Speed > allowPlayerRotation)
        {
            anim.SetFloat("InputMagnitude", Speed, 0.0f, Time.deltaTime);
            PlayerMoveAndRotation();
        }
        else if (Speed < allowPlayerRotation)
        {
            anim.SetFloat("InputMagnitude", Speed, 0.0f, Time.deltaTime);
        }
    }

    public void CheckInputNotMove()
    {
        
        if (Input.GetButton("Attack1") && Time.time > nextAttack)
        {
            //attack
            Attack();
            nextAttack = Time.time + attackRate;
            anim.SetBool("IsAttack", true);
            Debug.Log("attackButton");
        }

        if (Input.GetButton("Dodge") && Time.time > nextDodge)
        {
            //dodge
            
            nextDodge = Time.time + dodgeRate;
            Debug.Log("dodgeButton");
        }

        if (Input.GetButtonDown("Options"))
        {
            //opcje
            Debug.Log("optionsButton");
        }

        checkRightButtonClick();
    }
    void checkRightButtonClick()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            LayerMask layer = 0;
            layer = LayerMask.NameToLayer("Interacable");
            if (layer == 0)
                Debug.LogError("Problem with layer");
            if (Physics.Raycast(ray, out hit, layer))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (!interactable)
                    Debug.LogWarning("no Interactable hit.");
                else
                {
                    SetFocusOn(interactable);
                    interactable.OnFocused(playerTransform);
                }
            }

        }
    }
    void SetFocusOn(Interactable interactable)
    {
        focusedOn = interactable;
        isFocus = true;
    }
    void Removefocus()
    {
        focusedOn = null;
        isFocus = false;
    }

}
