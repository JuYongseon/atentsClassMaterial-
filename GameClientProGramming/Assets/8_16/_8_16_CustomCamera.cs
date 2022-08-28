using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_16_CustomCamera : MonoBehaviour
{
    public static _8_16_CustomCamera instance;
    _8_16_Player player;
    Vector3 oldPos;
    public _8_16_Player PLAYER
    {
        get { return player; }
        set { player = value; }
    }

    public Vector3 PLAYEPOS
    {
        get { return oldPos; }
        set { oldPos = value; }
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 delta = player.transform.position - oldPos;
        transform.position = transform.position + delta;
        oldPos = player.transform.position;
    }
}
