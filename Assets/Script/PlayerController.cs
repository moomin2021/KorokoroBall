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

        // ��L�[����������O�ɗ͂�������
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(transform.forward * power);
        }

        // ���L�[������������ɗ͂�������
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(-transform.forward * power);
        }

        // �E�L�[����������E�ɗ͂�������
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(transform.right * power);
        }

        // ���L�[���������獶�ɗ͂�������
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(-transform.right * power);
        }

        angleX += mouseX * 2.0f;
        //angleY += mouseY * 2.0f;
        if (angleY < -50) angleY = -50.0f;
        //if (angleY > 80) angleY = 80;

        gameObject.transform.rotation = Quaternion.Euler(-angleY, angleX, 0);

        // �v���C���[��Y�����W�����̒l�܂ŉ���������Q�[���I�[�o�[��ʂ��o��
        if (gameObject.transform.position.y < -10)
        {
            gameOverText.SetActive(true);
            resetButton.SetActive(true);
        }

        // ���x����
        if (rigidbody.velocity.magnitude > speedLimit)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * speedLimit;
        }
    }
}
