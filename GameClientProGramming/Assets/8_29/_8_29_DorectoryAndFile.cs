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
        Debug.Log("���� ���丮 = " + curDirectory);
        string[] subDirectroy = Directory.GetDirectories(curDirectory);
        foreach(string one in subDirectroy)
        {
            Debug.Log("���� ���丮 = " + one);
        }
        //���ȣ��(Recursive) (�ڽ��� �Լ� �ȿ��� �ڽ��� ȣ��)
        //����1) D����̺��� ��� ���� ���丮�� �ֺܼ信 ���
        //����2) D����̺��� ��� ���� ���丮 �̸��� ���Ͽ� ����
        //����3) ������Ʈ ������ Assets �������� ���� �̸��� ��� �ֺܼ信 ���
        //
        //
        //
        //����1�� �Լ�
        //GetSubDirInfo("D:\\");
        //����2�� �Լ�
        WriteSubDirectoryInfo(Application.dataPath + "/" + "DDriveFolderName.txt");
        //���ȣ�⿹)
        //CountDisplay(0);
        //����3�� ���α׷� �ڵ�
        string [] files = Directory.GetFiles(Application.dataPath);
        foreach(string one in files)
        {
            Debug.Log(one);
        }
        //pathŬ���� ��� ����
        string name = Path.GetDirectoryName(Application.dataPath);
        Debug.Log(name);
        //���� ������ Combine
        string[] dirnames = { "Lee", "Test", "cur", "Cur2"};
        string CombinePath = Path.Combine(dirnames);
        Debug.Log(CombinePath);
        // ���� '/' �� '\'�� ���� �ִ� ��� �ϳ��� ���ڷ� �����ϰ� �����Ѵ�.
        string tmp = "������/�󸶹�\\�����";
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

    //���ȣ�� �Լ� ��
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
