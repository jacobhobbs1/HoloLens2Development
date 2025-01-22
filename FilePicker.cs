using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FilePick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SelectFolder();
    }
    
    // When called spawns a File Explorer to enable the user to create and/or chose the folder to save to. 
    void SelectFolder()  
    {  
        // #if/#else tells Unity to ignore this code.
        #if ENABLE_WINMD_SUPPORT  
            UnityEngine.WSA.Application.InvokeOnUIThread(async () =>  
            {  
                var folderPicker = new Windows.Storage.Pickers.FolderPicker();  
                folderPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;  
                folderPicker.FileTypeFilter.Add("*");  
          
                Windows.Storage.StorageFolder folder = await folderPicker.PickSingleFolderAsync();  
                if (folder != null)  
                {  
                    // Application now has read/write access to all contents in the picked folder  
                    // (including other sub-folder contents)  
                    Windows.Storage.AccessCache.StorageApplicationPermissions.  
                    FutureAccessList.AddOrReplace("PickedFolderToken", folder);  
                }  
            }, false);  
        #endif  
    }
    
    // Synchronous method.
    private void StoreTrialValues()
    {
        // The data here is a string. This could be CSV data as well. 
        var sb = new StringBuilder();

        foreach (Trial dataPoint in trials)
        {
            sb.AppendLine(dataPoint.ToString());
        }

        // Asynchronous method call
        Task.Run(() => SaveFile(sb.ToString())).Wait();
    }

    private async void SaveFile(string data)  
    {  
        // #if/#else tells Unity to ignore this code.
        // Takes the location specified by SelectFolder and saves the "data" string to a file called "data.scv" to that locaiton. 
        #if ENABLE_WINMD_SUPPORT
            if (Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.ContainsItem("PickedFolderToken"))   
            {  
                Windows.Storage.StorageFolder storageFolder = await Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.GetFolderAsync("PickedFolderToken");  
                Windows.Storage.StorageFile dataFile = await storageFolder.CreateFileAsync("data.csv", Windows.Storage.CreationCollisionOption.OpenIfExists);  
                await Windows.Storage.FileIO.WriteTextAsync(dataFile, data);  
            }  
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
