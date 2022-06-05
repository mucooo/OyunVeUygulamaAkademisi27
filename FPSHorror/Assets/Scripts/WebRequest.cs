#region

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

#endregion

public class WebRequest : MonoBehaviour
{
    [SerializeField] private RawImage _rawImage;
    [SerializeField] private string _imageURL;

    private void Start()
    {
        StartCoroutine(GetTexture());
    }

    IEnumerator GetTexture()
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(_imageURL);

        yield return request.SendWebRequest();
        if (request.isHttpError || request.isNetworkError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            Debug.Log("Success");
            var texture = DownloadHandlerTexture.GetContent(request);
            _rawImage.texture = texture;
        }
        
    }
    
    
}