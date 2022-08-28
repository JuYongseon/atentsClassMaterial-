using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class _8_23_FileIO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WriteData("test.txt");
    }

    //함수1
    public void WriteData(string _filename)
    {
        //Application.dataPath : 프로젝트의 Assets폴더 까지
        //"/test.txt"방법으로 말고 저렇게 뛰어쓰는 이유는 밑에 함
        //string path = Application.dataPath + "/test.txt";
        //string path = Application.dataPath + "/" + "test.txt";
        string path = Application.dataPath + "/" + _filename;
        //방법1
        //입출력에 포함된 클래스
        /*
        StreamWriter sr = new StreamWriter(path);
        sr.WriteLine("안녕하세요");
        sr.Close();
        */
        //방법2
        //using구문에서 생성한 참조형 인스턴스는 가비지 콜렉터에 의해서 관리되지 않고 바로 삭제 된다.
        //주로 한번 사용하고 참조가 필요없는 인스턴스는 using 구문에서 인스턴스를 생성한다.
        //StreamWriter(path)프로퍼티는 내용을 초기화 되고 내가 넣은 내용만 들어감.
        //StreamWriter(path, true)프로퍼티는 기존의 내용에서 내 내용을 추가
        using (StreamWriter sr = new StreamWriter(path, true))
        {
            sr.WriteLine("안녕하세요");
            sr.WriteLine("주용선");
            sr.Write("가나");
            sr.Write("다라");
            sr.WriteLine("");
            sr.Close();
        }
    }
    
    public void ReadData(string _filename)
    {
        string path = Application.dataPath + "/" + _filename;
        using(StreamReader sr = new StreamReader(path))
        {
            Debug.Log("*****읽은 데이터******");
            string line = string.Empty;
            while((line = sr.ReadLine()) != null)
            {
                Debug.Log(line);
            }
            sr.Close();
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
