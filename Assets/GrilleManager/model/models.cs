using System;

namespace GridModels
{
    [Serializable]
    public class ZoneTransfert
    {
        public int secteur_id;
        public int zone_id;

        public override string ToString(){
            return UnityEngine.JsonUtility.ToJson (this, true);
        }
    }
    [Serializable]
    public class GridInfos
    {
        public string id;
        public string version;
        public bool status;

        public ZoneTransfert zone_transfert;

        public override string ToString(){
            return UnityEngine.JsonUtility.ToJson (this, true);
        }
    }
    [Serializable]
    public class ProgrammeInfos
    {
        public string id;
        public string version;
        public bool status;

        public ZoneTransfert zone_transfert;

        public override string ToString(){
            return UnityEngine.JsonUtility.ToJson (this, true);
        }
    }
}