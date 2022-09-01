using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class _8_29_DorectoryAndFile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string curDirectory = Directory.GetCurrentDirectory();
        Debug.Log("현재 디렉토리 = " + curDirectory);
        string[] subDirectroy = Directory.GetDirectories(curDirectory);
        foreach(string one in subDirectroy)
        {
            Debug.Log("하위 디렉토리 = " + one);
        }
        //재귀호출(Recursive) (자신의 함수 안에서 자신을 호출)
        //문제1) D드라이브의 모든 하위 디렐토리를 콘솔뷰에 출력
        //문제2) D드라이브의 모든 하위 디렉토리 이름을 파일에 저장
        //문제3) 프로젝트 폴더의 Assets 폴더내의 파일 이름을 모두 콘솔뷰에 출력
        //
        //
        //
        //문제1의 함수
        //GetSubDirInfo("D:\\");
        //문제2의 함수
        WriteSubDirectoryInfo(Application.dataPath + "/" + "DDriveFolderName.txt");
        //재귀호출예)
        //CountDisplay(0);
        //문제3의 프로그램 코드
        string [] files = Directory.GetFiles(Application.dataPath);
        foreach(string one in files)
        {
            Debug.Log(one);
        }
        //path클래스 사용 예제
        string name = Path.GetDirectoryName(Application.dataPath);
        Debug.Log(name);
        //여러 폴더를 Combine
        string[] dirnames = { "Lee", "Test", "cur", "Cur2"};
        string CombinePath = Path.Combine(dirnames);
        Debug.Log(CombinePath);
        // 문자 '/' 과 '\'이 섞여 있는 경우 하나의 문자로 동일하게 변경한다.
        string tmp = "가나다/라마바\\사아자";
        string replacedPath = tmp.Replace('\\', '/');
        Debug.Log(replacedPath);
    }

    public void GetSubDirInfo(string _dir)
    {
        string[] subDirectory = Directory.GetDirectories(_dir);
        foreach(string one in subDirectory)
        {
            Debug.Log(one);
            GetSubDirInfo(one);
        }
    }
    public void WriteSubDirectoryInfo(string _path)
    {
        using (StreamWriter sr = new StreamWriter(_path))
        {
            WriteSubDirInfo("D:\\", sr);
            sr.Close();
        }
    }

    public void WriteSubDirInfo(string _dir, StreamWriter _sr)
    {
        string[] subDirectory = Directory.GetDirectories(_dir);
        foreach (string one in subDirectory)
        {
            _sr.WriteLine(one);
            WriteSubDirInfo(one, _sr);
        }
    }

    //재귀호출 함수 예
    public void CountDisplay(int _count)
    {
        Debug.Log("_count = " + _count);
        if(_count == 10)
        {
            return;
        }
        CountDisplay(++_count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
