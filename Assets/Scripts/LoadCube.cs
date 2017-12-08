using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class LoadCube : MonoBehaviour
{
    IEnumerator Start()
    {
        //string uri = "file:///" + Application.dataPath + "/AssetBundles/mycube.hd";
        string uri = "https://mytestbundle.blob.core.windows.net/windows/mycube.hd";
        UnityWebRequest request = UnityWebRequest.GetAssetBundle(uri, 0);
        yield return request.Send();
        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
        GameObject cube = bundle.LoadAsset<GameObject>("CubeName");
        Instantiate(cube);
    }
}
