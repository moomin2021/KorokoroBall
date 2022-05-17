using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float power = 10.0f;
    public Rigidbody rigidbody;
    public GameObject gameOverText;
    public GameObject resetButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 上キーを押したら前に力を加える
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }

        // 下キーを押したら後ろに力を加える
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }

        // 右キーを押したら右に力を加える
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        // 左キーを押したら左に力を加える
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }

        if (gameObject.transform.position.y < -10)
        {
            gameOverText.SetActive(true);
            resetButton.SetActive(true);
        }
    }
}
