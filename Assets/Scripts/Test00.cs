using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test00 : MonoBehaviour
{
    //float z = 0;
    int dir = 1;
    float startPos;
    float endPos;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
        // 在任意点进行z移动
        startPos = this.transform.position.z;
        endPos = this.transform.position.z + 10;
    }

    // Update is called once per frame
    void Update()
    {
        // 在[0, 0]点进行z移动
        /*
        if (dir > 0)
        {
            z += 0.1f;

            if (z >= 10)
            {
                dir = -1;
            }
        } else
        {
            z -= 0.1f;
            
            if (z <= 0)
            {
                dir = 1;
            }
        }

        
        this.transform.position = new Vector3(0, 0, z);
        */

        // 在[0, 0]点进行z移动
        /*
        if (transform.position.z >= 10)
        {
            dir = -1;
        } else if (transform.position.z <= 0)
        {
            dir = 1;
        }
        z += 0.1f * dir;
        this.transform.position = new Vector3(0, 0, z);
        */

        if (this.transform.position.z >= endPos)
        {
            dir = -1;
        } else if (this.transform.position.z <= startPos) {
            dir = 1;
        }
        this.transform.position += new Vector3(0, 0, 0.1f * dir);
    }
}
