﻿using UnityEngine;
using System.Collections;

public class daegak1 : MonoBehaviour
{
	Rigidbody2D rigid;
	public float power = 400f;
	public GameObject ball;

	void OnCollisionEnter2D(Collision2D collision)
	{
		rigid = ball.GetComponent<Rigidbody2D>();
		rigid.AddForce(Vector2.down * power);// 아래쪽
	}
}