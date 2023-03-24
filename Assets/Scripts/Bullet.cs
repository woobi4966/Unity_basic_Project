using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 목표 : 총알이 계속 위로 이동한다.


    // 총알 이동 속력
    public float speed = 5;    


    void Start()
    {
        
    }

    void Update()
    {
        // 1. 방향 구하기
        Vector3 dir = Vector3.up;   
        // 2. 이동하고 싶다. 공식  p = p0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

}
