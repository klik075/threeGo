using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager timeIns;
    public bool timeStop = true;

    public float timeGoing;

    private void Awake()
    {
        timeIns = this;//�̱���ȭ
        Time.timeScale = 0.0f;//timer ���� ���� ���ϵ��� ����
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(timeStop == false)
        {
            timeGoing += Time.deltaTime;
        }
    }

    public void StopTimer()
    {
        timeStop = true;
    }

    public void StartTimer()
    {
        timeStop = false;
        Time.timeScale = 1f;
    }

    public void EndTimer()
    {
        Time.timeScale = 0.0f;
    }
}
