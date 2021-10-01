using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private bool isJump = false;
    private bool isFalling = false;
    private Vector3 start ;
    private Vector3 end; 
    private float temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")>0){
            this.transform.position += new Vector3(1f,0f,0f)* Time.deltaTime;
        }
        if(Input.GetAxis("Horizontal")<0){
            this.transform.position += new Vector3(-1f,0f,0f)* Time.deltaTime;
        }
        if(Input.GetAxis("Vertical")<0){
            this.transform.position += new Vector3(0f,0f,-1f)* Time.deltaTime;

        }
        if(Input.GetAxis("Vertical")>0){
            this.transform.position += new Vector3(0f,0f,1f)* Time.deltaTime;

        }
        
        
        if(Input.GetButton("Jump")){
            // isJump =true;
            // this.start = this.transform.position;
            // this.end = this.transform.position+ new Vector3(0f,2f,0f);
            // temp = 0;
             this.GetComponent<Rigidbody>().AddForce(new Vector3(0f,5f,0f));

        }
        
        // if (isJump)
        // {
        //     this.transform.position=Vector3.Lerp(this.start,this.end,temp);
        //     temp+=1f * Time.deltaTime;
        //     if (temp >=1f)
        //     {
        //         isJump=false;
        //         isFalling = true;
        //         this.start = this.transform.position;
        //         this.end = this.transform.position- new Vector3(0f,2f,0f);
        //         temp = 0f;
        //     }
        // }
        // if (isFalling)
        // {
        //     this.transform.position = Vector3.Lerp(this.start,this.end,temp);
        //     temp+=1f * Time.deltaTime;
        //     if (temp>=1f)
        //     {
        //         isFalling =false;
        //     }
        // }
        

    }
}
