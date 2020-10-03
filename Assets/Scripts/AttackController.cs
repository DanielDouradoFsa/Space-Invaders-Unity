﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    private Transform attack;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        attack = GetComponent<Transform> ();
    }

    // Método para o ataque subir na vertical
    void FixedUpdate(){
        attack.position += Vector3.up * speed;

        if(attack.position.y>=10)
            Destroy(gameObject);
    }

    // Método para quando acertar um inimigo
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
    }
    
}
