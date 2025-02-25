using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @游戏的轴
 * 水平轴，按下a，从0到-1；按下d，从0到1。[-1, 1]
 * 垂直轴，按下w，从0到-1；按下s，从0到1。[-1, 1]
 */
public class Test03 : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 水平轴
        float h = Input.GetAxis("Horizontal");
        // 垂直轴
        float v = Input.GetAxis("Vertical");

        // 加速移动
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 50;
        }
        // 正常移动
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 1;
        }

        // 平滑移动
        // 当速度过快时，运动将不再是动力学移动，相当于直接对坐标系进行修改
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }

    // 用来做物理计算
    private void FixedUpdate()
    {
        
    }
}
