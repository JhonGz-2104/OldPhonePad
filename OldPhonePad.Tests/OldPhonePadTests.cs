namespace OldPhonePad.Tests;

public class OldPhonePadTests
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    public void ShouldReturn_CorrespondLetters_WhenGivenNumbers(string input, string expectedResult)
    {
        string result = Program.OldPhonePad(input);

        Assert.Equal(expectedResult, result);
    }
}
