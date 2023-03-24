using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;

    public Material mat;
    Vector3 dir;
    void Start()
    {
        int RandValue = Random.Range(0, 10);

        GameObject target = GameObject.Find("Player");
        if(RandValue < 3){
            dir = target.transform.position - transform.position;
            dir = dir.normalized;

            transform.localScale = new Vector3(1f, 0.5f, 0.5f);
            gameObject.GetComponent<MeshRenderer>().material = mat;
        }
        else{
            dir = Vector3.down;
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;        
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
