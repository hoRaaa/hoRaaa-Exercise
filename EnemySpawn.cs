using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人生成
/// </summary>

public class EnemySpawn : MonoBehaviour
{
    //需要创建的敌人预制件数组
    public GameObject[] enemyType;
    //需要创建的敌人数量
    public int maxCount = 5;
    //开始创建的数量
    public int startCount = 2;
    //已经创建的敌人数量
    private int spawnedCount;
    public void GenerateEnemy()
    {
        //选择一条可以使用的路线
        //延迟时间
        //Object.Instantiate(预制件，位置，旋转角度);
        int randomIndex = Random.Range(0, enemyType.Length);
        //随机创建一个敌人
        //GameObject go = Instantiate(enemyType[randomIndex], 第一个路点, Quaternion.identity) as GameObject;
        //配置信息
        //go.GetComponent<EnemyMotor>()
        
    }
}
