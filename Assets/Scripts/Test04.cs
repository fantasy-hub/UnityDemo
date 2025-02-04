using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @物理引擎
 * Rigidbody 组件（刚体组件）
 * 解释：
 * 任何物体遇到力都会产生一个形变,物体产生形变会抵消一部分动能
 * 刚体是一个理想的物理模型，假定物体在受到外力作用形变保持不变
 * 物体下落公式：x = 1 / 2gt^2，自由落体运动，忽略空气阻力
 * 重力：g = 9.8
 */
public class Test04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * @碰撞函数
     * 一般卸载角色自己身上
     */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("碰撞对象：" + collision.gameObject.name);


        // 碰撞到了指定物体，就销毁
        if (collision.gameObject.name == "碰撞后消失") {
            // 销毁游戏对象
            Destroy(collision.gameObject);
        }

    }

    /**
     * @碰撞触发器
     * 用来判断进入了触发区域
     * 一般卸载被角色碰撞到的物体身上
     * 激活触发器的一方必须具有刚体属性
     * 如果物体勾选了isTriggle，碰撞器不再产生阻碍物体运动的效果
     * 而是只会检测物体是否进入碰撞区域
     * 实现推箱子效果，主角和物体都要具备刚体属性
     */
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("碰撞触发区：" + other.name);
    }
}
