using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace _2_配置管理_2._1命令行配置
{
    class Program
    {
        static void Main(string[] args)
        {
          var  settings=new Dictionary<string,string>()
          {
              { "name","123"},
              { "age","100"}
          };
            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .AddCommandLine(args);
            var configuration = builder.Build();
            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine($"age:{configuration["age"]}");
            Console.ReadLine();
        }
    }
}
