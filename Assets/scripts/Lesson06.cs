using UnityEngine;

public class Lesson06 : MonoBehaviour
{
    void Start()
    {
        //Vector3 vec = new Vector3(5, 0, 0); //벡터값
        //transform.Translate(vec);
        
    }
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0); //벡터값
        transform.Translate(vec);
        //if (Input.anyKeyDown)
        //        Debug.Log("플레이어가 아무 키를 눌렀습니다");
        //if (Input.anyKey)
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다");

        //if (Input.GetKeyDown(KeyCode.Return))
        //    Debug.Log("아이템을 구입하였습니다");

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //    Debug.Log("왼쪽으로 이동");

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //    Debug.Log("오른쪽 이동을 멈추었습니다");

        //if (Input.GetMouseButtonDown(0))
        //    Debug.Log("미사일 발사");

        //if (Input.GetMouseButton(0))
        //    Debug.Log("미사일 차징");

        //if (Input.GetMouseButtonUp(0))
        //    Debug.Log("슈퍼 울트라 메가 캡숑 미사일 발사");

        //if (Input.GetButtonDown("Jump"))
        //    Debug.Log("점프!");

        //if (Input.GetButton("Jump"))
        //    Debug.Log("점프 차징");

        //if (Input.GetButtonUp("Jump"))
        //    Debug.Log("슈퍼 점프!");

        //if (Input.GetButton("Horizontal"))
        //{
        //    Debug.Log("횡 이동중..."
        //        + Input.GetAxisRaw("Horizontal"));
        //}

        //if (Input.GetButton("Vertical"))
        //{
        //    Debug.Log("횡 이동중..."
        //        + Input.GetAxisRaw("Vertical"));
        //}
    }
}
