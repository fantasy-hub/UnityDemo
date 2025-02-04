using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @WASTD控制物体移动
 */
public class Test02 : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        // 在物体原坐标基础上移动1的向量
        //transform.Translate(new Vector3(1, 1, 1));
    }

    //bool isMove = false;
    // Update is called once per frame
    void Update()
    {
        //float z = transform.position.z;
        //float y = transform.position.y;
        //float x = transform.position.x;
        float z = 0, y = 0, x = 0;


        // 用键盘控制物体移动
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            isMove = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            isMove = false;
        }
        if (isMove)
        {
            z += 0.05f;
        }
        */


        // 时间增量：每秒移动一米 -> 1 * Time.deltaTime;

        /*
        // 向量加法
        if (Input.GetKey(KeyCode.W))
        {
            z += 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 1 * Time.deltaTime;
        }
        transform.position = new Vector3(x, y, z);
        */


        // 向量平移，瞬间移动
        if (Input.GetKey(KeyCode.W))
        {
            z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = -1;
        }
        transform.Translate(new Vector3(x, y, z) * Time.deltaTime);

    }
}
