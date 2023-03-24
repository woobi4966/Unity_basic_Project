using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 목표 : 사용자의 입력에 따른 플레이어 움직임 구현

    /* 
    순서 :
    1) 사용자 입력
    2) 입력을 Object에 전달
    3) 입력에 따른 Object 행동
    */
    
    // 플레이어 이동 속력
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * speed * Time.deltaTime;
    }
}
