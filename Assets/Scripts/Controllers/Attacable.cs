using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Stats))]
public class Attacable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected Stats myStats;
    [SerializeField] protected bool isDead = false;
    
    private void Awake()
    {
        myStats = GetComponent<Stats>();
        if (!myStats)
            Debug.Log("Problem with myStats");
        else
        {
            Debug.Log("Stats Found");
        }
        
    }
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        Die();
    }
    public virtual void Die()
    {
       
    }
    public virtual void TakeDamge(float damage)
    {
        myStats.health -= damage;
    }
    public virtual void Attack(Attacable enemy)
    {   
       enemy.TakeDamge(myStats.baseAttack);
    }
    public virtual void Attack()
    {
        
    }
    public virtual void Dodge()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 1.5f);//Enemy attack Range
        
    }
}
