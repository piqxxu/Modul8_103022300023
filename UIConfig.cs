using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul8_103022300023
{
    internal class UIConfig
    {
        public BankConfig config;
        public const String filePath = @"BankTransferConfig.json";
        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private BankConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<BankConfig>(configJsonData);
            return config;
        }
        private void SetDefault() 
        { 
            config = new BankConfig();
            config.lang = "en";
            config.transfer.threshold = 25000000;
            config.transfer.low_fee = 6500;
            config.transfer.high_fee = 15000;
            config.methods = new List<string>() {"RTO(real - time)", "SKN", "RTGS", "BI FAST"};
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";
        }
        private void WriteNewConfigFile() 
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }

    }

}
