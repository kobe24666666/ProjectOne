using UnityEngine;
using System.Collections;

public class TimeTest : MonoBehaviour {

	//Time常用的一些常用变量
    private void Update1()
    {
        //print(Time.time);//表示游戏开始时候，截止目前运行的游戏时间
        //print(Time.deltaTime);//在Update中完成上一帧所消耗的时间 0.02s  
        //Time.deltaTime:按照秒来计算的，完成最后一帧的时间，(只读)，使用了这个函数
        //产生于游戏速率无关的效果
        //print(Time.fixedTime);//方法中固定消耗的时间总和， 
        print(Time.fixedTime);//固定更新上一帧所消耗的时间
    }

    //Time.time倒计时
    //private float nexttime;
    //private float second = 4f;
    //public void Update2()
    //{
    //    if(Time.time > nexttime +1)
    //    {
    //        nexttime = Time.time;
    //        //需要指定的功能
    //        second--;
    //        print(second);
    //    }
    //}

    //Time.deltaTime倒计时
    private float nexttime = 6f;
    public void Update()
    {
        nexttime -= Time.deltaTime;
        if(nexttime <=0)
        {           
            //需要你指定的代码
        }
        print((int)nexttime);
    }
}
