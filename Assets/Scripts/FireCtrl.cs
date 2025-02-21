using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet; //총알

    public Transform firePos; //총알 발사 좌표


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.red,1000); //카메라의 position, 방향 위치로 Ray 그림

        RaycastHit temp;

        if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out temp)) // 충돌이 검출되면 총알의 리스폰포인트(firePos)가 충돌이 발생한위치를 바라 봄.
                                                                                                         
        {
            firePos.LookAt(temp.point);
            Debug.DrawRay(firePos.position, firePos.forward, Color.cyan,1000);
            if (Input.GetMouseButtonDown(0)) //발사입력 시 총알은 충돌점으로 날아감
            {
                Fire();
            }
        }

        else
        {
            if (Input.GetMouseButtonDown(0)) //발사입력 시 총알은 충돌점으로 날아감
            {
                print("공중을 향해서는 총알을 발사할 수 없다.");
            }
            
        }

        /*
        else
        {
            Debug.DrawRay(firePos.position, firePos.forward, Color.blue,1000);
            firePos.LookAt(Camera.main.transform.position, Camera.main.transform.forward);
        }
        */


        /*
        if (Input.GetMouseButtonDown(0)) //발사입력 시 총알은 충돌점으로 날아감
        {
            Fire();
        }
        */

    }

    void Fire()
    {
        //Instantiate(bullet, firePos.position, firePos.rotation); //bullet 프리팹 생성
        //

        Instantiate(bullet, firePos.position, firePos.rotation); //bullet 프리팹 생성

    }

    
}
