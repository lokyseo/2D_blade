using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject _Player;
    Transform _target;

    private float moveSpeed = 2.0f;
    private float rotateSpeed = 5.0f;
    private float maxHp;
    private float curHp;

    void Start()
    {
    }

    void Update()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (_Player != null)
        {
            Vector2 direction = new Vector2(
                transform.position.x - _target.position.x,
                transform.position.y - _target.position.y
            );

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion angleAxis = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
            Quaternion rotation = Quaternion.Slerp(transform.rotation, angleAxis, rotateSpeed * Time.deltaTime);
            this.transform.rotation = rotation;
        }

        this.transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * moveSpeed);


    }

   
}
