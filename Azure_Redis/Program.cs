﻿using System;
using StackExchange.Redis;

namespace Azure_Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("trezenetredis.redis.cache.windows.net:6380,password=ftXkXFGfHf9Pf4sIJ8LVIgSQTAmU7I38nnRf96qmipE=,ssl=True,abortConnect=False");
            var db = redis.GetDatabase();

            Console.WriteLine("Digite seu RM");
            var RM = Console.ReadLine();

            Console.WriteLine("Digite seu Nome");
            var nome = Console.ReadLine();

            db.StringSet(RM, nome);

            Console.WriteLine($"Chave: { RM } , valor:{ db.StringGet(RM) }");

            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
