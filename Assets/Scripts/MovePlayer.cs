﻿
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    private Animator anim;
    [SerializeField]
    private float speed = 10f;
    private void OnMouseDrag()
    {
        if (!Player.lost)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
            anim.SetInteger("State", 1);
        }
        anim.SetInteger("State", 3);
    }
}
