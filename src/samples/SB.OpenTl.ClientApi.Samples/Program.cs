using OpenTl.ClientApi;
using System;
using System.Threading.Tasks;

namespace SB.OpenTl.ClientApi.Samples
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public const int AppId = 0; // replace it

        /// <summary>
        /// 
        /// </summary>
        public const string AppHash = "" // replace it;

        /// <summary>
        /// 
        /// </summary>
        public const string PhoneNumber = "" // replace it;

        /// <summary>
        /// 
        /// </summary>
        public static IClientApi Client { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static async Task Main(string[] args)
        {
            InitConnection();

            var _sentCode = await Client.AuthService.SendCodeAsync(PhoneNumber);
            var authCode = "";
            var res = await Client.AuthService.SignInAsync(PhoneNumber, _sentCode, authCode);
            
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 
        /// </summary>
        private static void InitConnection()
        {
            var settings = new FactorySettings();
            settings.AppHash = AppHash;
            settings.AppId = AppId;
            settings.ServerAddress = "149.154.175.100";
            settings.ServerPort = 443;
            settings.SessionTag = "session";
            settings.ServerPublicKey = "-----BEGIN RSA PUBLIC KEY-----\nMIIBCgKCAQEAwVACPi9w23mF3tBkdZz+zwrzKOaaQdr01vAbU4E1pvkfj4sqDsm6\nlyDONS789sVoD/xCS9Y0hkkC3gtL1tSfTlgCMOOul9lcixlEKzwKENj1Yz/s7daS\nan9tqw3bfUV/nqgbhGX81v/+7RFAEd+RwFnK7a+XYl9sluzHRyVVaTTveB2GazTw\nEfzk2DWgkBluml8OREmvfraX3bkHZJTKX4EQSjBbbdJ2ZXIsRrYOXfaA+xayEGB+\n8hdlLmAjbCVfaigxX0CDqWeR1yFL9kwd9P0NsZRPsmoqVwMbMu7mStFai6aIhc3n\nSlv8kg9qv1m6XHVQY3PnEw+QQtqSIXklHwIDAQAB\n-----END RSA PUBLIC KEY-----";

            var properties = new ApplicationProperties();
            properties.AppVersion = "1.0.0";
            properties.DeviceModel = "PC";
            properties.LangCode = "en";
            properties.LangPack = "tdesktop";
            properties.SystemLangCode = "en";
            properties.SystemVersion = "Win 10 Pro";
            settings.Properties = properties;

            Client = ClientFactory.BuildClientAsync(settings).Result;
            Client.KeepAliveConnection();
        }
    }
}
