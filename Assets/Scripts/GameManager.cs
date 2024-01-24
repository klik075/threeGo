using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TimeManager I;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeEnemy()
    {
        //Instantiate(); //gameObject 복제
    }

    public void gameOver()
    {
        //게임종료 시 종료되었다고 화면이 팝업되어야 함

        //time 스케일 0으로 초기화
        I.EndTimer();
    }
}
