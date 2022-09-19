using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_14ShaderFind : MonoBehaviour
{
    SkinnedMeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        SkinnedMeshRenderer renderer = transform.GetComponentInChildren<SkinnedMeshRenderer>();
        if (renderer != null)
        {
            //SharedMaterial老 版快客 aeterial老 版快甫 厚背
            //renderer.material.shader = Shader.Find("Mobile/Diffuse");
            renderer.sharedMaterial.shader = Shader.Find("Mobile/Diffuse");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
