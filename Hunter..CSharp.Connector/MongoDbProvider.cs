﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Hunter.CSharp.Connector
{
    public class MongoDbProvider
    {
        private static MongoClient mongoClient = null;

        public static MongoClient MongoClient
        {
            get
            {
                if (mongoClient != null)
                    return mongoClient;

                var mongoConnectionString = Settings.MongoConnectionString;

                var serverUrls = mongoConnectionString.Split(';');

                List<MongoServerAddress> nodes = new List<MongoServerAddress>();

                foreach(var url in serverUrls)
                {
                    nodes.Add(new MongoServerAddress(url));
                }

                mongoClient = new MongoClient(new MongoClientSettings
                {
                    ConnectTimeout= TimeSpan.FromSeconds(30),
                    Servers= nodes                    
                });

                return mongoClient;
            }
        }
        
        public static IMongoDatabase GetHunterLogsDatabase()
        {
            return MongoClient.GetDatabase("hunterlogsdb");
        }

        public static IMongoCollection<LogPayload> GetHunterLogsCollection()
        {

            return GetHunterLogsDatabase().GetCollection<LogPayload>("hunterlogs");
        }
       
    }
}