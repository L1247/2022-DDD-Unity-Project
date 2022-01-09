#region

using System.Collections.Generic;
using AutoBot.Utilities;
using UnityEngine;

#endregion

namespace Game.RPG_Core.Actor.Scripts.Datas
{
    public class ActorDataOverview : ScriptableObject
    {
    #region Private Variables

        [SerializeField]
        private List<ActorData> datas;

    #endregion

    #region Public Methods

        public ActorData GetData(string dataId)
        {
            return datas.Find(data => data.DataId.Equals(dataId));
        }

        public ActorData GetRandomData()
        {
            return RandomUtilities.GetRandomData(datas);
        }

    #endregion
    }
}