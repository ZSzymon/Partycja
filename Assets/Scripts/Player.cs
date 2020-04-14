using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum States
    {
        Staying,
        Moving,
        Attacking,
        Dodging,
        Dying
    }

    public States state;
    private PlayerInput input;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        state = States.Staying;
        input = this.GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        input.CheckInput();
//maszyna stanow
        switch (state)
        {
            case States.Dying:
                //tu trzeba ogolnie wylaczyc sterowanie i pokazac jakies menu czy cos
               // anim.SetBool("IsDeath", true);
                break;
            case States.Attacking:
              //  anim.SetBool("IsAttack", true);
                break;
            case States.Dodging:
                break;
            case States.Staying:
               // anim.SetBool("IsAttack", false);
                input.CheckInputNotMove();
                break;
            case States.Moving:
               // anim.SetBool("IsAttack", false);
                input.CheckInputNotMove();
                break;
        }
//------------------    
    }
}
