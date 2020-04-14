using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingSystemEnemy : Attacable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
    public override void Die()
    {
        base.Die();
        Debug.Log("Enemy health: " + myStats.health);
        if(myStats.health <= 0)
        {
            Debug.Log("Enemy Died");
            Destroy(this.gameObject, 5f);
        }
    }
    
    
}
