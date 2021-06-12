using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public GameObject Target; // 타겟 : 플레이어
    private Vector3 direction; // 방향.
   [SerializeField] private Rigidbody rigid; // 해당 로봇



    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Target.transform.position - transform.position;
        dir.Normalize();
        transform.position += dir * Speed * Time.deltaTime;

         direction = Quaternion.LookRotation(transform.position - Target.transform.position).eulerAngles;

        Vector3 _rotation = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, direction.y, 0f), 0.01f);
        rigid.MoveRotation(Quaternion.Euler(_rotation));
    }
}
