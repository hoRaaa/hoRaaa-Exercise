using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人状态;定义敌人信息、提供受伤死亡功能
/// </summary>
public class EnemyStatusInfo : MonoBehaviour
{
    //当前血量
    public float HP = 200;
    //最大血量
    public float maxHP = 200;

    //受伤
    public void Damage(float amount)
    {

    }

    //死亡
    public void Death()
    {
        
    }
}
