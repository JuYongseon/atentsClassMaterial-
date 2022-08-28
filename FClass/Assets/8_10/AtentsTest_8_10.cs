using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtentsTest_8_10 : MonoBehaviour
{
    public GameObject camera;
    public float moveSpeed;
    float rotateSpeed;
    Vector3 hitEnd;
    Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = new Vector3(0,4,-7);
        hitEnd = transform.position;
        rotateSpeed = 5f;
        moveSpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.collider.CompareTag("Terrain"))
                {
                    hitEnd = hitInfo.point;
                }

                if (hitInfo.collider.CompareTag("Player"))
                {
                    Debug.Log(transform.name);
                }
            }
        }
        Vector3 newDir = Vector3.RotateTowards(transform.forward, hitEnd.normalized, Time.deltaTime * rotateSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);
        transform.position = Vector3.MoveTowards(transform.position, hitEnd, Time.deltaTime * moveSpeed);
        camera.transform.position = Vector3.MoveTowards(camera.transform.position, cameraPosition - hitEnd, Time.deltaTime * moveSpeed); ;
        
    }
}
