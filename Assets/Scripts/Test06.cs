using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @开始游戏按钮
 */
public class Test06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 获取组件
        this.GetComponent<Button>().onClick.AddListener(HandleStartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleStartGame() 
    {
        Debug.Log("游戏开始");   
    }
}
