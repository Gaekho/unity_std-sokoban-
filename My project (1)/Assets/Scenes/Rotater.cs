using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{   

    // public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(60, 60, 60);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60 * Time.deltaTime, 60*Time.deltaTime, 60*Time.deltaTime);
    }
}



// 60fps => 1초에 60번
// 1fps => 1/60초 즉 Time.deltaTime은 이 마지막 프레임부터 현재 프레임까지의 시간 간격을 의미하는 변수이다. 당연히 단위는 초로 표시될 것. 시간 간격이라는 말 그대로 해석하면 되겠네. 
// 위 코드에선 사실상 1프레임에 1도, 60프레임이면 1초에 60도이다.