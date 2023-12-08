using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public class LocalizationManager
    {
        public static string path = @".\data\langs\ru.json";
        //public static Encoding encoding = Encoding.GetEncoding("windows-1251");
        public static Encoding encoding = Encoding.UTF8;
        public LocalizationManager() { }

        public string LionName { get; set; }
        public string ZebraName { get; set; }
        public string PassedDayPayment { get; set; }
        public string Resources { get; set; }
        public string NoMoneyWarning { get; set; }
        public string AviaryBought { get; set; }
        public string Bought { get; set; }
        public string OnCost { get; set; }
        public string NoPlaceToBuyAnimalWarning { get; set; }
        public string DealAccepted { get; set; }
        public string WithName { get; set; }
        public string LocatedInAviary { get; set; }
        public string ImpossibleToKillCornivore { get; set; }
        public string Animal { get; set; }
        public string SlaughterForMeat { get; set; }
        public string Type { get; set; }
        public string Efficiency { get; set; }
        public string Food { get; set; }
        public string Id { get; set; }
        public string Aviary { get; set; }
        public string AviaryId { get; set; }
        public string AviaryArea { get; set; }
        public string AviaryOccupitedArea { get; set; }
        public string AviaryAnimals { get; set; }
        public string AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string AnimalAge { get; set; }
        public string AnimalSatiety { get; set; }
        public string Eaten { get; set; }
        public string AfterLongDay { get; set; }
        public string DiedOfHunger { get; set; }
        public string JustEaten { get; set; }
        public string Oops { get; set; }
        public string LooksVeryHappy { get; set; }
        public string DontWannaEat { get; set; }
        public string StillHungry { get; set; }
        public string LionData { get; set; }
        public string NeededArea { get; set; }
        public string[] AnimalsNames { get; set; }
        public string AnimalPlay { get; set; }
        public string Tips { get; set; }
        public string ZebraData { get; set; }
        public string NO_DATA{ get; set; }
        public string INVALID_DATA { get; set; }

    }
}
