using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//개인적으로 static을 활용할 때 object가 컴포넌트를 참조를 저장할 때 추천함
//정적변수란 클래스 내에 계속 유지되는 변수이다. 사람들은 정적변수보다 싱글턴을 선호하는 이유는 
//인스턴스를 많이한다면 singleton을 선호하기 때문이다. 하지만 싱글턴은 한번만 메모리를 할당하여 인스턴스를 여러번하는 것을 줄이는 것이 장점이라서 메모리 방지를 막을 수 있지만
// 너무 많이 사용하면 결합도가 높아진다( 소프트웨어가 잘 돌아가려면 결합도는 낮아야하고 응집도는 높아야한다. 
//그래서 이 부분은 Generic으로 활용하여 싱글턴을 이용하는 것이 좋음 -> 제너릭은 나중에..)
//암튼 static으로 정적 변수란 클랙스에 속해 있는 변수이고 클래스가  생성되는 객체에는 존재하지 않는다. 즉 같은 값을 유지한다. 즉 한번만 게임 오브젝트와
// 컴포넌트들의 참조를 얻으면 된다. Awake() 또는 Start()에서 종종 반복적으로 사용되는 게임 오브젝트나 컴포넌트를 참조할 떄 추천
//하지만 static의 단점은 메모리 낭비가 심하다 계속 클래스를 접근하여 인스턴스하기 때문에 이곳저곳 사용하기 때문이다.

//지역변수는 함수 내에서 선언된 변수로 그 함수에서만 접근이 가능하다. 


public class Static : MonoBehaviour
{
    public static Transform playertrs;
    void Start()
    {
        //플레이어 위치를 찾을 때 이럴 때 편리 
        playertrs = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

  
}
