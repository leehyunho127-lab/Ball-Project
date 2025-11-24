using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject targetCamera;
    public GameObject targetObject;

    private Vector3 offset; //카메라와 타켓 사이 거리
    
    void Start()
    {
        offset = targetCamera.transform.position - targetObject.transform.position;
        //거리 = 타켓카메라의 트랜스폼 위치 빼기 타겟오브젝트 트랜스폼 위치
    }

    // Update is called once per frame
    void Update()
    {
        targetCamera.transform.position = offset + targetObject.transform.position;
        //타겟 카메라 위치 설정(거리+타겟오브젝트위치)
    }
}
