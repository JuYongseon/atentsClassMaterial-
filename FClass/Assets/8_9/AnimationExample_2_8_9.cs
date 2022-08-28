using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample_2_8_9 : MonoBehaviour
{
    Vector3 end;
    float moveSpeed;
    public float MOVESPEED
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }
    public Vector3 END
    {
        get { return end; }
        set { end = value; }
    }
    private void Awake()
    {
        moveSpeed = 1.5f;
        end = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(transform.position);
    }
    public void OnButtonClick()
    {
        Debug.Log("OnButtonClick »£√‚");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo,Mathf.Infinity))
            {
                if (hitInfo.collider.CompareTag("Terrain"))
                {
                    end = hitInfo.point;
                }
            }
        }
    }
}
