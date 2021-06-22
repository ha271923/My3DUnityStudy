using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime_Test : MonoBehaviour
{
    /*
     在Unity3D 官網上還有這樣的一句話：
        If you add or subtract to a value every frame chances are you should multiply with Time.deltaTime. 
        When you multiply with Time.deltaTime you essentially express: I want to move this object 10 meters per second instead of 10 meters per frame.
        意思大致爲，假如你想定義一個 Object 每秒移動 10 米而不是每幀移動 10 米。請在 10 的後面再乘上一個 DeltaTime，這樣就是變成了 10 m/s。


     */
    // Start is called before the first frame update
    void Start()
    {
        Time.fixedDeltaTime = 0.1f;
    }

    // Update is called once per frame
    private void Update() // 當FPS為2時，update打印的次數特別少，而當FPS改為60時，update打印的次數就明顯提高了很多, update跟當前平臺的FPS有關
    {
        // Debug.Log("Update   DeltaTime : " + Time.deltaTime);
    }

    private void FixedUpdate() // FixedUpdate是在固定的時間間隔執行，不受遊戲幀率的影響。Tick：在處理Rigidbody的時候最好用FixedUpdate。
    {
        // Debug.Log("FixedUpdate   DeltaTime : " + Time.deltaTime);
    }

    private void LateUpdate()
    {
        // Debug.Log("LateUpdate   DeltaTime : " + Time.deltaTime);
    }


}
