using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_7_ShaderFind : MonoBehaviour
{
    // ���̴��� �ǽð� ��ü �ϴ� ���α׷� �ڵ� �ۼ�
    void Start()
    {
        //Renderer��� �̸��� ������Ʈ�� �ڽ��� ���ӿ�����Ʈ���� GetComponent
        SkinnedMeshRenderer renderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if(renderer != null)
        {
            renderer.material.shader = Shader.Find("Mobile/Diffuse");
        }
        //�θ��� ���ӿ�����Ʈ���� ������Ʈ�� Get
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
