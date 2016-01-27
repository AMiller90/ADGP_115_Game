﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
    public int startingHealth = 100;
    public int currentHealth;
    EnemyMovement enemyMove;
    //Animator anim;
    bool isDead;
	// Use this for initialization
	void Start () {

        currentHealth = startingHealth;
        enemyMove = GetComponent<EnemyMovement>();
        //anim = GetComponent<Animator>();
}

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth == 0)
        {
            Dead();
        }
    }
    void Dead() { 

    isDead = true;

    //anim.SetTrigger("Die");

    enemyMove.enabled = false; }
// Update is called once per frame
void Update () {
	    
	}
}