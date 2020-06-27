using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDemo : MonoBehaviour
{
    private void OnDisable()
    {
        WaterEnemy waterEnemy = new WaterEnemy();
        waterEnemy.TakeDamge(10, Enemy.DamageType.Fire);
        Debug.Log(waterEnemy.GetHitPoints());
    }
   
}
