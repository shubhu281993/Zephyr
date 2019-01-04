using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ZephyrAPI.Interface;

namespace ZephyrAPI.Data
{
    public sealed class MongoDataContext : IDataContext
    {
        public MongoDataContext(IOptions<Settings> setting)
        {
            var settings = setting.Value;

            var mongoSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.MONGODB_CONNECTION));

            if(settings.MongoIsSsl)
            {
                mongoSettings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
            }
            var client = new MongoClient(mongoSettings);
        }
    }
}
