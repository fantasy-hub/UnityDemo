using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{

    // ��ȡ�������
    private Rigidbody rb;
    // ������
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        // �õ���������ĸ������
        // new RigidBody()�Ǵ����� GetComponent<Rigidbody>�ǻ�ȡ
        rb = GetComponent<Rigidbody>();

        // ��
        //rb.AddForce(new Vector3(0, 0, 1) * force);

    }

    // Update is called once per frame
    void Update()
    {
        // ��
        //rb.AddForce (new Vector3 (0, 0, 1) * force);
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(new Vector3(0, 0, 1) * force);
        }

    }
}
