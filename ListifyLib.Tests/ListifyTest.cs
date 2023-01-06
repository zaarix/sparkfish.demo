namespace ListifyLib.Tests;

public class ListifyTest
{
    [Fact]
    public void create_sequence()
    {
        var target = new Listify(1, 5);
        Assert.Equal(1, target[0]);
        Assert.Equal(5, target[4]);
    }
}