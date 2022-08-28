using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.IO;


public class _8_25_Menu
{
    [MenuItem("Export/SceneData_8_25")]
    static void ExportSceneData_8_25()
    {
        Scene curScene = SceneManager.GetActiveScene();
        Debug.Log("ExportSceneData = " + curScene.name);
        string path = Application.dataPath + "/" + curScene.name + ".csv";
        using (StreamWriter sr = new StreamWriter(path))
        {
            string line = string.Empty;
            line = "name, positonX, positonX, positonX";
            sr.WriteLine(line);

            //���� �÷��� Monster��� �±׸� �˻��Ѵ�.
            GameObject[] findObjs = GameObject.FindGameObjectsWithTag("Monster");
            foreach (GameObject one in findObjs)
            {
                line = string.Empty;
                line = one.name;
                line += ",";
                line += one.transform.position.x;
                line += ",";
                line += one.transform.position.y;
                line += ",";
                line += one.transform.position.z;
                sr.WriteLine(line);
            }
            sr.Close();
        }
    }

    //������ ���ҽ��� ����� �о���� ���
    [MenuItem("Import/SceneData_8_25")]
    static void ImportSceneData_8_25()
    {
        string path = EditorUtility.OpenFilePanel("Open SceneData", Application.dataPath, "csv");
        using (StreamReader sr = new StreamReader(path))
        {
            string line = string.Empty;
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                string[] datas = line.Split(',');
                Debug.Log("*****�� ������******");
                Debug.Log("ù���������� = " + datas[0]);
                Debug.Log("�ι��������� = " + datas[1]);
                Debug.Log("������������ = " + datas[2]);
                Debug.Log("�׹��������� = " + datas[3]);
                float xPos = float.Parse(datas[1]);
                float yPos = float.Parse(datas[2]);
                float zPos = float.Parse(datas[3]);
                Vector3 pos = new Vector3(xPos, yPos, zPos);
                //��ʸ� ǥ��
                //GameObject tmpRc = Resources.Load<GameObject>(datas[0]);
                // ����ȯ ǥ��
                //GameObject tmpRc = (GameObject)Resources.Load(datas[0]);
                //����ȯ ǥ��
                GameObject tmpRc = Resources.Load("8_24_Resources/" + datas[0]) as GameObject;
                GameObject obj = GameObject.Instantiate<GameObject>(tmpRc);
                obj.name = datas[0];
                obj.transform.position = pos;
            }
            sr.Close();
        }
    }
}
