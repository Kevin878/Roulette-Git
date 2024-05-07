using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 宣告變數以設定旋轉速度
    float rotSpeed = 0;

    void Start()
    {
        // 設定初始的旋轉速度為0
        rotSpeed = 0;

        // 將影格速率設為每秒60格
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 偵測左鍵是否被點擊，0為左鍵，1為右鍵，2為中間滾輪
        if (Input.GetMouseButtonDown(0))
        {
            // 設定旋轉速度為10
            this.rotSpeed = 10;
        }
        else if(Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 30;
        }
        else if(Input.GetMouseButtonDown(2))
        {
            this.rotSpeed = 100;
        }
        else
        {
            //讓輪盤旋轉減速
            this.rotSpeed *= 0.991f;
        }

        // 根據設定的速度旋轉輪盤 X Y Z
        transform.Rotate(0, 0, this.rotSpeed);

    }
}
