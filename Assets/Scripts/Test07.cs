using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @��ת
 */
public class Test07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ŷ����ת��Ԫ���� Quaternion.Euler
        //transform.rotation = Quaternion.Euler(new Vector3(45, 45, 0));
        
        // ����ֵ
        //Debug.Log(transform.rotation.y);
    
        // ŷ����-��ʵ��y
        //Debug.Log(transform.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
        // ÿ����ת10�ȣ�ͬtransform.Translate
        transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}
