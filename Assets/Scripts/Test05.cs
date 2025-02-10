using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{

    // 获取刚体组件
    private Rigidbody rb;
    // 设置力
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        // 得到物体自身的刚体组件
        // new RigidBody()是创建， GetComponent<Rigidbody>是获取
        rb = GetComponent<Rigidbody>();

        // 踢
        //rb.AddForce(new Vector3(0, 0, 1) * force);

    }

    // Update is called once per frame
    void Update()
    {
        // 推
        //rb.AddForce (new Vector3 (0, 0, 1) * force);
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(new Vector3(0, 0, 1) * force);
        }

    }
}
