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
        //문자열 데이터를 바이트 배열로 변환하고 바이트 배열을 이용하여 파일에 저장
        string strData = "10,20,30,40";
        byte[] byData = Encoding.Default.GetBytes(strData);
        File.WriteAllBytes(Application.dataPath + "/" + "test.txt", byData);

        // 바이트 배열로 읽어서 문자열 변환하여 화면에 콘솔뷰에 출력
        byte[] readBytes = File.ReadAllBytes(Application.dataPath + "/" + "test.txt");
        string readString = Encoding.Default.GetString(readBytes);
        Debug.Log(readString);

        string message = " 100,200,300,400 ";
        string result = message.Trim();
        Debug.Log("Trim() 결과 = " + result);

        result = message.Replace(",", "_");
        Debug.Log("Replace() 결과 = " + result);

        string[] splitData = result.Split('_');
        Debug.Log(splitData[0]);
        Debug.Log(splitData[1]);
        Debug.Log(splitData[2]);
        Debug.Log(splitData[3]);

        //문자열을 정수로 변환하려면
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
