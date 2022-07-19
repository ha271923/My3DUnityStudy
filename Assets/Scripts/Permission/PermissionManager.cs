using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PermissionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RequestStoragePermission();
        RequestUsbMtpPermission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RequestStoragePermission()
    {
        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
        {
            Debug.LogWarning("[PermissionManager] Has UserAuthorizedPermission write.");
        }
        else
        {
            Debug.LogWarning("[PermissionManager] Has no UserAuthorizedPermission write, need user grant.");
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
        }
        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Debug.LogWarning("[PermissionManager] Has UserAuthorizedPermission read");
        }
        else
        {
            Debug.LogWarning("[PermissionManager] Has no UserAuthorizedPermission read, need user grant.");
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
    }
    public void RequestUsbMtpPermission()
    {
        if (Permission.HasUserAuthorizedPermission("android.mtp.MtpClient.action.USB_PERMISSION"))
        {
            Debug.LogWarning("[PermissionManager] Has UserAuthorizedPermission android.mtp.MtpClient.action.USB_PERMISSION.");
        }
        else
        {
            Debug.LogWarning("[PermissionManager] Has no android.mtp.MtpClient.action.USB_PERMISSION, need user grant.");
            Permission.RequestUserPermission("android.mtp.MtpClient.action.USB_PERMISSION");
        }
    }
}
