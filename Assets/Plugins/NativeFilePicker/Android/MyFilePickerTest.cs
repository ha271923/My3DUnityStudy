using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static NativeFilePicker;

// sample code at 
// https://github.com/yasirkula/UnityNativeFilePicker/tree/master/.github
public class MyFilePickerTest : MonoBehaviour
{
    Permission mPermission;

    #region Helper Functions
    public void onCllick_CanPickMultipleFiles() { Debug.LogWarning("onCllick_CanPickMultipleFiles   ret=" + NativeFilePicker.CanPickMultipleFiles());}
    public void onCllick_CanExportFiles() { Debug.LogWarning("onCllick_CanExportFiles   ret=" + NativeFilePicker.CanExportFiles()); }
    public void onCllick_CanExportMultipleFiles() { Debug.LogWarning("onCllick_CanExportMultipleFiles   ret=" + NativeFilePicker.CanExportMultipleFiles()); }
    public void onCllick_IsFilePickerBusy() { Debug.LogWarning("onCllick_IsFilePickerBusy   ret=" + NativeFilePicker.IsFilePickerBusy()); }
    public void onCllick_ConvertExtensionToFileType() { Debug.LogWarning("onCllick_ConvertExtensionToFileType   ret=" + NativeFilePicker.ConvertExtensionToFileType("jpg")); } // GetMimeTypeFromExtension
    #endregion

    #region Runtime Permissions
    public void onCllick_CheckPermission()
    {
        Debug.LogWarning("onCllick_CheckPermission +");
        mPermission = NativeFilePicker.CheckPermission();
        Debug.LogWarning("onCllick_CheckPermission -  mPermission=" + mPermission);
    }
    public void onCllick_RequestPermission()
    {
        Debug.LogWarning("onCllick_RequestPermission +");
        mPermission = NativeFilePicker.RequestPermission();
        Debug.LogWarning("onCllick_RequestPermission -  mPermission=" + mPermission);
    }
    #endregion

    #region Import Functions
    public void onCllick_PickFile() {
        Debug.LogWarning("onCllick_PickFile +");
        string[] allowedFileTypes = new string[] { "image/*", "image/png" };
        mPermission = NativeFilePicker.PickFile(onPickFile, allowedFileTypes);
        Debug.LogWarning("onCllick_PickFile -  mPermission="+ mPermission);
    }

    private void onPickFile(string pickingFile) {
        Debug.LogWarning("onPickFile  pickingFile=" + pickingFile);
    }

    public void onCllick_PickMultipleFiles()
    {
        Debug.LogWarning("onCllick_PickMultipleFiles +");
        string[] allowedFileTypes = new string[] { "image/*", "image/png" };
        mPermission = NativeFilePicker.PickMultipleFiles(onPickMultipleFiles, allowedFileTypes);
        Debug.LogWarning("onCllick_PickMultipleFiles -  mPermission=" + mPermission);
    }

    private void onPickMultipleFiles(string[] pickingFiles)
    {
        Debug.LogWarning("onPickMultipleFiles  pickingFiles=" + pickingFiles);
        if (pickingFiles == null)
            Debug.LogWarning("onPickMultipleFiles  operation cancelled");
        else
        {
            for (int i = 0; i < pickingFiles.Length; i++)
                Debug.LogWarning("onPickMultipleFiles  Picked file: " + pickingFiles[i]);
        }
    }
    #endregion

    #region Export Functions
    public void onCllick_ExportFile()
    {
        Debug.LogWarning("onCllick_ExportFile +   path="+ Application.temporaryCachePath);
        // Create a dummy text file
        string filePath = Path.Combine(Application.temporaryCachePath, "ExportFileApi.txt");
        File.WriteAllText(filePath, "Hello Native File Apis - ExportFile() called");

        mPermission = NativeFilePicker.ExportFile(filePath, onExportFile);
        Debug.LogWarning("onCllick_ExportFile -  mPermission=" + mPermission);
    }

    private void onExportFile(bool success)
    {
        Debug.LogWarning("onExportFile  success=" + success);
    }
    public void onCllick_ExportMultipleFiles()
    {
        Debug.LogWarning("onCllick_ExportMultipleFiles +   path=" + Application.temporaryCachePath);
        string filePath1 = Path.Combine(Application.temporaryCachePath, "ExportFileApi_1.txt");
        File.WriteAllText(filePath1, "Hello Native File Apis - ExportFile() called");
        string filePath2 = Path.Combine(Application.temporaryCachePath, "ExportFileApi_2.txt");
        File.WriteAllText(filePath2, "Hello Native File Apis - ExportFile() called");

        mPermission = NativeFilePicker.ExportMultipleFiles(new string[] { filePath1, filePath2 }, onExportMultipleFiles);
        Debug.LogWarning("onCllick_ExportMultipleFiles -  mPermission=" + mPermission);
    }

    private void onExportMultipleFiles(bool success)
    {
        Debug.LogWarning("onExportMultipleFiles  success=" + success);
    }
    #endregion

}
