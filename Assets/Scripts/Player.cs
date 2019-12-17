using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
         private Rigidbody2D _rb2D;

        private void Start()
        {
            _rb2D = gameObject.GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            float move = Input.GetAxisRaw("Horizontal");
            _rb2D.velocity = new Vector2(move, _rb2D.velocity.y);
        }
    }
}