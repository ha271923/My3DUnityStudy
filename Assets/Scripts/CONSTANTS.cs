#define LOCAL_DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CONSTANTS
{
    public const string TAG = "VrCarGame";
    public const int DEFAULT_DEBUGMODE = 0;

    public const int CYCLE_SCENE_LOAD = 1;

    public const string OBSERVERCAMERA_SCENE_NAME = "ObserverCamera";
    public const string CAR1CAMERA_SCENE_NAME = "Car1Camera";
    public const string CAR2CAMERA_SCENE_NAME = "Car2Camera";

    public const string Aaron_ObserverUrl_12F = "rtsp://admin:Admin55555@192.168.225.74:8554/fhd"; // Hawk: requiredUP-189C61-5G WiFi AP at 12F
    public const string MWC_ObserverUrl = "rtsp://admin:Admin55555@10.10.0.5:28554/fhd"; // 17F 5G

    public const string Hawk_SERVER_OBSERVER = "rtsp://admin:Admin55555@192.168.1.254/F1_2021_C.mp4";  // HTC_Wireless
    public const string Hawk_SERVER_CAR1 = "rtsp://admin:Admin55555@192.168.1.254/F1_2021_B.mp4";  // HTC_Wireless
    public const string Hawk_SERVER_CAR2 = "rtsp://admin:Admin55555@192.168.1.254/F1_2021_A.mp4";  // HTC_Wireless

    public const string MWC_SERVER_CAR1 = "rtsp://192.168.100.86:8554/cockpit"; // 17F 5G
    public const string MWC_SERVER_CAR2 = "rtsp://192.168.100.87:8554/cockpit"; // 17F 5G

#if LOCAL_DEBUG
    public const string DEFAULT_ObserverUrl = Hawk_SERVER_OBSERVER;
    public const string DEFAULT_Car1CamUrl = Hawk_SERVER_CAR1;
    public const string DEFAULT_Car2CamUrl = Hawk_SERVER_CAR2;
#else // official
    public const string DEFAULT_ObserverUrl = MWC_ObserverUrl;
    public const string DEFAULT_Car1CamUrl = MWC_SERVER_CAR1;
    public const string DEFAULT_Car2CamUrl = MWC_SERVER_CAR2;
#endif
    public const int LOADING_ANIMATION_TIMEOUT = 3;

}
