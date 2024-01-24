using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class GameManager : MonoBehaviour
{

    public TimeManager timeIn;
    public static GameManager I;
    
    //public GameObject Player;
    //public GameObject Enemy;
    //public GameObject Prefab_Attack;
    
    
    
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
        timeIn.EndTimer();
    }

    // 충돌 알고리즘 다만 이 부분에 대해서 gameobject의 cs 파일에 넣는것 이 바람직하다
    void OnTriggerEnter2D(Collider2D coll)
    {
        
    }
}
