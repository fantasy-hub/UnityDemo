using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @��������
 * Rigidbody ��������������
 * ���ͣ�
 * �κ������������������һ���α�,��������α�����һ���ֶ���
 * ������һ�����������ģ�ͣ��ٶ��������ܵ����������α䱣�ֲ���
 * �������乫ʽ��x = 1 / 2gt^2�����������˶������Կ�������
 * ������g = 9.8
 */
public class Test04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * @��ײ����
     * һ��ж�ؽ�ɫ�Լ�����
     */
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��ײ����" + collision.gameObject.name);


        // ��ײ����ָ�����壬������
        if (collision.gameObject.name == "��ײ����ʧ") {
            // ������Ϸ����
            Destroy(collision.gameObject);
        }

    }

    /**
     * @��ײ������
     * �����жϽ����˴�������
     * һ��ж�ر���ɫ��ײ������������
     * ���������һ��������и�������
     * ������年ѡ��isTriggle����ײ�����ٲ����谭�����˶���Ч��
     * ����ֻ���������Ƿ������ײ����
     * ʵ��������Ч�������Ǻ����嶼Ҫ�߱���������
     */
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("��ײ��������" + other.name);
    }
}
