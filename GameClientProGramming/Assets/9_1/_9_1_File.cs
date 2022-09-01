using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class _9_1_File : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���ڿ� �����͸� ����Ʈ �迭�� ��ȯ�ϰ� ����Ʈ �迭�� �̿��Ͽ� ���Ͽ� ����
        string strData = "10,20,30,40";
        byte[] byData = Encoding.Default.GetBytes(strData);
        File.WriteAllBytes(Application.dataPath + "/" + "test.txt", byData);

        // ����Ʈ �迭�� �о ���ڿ� ��ȯ�Ͽ� ȭ�鿡 �ֺܼ信 ���
        byte[] readBytes = File.ReadAllBytes(Application.dataPath + "/" + "test.txt");
        string readString = Encoding.Default.GetString(readBytes);
        Debug.Log(readString);

        string message = " 100,200,300,400 ";
        string result = message.Trim();
        Debug.Log("Trim() ��� = " + result);

        result = message.Replace(",", "_");
        Debug.Log("Replace() ��� = " + result);

        string[] splitData = result.Split('_');
        Debug.Log(splitData[0]);
        Debug.Log(splitData[1]);
        Debug.Log(splitData[2]);
        Debug.Log(splitData[3]);

        //���ڿ��� ������ ��ȯ�Ϸ���
        int outResult;
        if(int.TryParse(splitData[0], out outResult))
        {
            Debug.Log(outResult);
        }

        int charPos = result.IndexOf("_");
        string subResult = result.Substring(charPos);
        Debug.Log(subResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
