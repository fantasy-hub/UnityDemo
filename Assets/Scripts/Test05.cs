using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{

    // ��ȡ�������
    private Rigidbody rb;
    // ������
    public float force = 10;
    // �����ٶ�
    public float speed = 10;

    // ��
    // Start is called before the first frame update
    void Start()
    {
        // �õ���������ĸ������
        // new RigidBody()�Ǵ����� GetComponent<Rigidbody>�ǻ�ȡ
        rb = GetComponent<Rigidbody>();


        //rb.AddForce(new Vector3(0, 0, 1) * force);

    }
        
    // ��
    // Update is called once per frame
    void Update()
    {
        //rb.AddForce (new Vector3 (0, 0, 1) * force);
        if (Input.GetKey(KeyCode.W)) 
        {
            // ��һ��10N����
            rb.AddForce(new Vector3(0, 0, 1) * force);
        }


        if (Input.GetKey(KeyCode.Q))
        {
            // ���ٶȳ�Ϊ10m/s
            rb.velocity = (new Vector3(0, 0, 1)) * speed;
        }


        if (Input.GetKey(KeyCode.E))
        {
            // �����˶����������˶�
            // ʹ�ø���ʱ������������ѧЧ�������Բ������ַ�ʽ
            Vector3 newPos = transform.position + new Vector3(0, 0, 10) * Time.fixedDeltaTime;
            rb.AddForce(newPos);
        }

    }
}
