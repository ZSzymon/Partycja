using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingSystemPlayer : Attacable
{
    [SerializeField] private GameObject attackPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {
        //RaycastHit hit;
        if (attackPoint)
        {
            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.transform.position, myStats.playerRangeAttack, LayerMask.GetMask("Enemy"));
            foreach (Collider enemy in hitEnemies)
            {
                Debug.Log("Hitted: " + enemy.name);
                if (enemy.GetComponent<Attacable>())
                {
                    enemy.GetComponent<Attacable>().TakeDamge(myStats.baseAttack);
                }
            }
            Debug.Log("Hitted Enemies: " + hitEnemies.Length);
        }
    }
}
