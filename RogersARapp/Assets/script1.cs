using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Net.Http;
using System.IO;


public class script1 : MonoBehaviour
{
    private const string URL = "(raspi_add):5000/query?device=1";
    private static readonly HttpClient client = new HttpClient();

    void Start()
    {
        // StartCoroutine(GetRequest(URL));
    }

    public int return1(int args) {
        return args;
    }

    private async void Update(){
        var responseString = await client.GetStringAsync("http://www.example.com/recepticle.aspx");
        Debug.Log(responseString);
    }

    // Below code does nothing btw
/*
    public class ReturnRes {
        public string num {get; set;}
    }
    
    private string path = "http://www.example.com/recepticle.aspx"; 
    static async Task<ReturnRes> GetProductAsync(string path) {
        ReturnRes product = null;
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            product = await response.Content.ReadAsAsync<ReturnRes>();
        }
        return product;
    }

 */


    // IEnumerator GetRequest(string uri)
/*
string html = string.Empty;
string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
request.AutomaticDecompression = DecompressionMethods.GZip;

using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
using (Stream stream = response.GetResponseStream())
using (StreamReader reader = new StreamReader(stream))
{
    html = reader.ReadToEnd();
}

Console.WriteLine(html);
 */

    // {
    //     UnityWebRequest uwr = UnityWebRequest.Get(uri);
    //     yield return uwr.SendWebRequest();

    //     if (uwr.isNetworkError)
    //     {
    //         Debug.Log("Error While Sending: " + uwr.error);
    //     }
    //     else
    //     {
    //         Debug.Log("Received: " + uwr.downloadHandler.text);
    //     }
    // }
}