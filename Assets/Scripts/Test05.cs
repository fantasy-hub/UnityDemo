using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{

    // 获取刚体组件
    private Rigidbody rb;
    // 设置力
    public float force = 10;
    // 设置速度
    public float speed = 10;

    // 踢
    // Start is called before the first frame update
    void Start()
    {
        // 得到物体自身的刚体组件
        // new RigidBody()是创建， GetComponent<Rigidbody>是获取
        rb = GetComponent<Rigidbody>();


        //rb.AddForce(new Vector3(0, 0, 1) * force);

    }
        
    // 推
    // Update is called once per frame
    void Update()
    {
        //rb.AddForce (new Vector3 (0, 0, 1) * force);
        if (Input.GetKey(KeyCode.W)) 
        {
            // 给一个10N的力
            rb.AddForce(new Vector3(0, 0, 1) * force);
        }


        if (Input.GetKey(KeyCode.Q))
        {
            // 让速度成为10m/s
            rb.velocity = (new Vector3(0, 0, 1)) * speed;
        }


        if (Input.GetKey(KeyCode.E))
        {
            // 定点运动，非增量运动
            // 使用刚体时，不产生动力学效果，可以采用这种方式
            Vector3 newPos = transform.position + new Vector3(0, 0, 10) * Time.fixedDeltaTime;
            rb.AddForce(newPos);
        }

    }
}
