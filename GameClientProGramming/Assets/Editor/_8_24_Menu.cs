using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.IO;


public class _8_24_Menu
{
    //[]애트리뷰트 유니티 에디터 상에 사용자 메뉴가 생성
    [MenuItem("Save/Monster")]
    static void SaveMonster()
    {
        Debug.Log("SaveMonster");
    }
    
    
    //파일에 정보 입력하는 방법
    [MenuItem("Export/SceneData")]
    static void ExportSceneData()
    {
        Scene curScene = SceneManager.GetActiveScene();
        Debug.Log("ExportSceneData = " + curScene.name);
        string path = Application.dataPath + "/" + curScene.name + ".csv";
        using (StreamWriter sr = new StreamWriter(path))
        {
            string line = string.Empty;
            line = "name, positonX, positonX, positonX";
            sr.WriteLine(line);

            //씬에 올려진 Monster라는 태그를 검색한다.
            GameObject[] findObjs = GameObject.FindGameObjectsWithTag("Monster");
            foreach(GameObject one in findObjs)
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

    //파일 읽어오는 방법1
    [MenuItem("Import/SceneData")]
    static void ImportSceneData()
    {
        Scene curScene = SceneManager.GetActiveScene();
        string path = Application.dataPath + "/" + curScene.name + ".csv";
        using(StreamReader sr = new StreamReader(path))
        {
            string line = string.Empty;
            line = sr.ReadLine();
            while((line = sr.ReadLine()) != null)
            {
                string[] datas = line.Split(',');
                Debug.Log("*****줄 데이터******");
                Debug.Log("첫번쨰데이터 = " + datas[0]);
                Debug.Log("두번쨰데이터 = " + datas[1]);
                Debug.Log("세번쨰데이터 = " + datas[2]);
                Debug.Log("네번쨰데이터 = " + datas[3]);
                float xPos = float.Parse(datas[1]);
                float yPos = float.Parse(datas[2]);
                float zPos = float.Parse(datas[3]);
                Vector3 pos = new Vector3(xPos, yPos, zPos);
            }
            sr.Close();
        }
    }

    //파일을 선택하여 읽어오는 방법
    [MenuItem("Import/SceneData1")]
    static void ImportSceneData1()
    {
        string path = EditorUtility.OpenFilePanel("Open SceneData", Application.dataPath, "csv");
        using (StreamReader sr = new StreamReader(path))
        {
            string line = string.Empty;
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                string[] datas = line.Split(',');
                Debug.Log("*****줄 데이터******");
                Debug.Log("첫번쨰데이터 = " + datas[0]);
                Debug.Log("두번쨰데이터 = " + datas[1]);
                Debug.Log("세번쨰데이터 = " + datas[2]);
                Debug.Log("네번쨰데이터 = " + datas[3]);
                float xPos = float.Parse(datas[1]);
                float yPos = float.Parse(datas[2]);
                float zPos = float.Parse(datas[3]);
                Vector3 pos = new Vector3(xPos, yPos, zPos);
            }
            sr.Close();
        }
    }

    //파일을 리소스로 만들어 읽어오는 방법
    [MenuItem("Import/SceneData2")]
    static void ImportSceneData2()
    {
        string path = EditorUtility.OpenFilePanel("Open SceneData", Application.dataPath, "csv");
        using (StreamReader sr = new StreamReader(path))
        {
            string line = string.Empty;
            line = sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                string[] datas = line.Split(',');
                Debug.Log("*****줄 데이터******");
                Debug.Log("첫번쨰데이터 = " + datas[0]);
                Debug.Log("두번쨰데이터 = " + datas[1]);
                Debug.Log("세번쨰데이터 = " + datas[2]);
                Debug.Log("네번쨰데이터 = " + datas[3]);
                float xPos = float.Parse(datas[1]);
                float yPos = float.Parse(datas[2]);
                float zPos = float.Parse(datas[3]);
                Vector3 pos = new Vector3(xPos, yPos, zPos);
                //재너릭 표현
                //GameObject tmpRc = Resources.Load<GameObject>(datas[0]);
                // 형변환 표현
                //GameObject tmpRc = (GameObject)Resources.Load(datas[0]);
                //형변환 표현
                GameObject tmpRc = Resources.Load("8_24_Resources/"+datas[0]) as GameObject;
                GameObject obj = GameObject.Instantiate<GameObject>(tmpRc);
                obj.name = datas[0];
                obj.transform.position = pos;
            }
            sr.Close();
        }
    }
}
