using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Calculator : MonoBehaviour
{

    public Text TextField;

    void Start()
    {

    }

    public void AddCount(int count)
    {
        print(count);
    }
    public void Click(int number)
    {
        TextField.text += number;
    }

    public void Click2(string sing)
    {
        TextField.text += sing;
    }

    public void DeleteData()
    {
        TextField.text = "";
    }
}