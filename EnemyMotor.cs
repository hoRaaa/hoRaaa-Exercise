using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人马达，提供移动、旋转、寻路功能
/// </summary>
public class EnemyMotor : MonoBehaviour
{
    public float moveSpeed = 5;
    public Transform[] points;
    private int currentPointIndex;

    //向前移动 
    public void MovementForward()
    {
        this.transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
    //旋转
    public void LookRotation(Vector3 targetPoint)
    {
        this.transform.LookAt(targetPoint);//注视旋转
    }
    //寻路
    public bool Pathfinding()
    {
        if (points==null || currentPointIndex >= points.Length) return false;
        //朝向目标点
        LookRotation(points[currentPointIndex].position);
        //向前移动
        MovementForward();
        //如果接近目标的
        if(Vector3.Distance(this.transform.position,points[currentPointIndex].position)<0.5f)
        {
            currentPointIndex++;
        }
        return true;
    }
    private void Update()
    {
        Pathfinding();
    }
}
