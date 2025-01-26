using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject obj; // 当前运行的游戏对象
    public Vector3 dir; // 向量，移动的方向
    private float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // obj.transform.position 当前游戏对象的位置 cube
        // transform.position 脚本挂载对象的位置 cube1
        // .normalized 单位化向量
        dir = (obj.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, obj.transform.position) >= 0.1f)
        {
            transform.position += dir * moveSpeed;
        }
    }
}
 