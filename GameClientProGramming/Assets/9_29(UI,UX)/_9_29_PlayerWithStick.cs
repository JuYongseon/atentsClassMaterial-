using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_29_PlayerWithStick : MonoBehaviour
{
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = transform.position;
        tmp.x = tmp.x + _9_29_Stick_UI.instance.dir.normalized.x * Time.deltaTime * moveSpeed;
        tmp.y = tmp.y + _9_29_Stick_UI.instance.dir.normalized.y * Time.deltaTime * moveSpeed;
        tmp.z = tmp.z + _9_29_Stick_UI.instance.dir.normalized.z * Time.deltaTime * moveSpeed;
        transform.position = tmp;
    }
}
