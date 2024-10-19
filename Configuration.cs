using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityApp
{
    internal class Configuration
    {
        public static List<Setting> BuildAppSettings()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appSettings.json",false,false).Build();

            var list = new List<Setting>();
            list.Add(new Setting { ApiId = Convert.ToInt32(configuration["RandomUserApiID"]),
                ApiName = configuration["RandomUserApiName"],
                ApiPath = configuration["RandomUserApiPath"]
            });
            list.Add(new Setting
            {
                ApiId = Convert.ToInt32(configuration["DummyJsonApiID"]),
                ApiName = configuration["DummyJsonApiName"],
                ApiPath = configuration["DummyJsonApiPath"]
            });
            list.Add(new Setting
            {
                ApiId = Convert.ToInt32(configuration["ReqApiID"]),
                ApiName = configuration["ReqApiName"],
                ApiPath = configuration["ReqApiPath"]
            });
            list.Add(new Setting
            {
                ApiId = Convert.ToInt32(configuration["JaonPlaceHolderApiID"]),
                ApiName = configuration["JaonPlaceHolderApiName"],
                ApiPath = configuration["JaonPlaceHolderApiPath"]
            });

            return list;
        }
    }
}
