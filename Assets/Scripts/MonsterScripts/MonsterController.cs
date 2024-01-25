using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class MonsterController : CharacterController
{
    GameManager gameManager; //게임 매니저
    protected Transform ClosetTarget {get; private set;}
    // Start is called before the first frame update
    protected virtual void Start()
    {
        gameManager = GameManager.instance; //게임 매니저 참조
        ClosetTarget = gameManager.Player; //플레이어의 위치를 게임 매니저로 가져옴
    }

    // Update is called once per frame
    protected override void FixedUpdate() 
    {
        base.FixedUpdate();
    }
    protected float DistanceToTarget() //몬스터와 플레이어의 거리
    {
        return Vector3.Distance(transform.position,ClosetTarget.position);
    }
    protected Vector2 DirectionToTarget() //몬스터 위치에서 플레이어 위치를 향한 단위벡터
    {
        return (ClosetTarget.position - transform.position).normalized;
    }
}
