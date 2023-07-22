using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

/**************************************************
* 类 名 称 ：
* 类 描 述 ：
* 作    者 ：
* 创建时间 ：
* 更新时间 ：
* 版 本 号 ：v1.0.0
**************************************************/

public class YTimeCtrl : MonoBehaviour
{
    private int year;
    private int month;
    private int day;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        year = DateTime.Now.Year;
        month = DateTime.Now.Month;
        day = DateTime.Now.Day;

        DateTime dateLast = new DateTime(2022, 12, 9);
        int c = DateTime.Compare(DateTime.Now, dateLast);
        if(c>0)
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }
}
