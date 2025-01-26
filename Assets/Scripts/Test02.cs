using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {

    }

    //bool isMove = false;
    // Update is called once per frame
    void Update()
    {
        float z = transform.position.z;
        float y = transform.position.y;
        float x = transform.position.x;


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
        if (Input.GetKey(KeyCode.W))
        {
            z += 0.05f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 0.05f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 0.05f;
        }


        transform.position = new Vector3(x, y, z);
    }
}
