using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float power = 30f;
    public Rigidbody rigidbody;
    public GameObject gameOverText;
    public GameObject resetButton;
    public float speedLimit = 10.0f;
    float angleX = 0;
    float angleY = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // 上キーを押したら前に力を加える
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(transform.forward * power);
        }

        // 下キーを押したら後ろに力を加える
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(-transform.forward * power);
        }

        // 右キーを押したら右に力を加える
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(transform.right * power);
        }

        // 左キーを押したら左に力を加える
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-transform.right * power);
        }

        angleX += mouseX * 2.0f;
        //angleY += mouseY * 2.0f;
        if (angleY < -50) angleY = -50.0f;
        //if (angleY > 80) angleY = 80;

        gameObject.transform.rotation = Quaternion.Euler(-angleY, angleX, 0);

        // プレイヤーのY軸座標が一定の値まで下がったらゲームオーバー画面を出す
        if (gameObject.transform.position.y < -10)
        {
            gameOverText.SetActive(true);
            resetButton.SetActive(true);
        }

        // 速度制限
        if (rigidbody.velocity.magnitude > speedLimit)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * speedLimit;
        }
    }
}
