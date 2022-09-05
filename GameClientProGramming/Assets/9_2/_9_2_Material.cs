using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_2_Material : MonoBehaviour
{
    public GameObject Cube;
    Texture2D rcTexture;
    Texture2D rcSword;
    MeshRenderer MeshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rcTexture = Resources.Load<Texture2D>("9_2_Material/TrollGiant");
        rcSword = Resources.Load<Texture2D>("9_2_Material/atlas-albedo-LPUP");
        MeshRenderer = Cube.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            MeshRenderer.material.SetTexture("_MainTex", rcTexture);
            //MeshRenderer.material.mainTexture = rcTexture;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            //MeshRenderer.material.SetTexture("_MainTex", rcSword);
            MeshRenderer.material.mainTexture = rcSword;
        }
        //텍스처의 offset을 변경
        Vector2 textureOffset = MeshRenderer.material.mainTextureOffset;
        textureOffset.x += Time.deltaTime;
        MeshRenderer.material.mainTextureOffset = textureOffset;

    }
}
