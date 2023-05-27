using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextReading : MonoBehaviour
{
    void Start()
    {
        int speed;
        string b;
        b = speed * 0.8;
        FileStream test = new FileStream("C:/Users/CKIRUser/Downloads/memo.txt", FileMode.Create);

        StreamWriter testStreamWriter = new StreamWriter(test);
        testStreamWriter.Write("Stream Writer 테스트 중");
        testStreamWriter.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
