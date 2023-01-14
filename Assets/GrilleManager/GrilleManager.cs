using UnityEngine;
using UnityEditor;
using Proyecto26;
using GridModels;

namespace APIGrid
{
    public class GrilleManager
    {
        private RequestHelper currentRequest;

        // Start is called before the first frame update
        public static void GetStatus()
        {
            // RestClient.Get<GridInfos>("http://localhost/v1/grid/").Then(response => {
            //     EditorUtility.DisplayDialog("JSON", JsonUtility.ToJson(response, true), "Ok");
            // });
            RestClient.Get<GridInfos>("http://localhost/v1/grid").Then(response => {
                Debug.Log(response.ToString());
                // EditorUtility.DisplayDialog("Response", JsonUtility.ToJson(response, true), "Ok");
            });
        }
    }
}