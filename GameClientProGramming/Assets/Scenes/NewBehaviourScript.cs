using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        byte[] byteArray= { 66, 85, 70, 70, 69, 82};
        string buffer = Encoding.Default.GetString(byteArray);
        Debug.Log(buffer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
