adb root
adb remount
adb uninstall com.DefaultCompany.My3DUnityStudy
move /y ..\app.apk
rmdir /s/q app
mkdir app
tar -xf app.apk  -C app
adb shell ls -al /system/priv-app/My3DUnityStudy/
adb shell mkdir /system/priv-app/My3DUnityStudy/lib/
adb shell mkdir /system/priv-app/My3DUnityStudy/lib/arm/
adb push app.apk /system/priv-app/My3DUnityStudy/My3DUnityStudy.apk
adb push ./app/lib/armeabi-v7a/. /system/priv-app/My3DUnityStudy/lib/arm/
adb shell ls -al /system/priv-app/My3DUnityStudy/
adb shell ls -al /system/priv-app/My3DUnityStudy/lib/arm/
adb reboot