namespace IndexerExample_with_Dic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student["Math"] = 100;
            var mathScore = student["Math"];
            Console.WriteLine(mathScore);
        }
    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        public int? this[string subject] {
            get 
            { 
                /* return the specified index here */ 
                if(this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                if(value.HasValue == false )
                {
                    throw new Exception("null value");
                }
                /* set the specified index to value here */
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}