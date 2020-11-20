﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage= 30 ;
    public Rigidbody2D rb;

   void OnCollisionEnter2D(Collision2D collision)
   {
      if(collision.gameObject.tag == "Player"){
          
           collision.gameObject.SendMessage("TakeDamage", damage);
      } 
       GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
       Destroy(effect, 1f);
       Destroy(gameObject);
   }

}
