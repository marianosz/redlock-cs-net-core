using System;
using System.Diagnostics;

namespace Redlock.CSharp.Tests
{
    public static class TestHelper
    {
        public static Process StartRedisServer(long port)
        {

            var pathWithEnv = @"%userprofile%\.nuget\packages\Redis-32\2.6.12.1\tools\redis-server.exe";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            // Launch Server
            var process = new Process
            {
                StartInfo =
                {
                    FileName = filePath,
                    Arguments = "--port " + port
                }
            };
            process.Start();
            return process;
        }
    }
}