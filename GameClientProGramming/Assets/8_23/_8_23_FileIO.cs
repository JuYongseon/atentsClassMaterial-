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

    //�Լ�1
    public void WriteData(string _filename)
    {
        //Application.dataPath : ������Ʈ�� Assets���� ����
        //"/test.txt"������� ���� ������ �پ�� ������ �ؿ� ��
        //string path = Application.dataPath + "/test.txt";
        //string path = Application.dataPath + "/" + "test.txt";
        string path = Application.dataPath + "/" + _filename;
        //���1
        //����¿� ���Ե� Ŭ����
        /*
        StreamWriter sr = new StreamWriter(path);
        sr.WriteLine("�ȳ��ϼ���");
        sr.Close();
        */
        //���2
        //using�������� ������ ������ �ν��Ͻ��� ������ �ݷ��Ϳ� ���ؼ� �������� �ʰ� �ٷ� ���� �ȴ�.
        //�ַ� �ѹ� ����ϰ� ������ �ʿ���� �ν��Ͻ��� using �������� �ν��Ͻ��� �����Ѵ�.
        //StreamWriter(path)������Ƽ�� ������ �ʱ�ȭ �ǰ� ���� ���� ���븸 ��.
        //StreamWriter(path, true)������Ƽ�� ������ ���뿡�� �� ������ �߰�
        using (StreamWriter sr = new StreamWriter(path, true))
        {
            sr.WriteLine("�ȳ��ϼ���");
            sr.WriteLine("�ֿ뼱");
            sr.Write("����");
            sr.Write("�ٶ�");
            sr.WriteLine("");
            sr.Close();
        }
    }
    
    public void ReadData(string _filename)
    {
        string path = Application.dataPath + "/" + _filename;
        using(StreamReader sr = new StreamReader(path))
        {
            Debug.Log("*****���� ������******");
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
