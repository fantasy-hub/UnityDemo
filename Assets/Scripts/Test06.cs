using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @��ʼ��Ϸ��ť
 */
public class Test06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��ȡ���
        this.GetComponent<Button>().onClick.AddListener(HandleStartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleStartGame() 
    {
        Debug.Log("��Ϸ��ʼ");   
    }
}
