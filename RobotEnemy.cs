using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemy : MonoBehaviour
{
    [SerializeField]
    private string animalName; // 동물의 이름
    [SerializeField]
    private int hp; // 동물의 체력.

    [SerializeField]
    private float walkSpeed; // 걷기 스피드
    [SerializeField]
    private float runSpeed; // 뛰기 스피드

    private Vector3 direction; // 방향

    [SerializeField]
    private GameObject Batteryitem; //배터리 아이템


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
