using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @WASTD���������ƶ�
 */
public class Test02 : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        // ������ԭ����������ƶ�1������
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


        // �ü��̿��������ƶ�
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


        // ʱ��������ÿ���ƶ�һ�� -> 1 * Time.deltaTime;

        /*
        // �����ӷ�
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


        // ����ƽ�ƣ�˲���ƶ�
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
