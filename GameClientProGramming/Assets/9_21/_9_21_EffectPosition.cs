using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_21_EffectPosition : MonoBehaviour
{
    GameObject rcRhandEffect;
    //string effectDummyPath = "TrollGiant/Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Neck/Bip001 R Clavicle/Bip001 R UpperArm/Bip001 R Forearm/Bip001 R Hand/HR/RHandEffect";
    Transform rHandDummy;
    public TrailRenderer swordEffect;
    void Start()
    {
        swordEffect.enabled = false;
        rcRhandEffect = Resources.Load<GameObject>("Effect/FireEffect");
        //GameObject.Find함수의 단점
        //활성화된 게임오브젝트만 검색
        //비황성화된 게임오브젝트일 경우는 Transform의 검색함수를 사용

        //rHandDummy = GameObject.Find(effectDummyPath).transform;
        rHandDummy = FindChildTransform("RHandEffect", transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject rhandEffect = Instantiate<GameObject>(rcRhandEffect, rHandDummy.position, Quaternion.identity, rHandDummy);
        }
    }
    
    public Transform FindChildTransform(string _nodeName, Transform _origin)
    {
        if (_origin.name == _nodeName)
            return _origin;
        for(int i =0; i< _origin.childCount; i++)
        {
            Transform findTr = FindChildTransform(_nodeName, _origin.GetChild(i));
            if (findTr != null)
                return findTr;
        }
        return null;
    }

    public void EffectOn()
    {
        swordEffect.enabled = true;
    }
    public void EffectOff()
    {
        swordEffect.enabled = false;
    }
}
