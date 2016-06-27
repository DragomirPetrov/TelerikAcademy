namespace School.Record
{
    public interface IComentable
    {
        string Comment { get; }

        void MakeComment(string text);
    }
}