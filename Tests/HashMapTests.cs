using DataStructures;

namespace Tests;

public class HashMapTests
{
    [Fact]
    public void Simple()
    {
        var a = new HashMap<int>();
        a.Set("a", 10);

        var value = a.Get("a");
        
        Assert.Equal(10, value);
    }
    
    [Fact]
    public void Collision()
    {
        var a = new HashMap<int>(capacity: 2);
        a.Set("a", 10);
        a.Set("b", 20);
        a.Set("c", 30);

        Assert.Equal(10, a.Get("a"));
        Assert.Equal(20, a.Get("b"));
        Assert.Equal(30, a.Get("c"));
    }
}