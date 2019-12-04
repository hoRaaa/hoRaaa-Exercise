using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人AI
/// </summary>
public class EnemyAI : MonoBehaviour
{
    //定义敌人状态的枚举类型
    public enum State
    {
        Attack,
        PathFinding
    }
    //敌人状态
    private State currentState = State.PathFinding; 
 
    private EnemyAnimation anim;
    private EnemyMotor motor;
    private void Start()
    {
        anim = GetComponent<EnemyAnimation>();
        motor = GetComponent<EnemyMotor>();
    }
    private void Update()
    {
        //判断
        switch (currentState)
        {
            case State.PathFinding:
                motor.Pathfinding();
                //执行寻路 调用motor类中寻路方法 播放跑步动画
                //寻路结束，修改状态为攻击
                break;
            case State.Attack:
                //发起攻击 播放攻击动画
                break;
        }
    }
}
