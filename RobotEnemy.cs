using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemy : MonoBehaviour
{
    [SerializeField]
    private string animalName; // ������ �̸�
    [SerializeField]
    private int hp; // ������ ü��.

    [SerializeField]
    private float walkSpeed; // �ȱ� ���ǵ�
    [SerializeField]
    private float runSpeed; // �ٱ� ���ǵ�

    private Vector3 direction; // ����

    [SerializeField]
    private GameObject Batteryitem; //���͸� ������


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            
            Debug.Log("Player detected - Attack!!!");
        }
    }
}
