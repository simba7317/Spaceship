using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Speed = 1.0f;
    public GameObject Target; // Ÿ�� : �÷��̾�
    private Vector3 direction; // ����.
   [SerializeField] private Rigidbody rigid; // �ش� �κ�



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
