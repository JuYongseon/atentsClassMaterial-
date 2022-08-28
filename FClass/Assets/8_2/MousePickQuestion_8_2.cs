using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePickQuestion_8_2 : MonoBehaviour
{
    List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<GameObject>();
        for (int i = 0; i< 10; i++)
        {
            GameObject tmp = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tmp.name = "Monster_" + (i + 1).ToString();
            Vector3 objPos = new Vector3(Random.Range(-8,8), Random.Range(-5, 5), Random.Range(0, 5));
            tmp.transform.position = objPos;
            list.Add(tmp);
        }

        GameObject findObj = FindMonster("Monster_3");
        if (findObj != null)
            findObj.SetActive(false);
    }

    public GameObject FindMonster(string _name)
    {
        //���ٸ� �̿��� ����Ʈ ���� ���ӿ�����Ʈ �˻�
        //GameObject obj = list.Find(o => (o.name.Equals(_name)));

        //�ݺ����� ����� ����Ʈ���� ���ӿ�����Ʈ �˻�
        foreach(GameObject one in list)
        {
            if (one.name.Equals(_name))
            {
                return one;
            }
        }
        return null;
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
                if (hitInfo.collider.CompareTag("Monster"))
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }
}
