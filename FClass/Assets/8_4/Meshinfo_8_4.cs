using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshinfo_8_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cube에 추가되어 있는 Mesh정보에 접근
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        for(int i =0; i<meshFilter.mesh.vertexCount; i++)
        {
            //정점좌표는 자신의 중앙점을 기준으로한 좌표
            Debug.Log("지역 좌표 : " + meshFilter.mesh.vertices[i]);

            //정점의 월드 좌표를 구하기 위해서는 자신의 위치를 더핸준다
            Vector3 worldPos = transform.position + meshFilter.mesh.vertices[i];
            Debug.Log("자신의 위치를 더해서 계산한 월드좌표 : " + worldPos);

            //월드좌표를 구하기 위한 함수 사용
            worldPos = transform.TransformPoint(meshFilter.mesh.vertices[i]);
            Debug.Log("함수를 사용하여 계산한 월드좌표 : " + worldPos);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
