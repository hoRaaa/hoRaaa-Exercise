using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人动画;定义需要播放的动画片段名称
/// </summary>
public class EnemyAnimation : MonoBehaviour
{
    //跑步动画名称
    public string runAnimName;
    //攻击动画名称
    public string attackAnimName;
    //闲置动画名称
    public string idleAnimName;
    //死亡动画名称
    public string deathAnimName;
    //行为类
    public AnimationAction action;
    private void Awake()
    {
        //action = new AnimationAction();
    }
}
