using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//vritual fution 이용하기
//virtual fution이란 모든 공통 기능을 상속 받은 것 즉 부모 클래스가 자식클래스에게 상속한 것이라고 생각하면된다.
//override는 자식클래스가 부모클래스의 
//다형성을 이용하면 기본 클래스의 함수 호출로 파생 클래스의 함수 접근이 가능해진다.

//부모 클래스는 virtual을 쓸것 
public class Enemy
{
    protected int hitPoint;
    public enum DamageType { Water, Fire };

    public virtual void TakeDamge(int amount, DamageType damageType)
    {
        hitPoint -= amount;
    }

    public string GetHitPoints()
    {
        return " " + hitPoint;
    }

}


//자식 클래스는 override을 쓸것 
class WaterEnemy : Enemy
{
    public WaterEnemy()
    {
        hitPoint = 30;
    }

    public override void TakeDamge(int amount, DamageType damageType)
    {
        if (damageType == DamageType.Fire)
        {
            base.TakeDamge(amount * 2, damageType);
        }
        else
        {
            base.TakeDamge(amount/2, damageType);
        }
    }
}


//자식 클래스는 override을 쓸것 
class FireEmemy : Enemy
{
   
    public override void TakeDamge(int amount, DamageType damageType)
    {
        if(damageType == DamageType.Fire)
        {
            base.TakeDamge(amount*10, DamageType.Water);
        }
    }
}
