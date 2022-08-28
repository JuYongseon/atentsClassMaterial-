using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePick_8_1 : MonoBehaviour
{
    public GameObject obj1;
    Vector3 vEnd;

    private void Awake()
    {
        vEnd = obj1.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            int layerMask = 1 << 6;
            layerMask = ~layerMask;
            //Physics.Raycast(원점, 충돌 감지된것, 거리)
            //Mathf.Infinity 무한이라는 메서드
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerMask))
            {
                //광선이 충돌한 게임오브젝트의 태그 비교
                if (hitInfo.collider.CompareTag("Terrain"))
                {
                    Debug.Log("교차 된 게임오브젝트 이름 = " + hitInfo.collider.gameObject.name);
                    Debug.Log("교차 된 게임오브젝트 위치 = " + hitInfo.point);
                    vEnd = new Vector3(hitInfo.point.x, 1, hitInfo.point.z);
                }
            }
        }
        Debug.DrawLine(obj1.transform.position, vEnd, Color.red);
        obj1.transform.position = Vector3.MoveTowards(obj1.transform.position, vEnd, Time.deltaTime * 10f);
    }
}
