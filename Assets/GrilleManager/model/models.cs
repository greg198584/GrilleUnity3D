using System;
using System.Numerics;

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
        public int taille;
        public ZoneTransfert zone_transfert;
        public int secteur_flag;
        public int iteration;
        public int cycle;
        public int nbr_programmes;
        public Zone[] zones;
        public bool status;
        public string version;
        public bool flag_capture;
        public int move_vitesse;

        

        public override string ToString(){
            return UnityEngine.JsonUtility.ToJson (this, true);
        }
    }

    [Serializable]
    public class Zone
    {
        public int secteur_id;
        public int zone_id;
        public bool status;
        public bool actif;
        public string distance;

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