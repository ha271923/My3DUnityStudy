using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class DateTimeUtils
    {
        static public void showDateTime() {
            Debug.Log(System.DateTime.Now);        // 当前本地时间 (年月日时分秒) -- 10/4/2018 9:38:19 PM
            Debug.Log(System.DateTime.UtcNow);     // 当前世界时间 (年月日时分秒) -- 10/4/2018 1:38:19 PM
            Debug.Log(System.DateTime.Now.Year);   // 当前时间 (年)
            Debug.Log(System.DateTime.Now.Month);  // 当前时间 (月)
            Debug.Log(System.DateTime.Now.Day);    // 当前时间 (日)
            Debug.Log(System.DateTime.Now.Hour);   // 当前时间 (时)
            Debug.Log(System.DateTime.Now.Minute); // 当前时间 (分)
            Debug.Log(System.DateTime.Now.Second); // 当前时间 (秒)
        }

        static public void convertDateTimeToString() {
            DateTime date1 = new DateTime();                    //    1/1/0001 12:00:00 AM —— 默认构造函数
            DateTime date2 = new DateTime(2008, 6, 6, 6, 6, 6); //    6/6/2008 6:06:06 AM —— 初始化 年、月、日、时、分、秒
            Debug.Log(date2.ToString("yyyyMMddHH:mm:ss"));          //    2008060606:06:06 
            Debug.Log(date2.ToString("yyyy-MM-dd★HH→mm☆ss"));     //    2008-06-06★06→06☆06 —— DateTime.ToString(String)使用自定义方式格式化日期字符串
        }

        static public void formatDateTime()
        {
            string iso8601String1 = "20080606T06:06:06Z";                                                                                          //    字符串中包含 T 、Z
            DateTime date1ISO8602 = DateTime.ParseExact(iso8601String1, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.CurrentCulture);    //    字符串带 T、Z：将字符串转为 DateTime 类型，时间是协调世界时间
            Debug.Log(string.Format("{0} --> {1:g}", iso8601String1, date1ISO8602));                                                               //    20080606T06:06:06Z --> 6/6/2008 2:06 PM
            string iso8601String2 = "2008-06-06-06:06:06";                                                                                         //    字符串中 不包含 T 、Z
            DateTime date2ISO8602 = DateTime.ParseExact(iso8601String2, "yyyy-MM-dd-HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture); //    将固定格式的字符串格式化，并转为 DateTime 类型 时间是本地时间
            Debug.Log(string.Format("{0} --> {1:g}", iso8601String2, date2ISO8602));                                                               //    2008-06-06-06:06:06 --> 6/6/2008 6:06 AM
            string iso8601String3 = "2008";                                                                                                        //    字符串中 只有年份
            DateTime date2ISO8603 = DateTime.ParseExact(iso8601String3, "yyyy", System.Globalization.CultureInfo.InvariantCulture);                //    如果不写月份日期具体时间，会默认 1月1号 12点
            Debug.Log(string.Format("{0} --> {1}", iso8601String3, date2ISO8603));                                                                 //    2008 --> 1/1/2008 12:00:00 AM
        }

        static public void spanDateTime() // 兩者相差日期與時間
        {
            DateTime date1 = new DateTime(2008, 6, 6, 6, 6, 6); //2008年6月6号6时6分6秒
            DateTime date2 = new DateTime(2008, 6, 8, 6, 6, 5); //2008年6月8号6时6分5秒
            TimeSpan span1 = date2 - date1;                     //相减 返回 TimeSpan（时间间隔） 对象
            Debug.Log(span1);                                   //1.23:59:59 —— 相差 1天 23小时59分59秒

            TimeSpan span = new TimeSpan(1, 1, 1, 1, 1); //也可自己声明一个 多个构造函数自己选，最大支持天，最小支持微秒
            Debug.Log("span:" + span);                   //span:1.01:01:01.0010000
        }
    }
}
