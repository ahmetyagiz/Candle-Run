using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour //Delegate i�ine fonksiyon tutabilen yap�lard�r.
{
    public delegate void DelegateDebug();//Tan�mlama

    public DelegateDebug delegateDebug; //Obje olu�turma

    void Start()
    {
        //delegateDebug += Debug2; //Delegate i�erisine fonksiyon ekleyebiliriz.
        //delegateDebug -= Debug2; //Delegate i�erisinden fonksiyon ��kartabiliriz.
        
        AddMethod(Debug1); //Ekleme i�lemini method �zerinden de yapabiliriz
        RemoveMethod(Debug2); //��karma i�lemini method �zerinden de yapabiliriz

        if (delegateDebug != null) //Nullcheck yapmazsak i�i bo� oldu�u i�in hata verir
        {
            delegateDebug();
        }
    }

    private void Debug1()
    {
        Debug.Log("Debug 1");
    }

    private void Debug2()
    {
        Debug.Log("Debug 2");
    }

    public void AddMethod(DelegateDebug method)
    {
        delegateDebug += method;
    }

    public void RemoveMethod(DelegateDebug method)
    {
        delegateDebug -= method;
    }
}
