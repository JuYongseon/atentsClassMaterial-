using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_6_Text : MonoBehaviour
{
    public Text scoreText;
    string converSation;
    // Start is called before the first frame update
    void Start()
    {
        //컬러만 적용이 가능!
        //scoreText.text = "마을에서 <color=#ff0000>고블린</color>을 퇴치해주세요";
        converSation = "마을에서 고블린을 퇴치해주세요";
        scoreText.text = string.Empty;
        char[] arrayObj = converSation.ToCharArray();
        StartCoroutine(DisplayConverSation(arrayObj));
    }

    IEnumerator DisplayConverSation(char[] _arrObj)
    {
        string[] tmp = { "<color=#ff5502>강</color>", "<color=#ff5502>지</color>" };
        for (int i =0; i < tmp.Length; i++)
        {
            scoreText.text += tmp[i];
            yield return new WaitForSeconds(0.2f);
        }

        /*for (int i =0; i <_arrObj.Length; i++)
        {
            scoreText.text += _arrObj[i];
            yield return new WaitForSeconds(0.2f);
            scoreText.text += tmp[0];
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
