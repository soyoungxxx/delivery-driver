using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 카메라의 위치 = 차의 위치가 돼야 한다
    // 매 프레임마다 일어나야 하기 때문에 start 필요 x

    [SerializeField] GameObject thingToFollow;
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
