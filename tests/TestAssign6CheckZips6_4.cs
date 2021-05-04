using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign6CheckZips6_4
{

    [Fact]
    public void TestCase1()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var textInput = "60103";
        
        var input = new StringReader(textInput);
        Console.SetIn(input);
        
        CheckZips.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter a ZIP code for delivery: ");
        expectedOutcome.AppendLine(string.Format("Delivery to {0} ok", textInput));

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }

    [Fact]
    public void TestCase2()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var textInput = "43145";
        
        var input = new StringReader(textInput);
        Console.SetIn(input);
        
        CheckZips.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter a ZIP code for delivery: ");
        expectedOutcome.AppendLine(string.Format("Sorry - no delivery to {0}", textInput));

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }
}
