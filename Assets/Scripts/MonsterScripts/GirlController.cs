using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GirlController : MonsterController
{
    [SerializeField][Range(0f,100f)] private float followRange;
    [SerializeField] private string targetTag = "Player";//타겟의 태그
    [SerializeField]private SpriteRenderer characterRenderer;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        Vector2 direction = Vector2.zero;
        direction = DirectionToTarget();

        CallMoveEvent(direction); //움직이는 코드
        Rotate(direction);
    }
    private void Rotate(Vector2 direction) //스프라이트 돌리기
    {
        float rotZ = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
