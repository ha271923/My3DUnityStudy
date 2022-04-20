using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoLifeCycle : MonoBehaviour
{
    static int currentFrameCount = 1;
    static int MAX_FRAME = 10;

    void Awake()
    {
        Debug.Log("Awake");
        Invoke("testInvoke", 0.01f); // call testInvoke() after Update() called.
        StartCoroutine(testCoroutine()); // call testCoroutine() immediately, not after Update().
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFrameCount < MAX_FRAME)
        {
            Debug.Log("Update  "+ currentFrameCount);
            currentFrameCount++;
        }
    }

    private void testInvoke()
    {
        Debug.Log("testInvoke");
    }

    private IEnumerator testCoroutine()
    {
        // not at Update()
        Debug.Log("testCoroutine");
        // Update() Frame 1
        yield return null; // 這一幀到此暫停，下一幀再從暫停處繼續，常用於循環中。
        Debug.Log("testCoroutine   yield return null");
        // Update() Frame 2
        yield return 1; // 這一幀到此暫停，下一幀再從暫停處繼續。這裡return什麼都是等一幀，後面的返回值沒有特殊意義。所以返回0或1或100都是一樣的。參考：
        Debug.Log("testCoroutine   yield return 1");
        yield return new WaitForEndOfFrame(); // 等到這一幀的cameras和GUI渲染結束後再從此處繼續，即等到這幀的末尾再往下運行。這行之後的代碼還是在當前幀運行，是在下一幀開始前執行，跟return null很相似。
        Debug.Log("testCoroutine   yield return new WaitForEndOfFrame()");
        yield return new WaitForFixedUpdate(); // 在下一次執行FixedUpdate的時候繼續執行這段代碼，即等一次物理引擎的更新。
        Debug.Log("testCoroutine   yield return new WaitForFixedUpdate()");
        // yield return www; // 等待直至異步下載完成。
        Debug.Log("testCoroutine   StartCoroutine(testCoroutine2()++");
        yield return StartCoroutine(testCoroutine2()); // 等待另一個協程執行完。這是把協程串聯起來的關鍵，常用於讓多個協程按順序逐個運行。
        Debug.Log("testCoroutine   yield return new WaitForSeconds(3.0f)++");
        // Update() Frame ? after 3sec
        yield return new WaitForSeconds(3.0f); // 等待3秒，然後繼續從此處開始，常用於做定時器。
        Debug.Log("testCoroutine   yield return new WaitForSeconds(3.0f)--");
        yield break; // 直接跳出協程，對某些判定失敗必須跳出的時候，比如加載AssetBundle的時候，WWW失敗了，後邊加載bundle沒有必要了，這時候可以yield break跳出。
        Debug.Log("testCoroutine   yield break");

    }

    private IEnumerator testCoroutine2()
    {
        Debug.Log("testCoroutine2--");
        yield break;
    }
}
