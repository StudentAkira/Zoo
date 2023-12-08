namespace ClassLibrary1
{
    public class NameGeneratorDLL
    {
        string[] names = new string[]
        {
            "Степашка",
            "Дурашка",
            "Пушок",
            "Снежок",
            "Сахар",
            "Зефир",
            "Олежка"
        };
        public NameGeneratorDLL() { }
        public string generate_name()
        {
            Random rnd = new Random();
            return names[rnd.Next(0, names.Length)];
        }
    }
}