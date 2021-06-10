using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed; //플레이어 움직임 속도
    public float lookSensitivity; //카메라 민감도
    public float cameraRotationLimit; //위로 올렸을 때 360도 돌아가지 않게
    public float currentCameraRotationX;

    public Camera theCamera; //플레이어 카메라

    private Rigidbody myRigid; //플레이어 리지드 바디


    // Use this for initialization
    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); //리지드 바드 컴포넌트를 myRigid에 넣음
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        if (!Inventory.inventoryActivated)
        {
            CameraRotation();
            CharacterRotation();
        }

    }

    private void Move()
    {

        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * walkSpeed;

        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }


    private void CharacterRotation()
    {
        // 좌우 캐릭터 회전
        float _yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY));
        Debug.Log(myRigid.rotation);
        Debug.Log(myRigid.rotation.eulerAngles);
    }

    private void CameraRotation()
    {
        // 상하 카메라 회전
        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _cameraRotationX = _xRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
        //
    }
}
