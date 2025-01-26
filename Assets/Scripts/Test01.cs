using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject obj; // ��ǰ���е���Ϸ����
    public Vector3 dir; // �������ƶ��ķ���
    private float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // obj.transform.position ��ǰ��Ϸ�����λ�� cube
        // transform.position �ű����ض����λ�� cube1
        // .normalized ��λ������
        dir = (obj.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, obj.transform.position) >= 0.1f)
        {
            transform.position += dir * moveSpeed;
        }
    }
}
 