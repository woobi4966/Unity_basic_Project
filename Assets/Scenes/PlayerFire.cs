using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    // 목표 : 플레이어가 발사 버튼을 눌렀을 때, 총알이 발사된다.

    // 총알 공장
    public GameObject bulletFactory;
    // 총구
    public GameObject firePosition;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            // 공장에서 총알을 만들고
            // 총알을 발사한다.
            GameObject bullet = Instantiate(bulletFactory); 
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
