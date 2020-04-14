using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] public float health;
    [SerializeField] public float baseAttack = 20f;
    [SerializeField] public float playerRangeAttack = 10f;
    
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
