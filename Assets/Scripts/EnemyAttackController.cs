using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : MonoBehaviour
{
    private Transform attack;
    public float speed;
    void Start()
    {
        attack = GetComponent<Transform> ();
    }

    void FixedUpdate(){
        attack.position += Vector3.up * -speed;

        if(attack.position.y <= -10)
            Destroy(attack.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Jogador"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameOver.isPlayerDead = true;
        }
    }
  
}
