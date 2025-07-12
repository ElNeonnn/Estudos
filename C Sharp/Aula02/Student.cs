namespace Aula02
{
    internal class Student
    {
        // 1ª primeira
        private string name = String.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 2ª maneira
        public double Media { get; set; }
    }
}
