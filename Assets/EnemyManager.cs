using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // 적 공장
    public GameObject EnemyFactory;
    // 현재 시간
    float currentTime;
    // 스폰 시간
    float createTime;
    public float maxTime = 5;
    public float minTime = 1;
    
    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime){
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
            
            currentTime = 0; 
            createTime = Random.Range(minTime, maxTime);
        }
    }
}
