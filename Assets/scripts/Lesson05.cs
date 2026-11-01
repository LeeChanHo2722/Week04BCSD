using UnityEngine;

public class Lesson05 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 데이터를 생성");
    }

    void OnEnable()
    {
        Debug.Log("플레이어 로그인");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void FixedUpdate()
    {
        Debug.Log("이동");
    }

    void Update()
    {
        Debug.Log("몬스터 사냥");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    void OnDisable()
    {
        Debug.Log("플레이어 로그아웃");
    }

    void Ondestroy()
    {
        Debug.Log("플레이어 데이터를 해제");
    }
}
