using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @��Ϸ����
 * ˮƽ�ᣬ����a����0��-1������d����0��1��[-1, 1]
 * ��ֱ�ᣬ����w����0��-1������s����0��1��[-1, 1]
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
        // ˮƽ��
        float h = Input.GetAxis("Horizontal");
        // ��ֱ��
        float v = Input.GetAxis("Vertical");

        // �����ƶ�
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 5;
        }
        // �����ƶ�
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 1;
        }

        // ƽ���ƶ�
        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
}
