namespace Gradebook.Tests;

public class UnitTest1
{
    private static string bookName = "Test Book";
    [Fact]
    public void BookCalculatesWithNoArgs()
    {
        GradeBook.Book gradebook = new GradeBook.Book();

        Assert.Equal(Double.MaxValue, gradebook.GetLowestGrade());
        Assert.Equal(Double.MinValue, gradebook.GetHighestGrade());
        Assert.Equal(double.NaN, gradebook.GetAverage());
        Assert.Null(gradebook.GetName());

        gradebook.AddGrade(70.0);
        gradebook.AddGrade(80.0);
        gradebook.AddGrade(90.0);
        gradebook.SetName(bookName);

        Assert.Equal(70.0, gradebook.GetLowestGrade());
        Assert.Equal(90.0, gradebook.GetHighestGrade());
        Assert.Equal(80.0, gradebook.GetAverage());
        Assert.Equal(bookName, gradebook.GetName());

    }

    [Fact]
    public void BookCalculatesWithListArg()
    {
        List<double> grades = new List<double>{70.0, 80.0, 90.0};
        GradeBook.Book gradebook = new GradeBook.Book(grades);

        Assert.Equal(70.0, gradebook.GetLowestGrade());
        Assert.Equal(90.0, gradebook.GetHighestGrade());
        Assert.Equal(80.0, gradebook.GetAverage());
        Assert.Equal(bookName, gradebook.GetName());

    }

}