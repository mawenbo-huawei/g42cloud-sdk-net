using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Cbr.V1
{
    public class CbrRegion
    {
        public static readonly Region AE_AD_1 = new Region("ae-ad-1", "https://cbr.ae-ad-1.g42cloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "ae-ad-1", AE_AD_1 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}