namespace RegexExercise.Models;

public sealed class FieldChangedEventArgs : EventArgs
{
    public string FieldName { get; }
    public string Value { get; }

    public FieldChangedEventArgs(string fieldName, string value)
    {
        FieldName = fieldName;
        Value = value;
    }
}