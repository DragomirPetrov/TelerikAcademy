namespace School.Record
{
    public enum DisciplineName
    {
        Math, Informatics, History, Geography, Chemistry, Physics, Biology
    }

    public class Disciplines : IComentable
    {
 
        public Disciplines(DisciplineName name, int lectures, int exercises, string comment = null)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercies = exercises;
            this.Comment = comment;
        }

        public DisciplineName Name { get; private set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercies { get; set; }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}