using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class NameGenerator
    {
        public LocalizationManager lmanager;
        public void init_lmanager()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = File.ReadAllText(LocalizationManager.path, LocalizationManager.encoding);
            lmanager = JsonSerializer.Deserialize<LocalizationManager>(text);
        }
        string[] names = new string[] { };
        public NameGenerator() {
            init_lmanager();
            names = lmanager.AnimalsNames;
        }
        public string generate_name()
        {
            Random rnd = new Random();
            return names[rnd.Next(0, names.Length)];
        }
    }
}
