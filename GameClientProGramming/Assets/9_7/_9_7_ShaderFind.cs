using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_7_ShaderFind : MonoBehaviour
{
    // 셰이더를 실시간 교체 하는 프로그램 코드 작성
    void Start()
    {
        //Renderer라는 이름의 컴포넌트를 자식의 게임오브젝트에서 GetComponent
        SkinnedMeshRenderer renderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if(renderer != null)
        {
            renderer.material.shader = Shader.Find("Mobile/Diffuse");
        }
        //부모의 게임오브젝트에서 컴포넌트를 Get
        //SkinnedMeshRenderer renderer = GetComponentInParent<SkinnedMeshRenderer>();

        List<SkinnedMeshRenderer> resultList = new List<SkinnedMeshRenderer>();
        GetComponentsInChildren<SkinnedMeshRenderer>(resultList);
        foreach (SkinnedMeshRenderer one in resultList)
        {
            Debug.Log(one);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
