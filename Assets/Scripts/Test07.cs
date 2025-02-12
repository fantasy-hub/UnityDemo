using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @旋转
 */
public class Test07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 欧拉角转四元数： Quaternion.Euler
        //transform.rotation = Quaternion.Euler(new Vector3(45, 45, 0));
        
        // 正弦值
        //Debug.Log(transform.rotation.y);
    
        // 欧拉角-真实的y
        //Debug.Log(transform.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
        // 每秒旋转10度，同transform.Translate
        transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}
