// Copyright (c) karaoke.dev <contact@karaoke.dev>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using LrcParser.Parser.Kar.Utils;
using NUnit.Framework;

namespace LrcParser.Tests.Parser.Kar.Utils;

public class TimeTagUtilsTest
{
    [TestCase("[00:01:00]", 1000)]
    public void TestTimeTagToMillionSecond(string timeTag, int millionSecond)
    {
        var actual = TimeTagUtils.TimeTagToMillionSecond(timeTag);

        Assert.That(actual, Is.EqualTo(millionSecond));
    }

    [TestCase(1000, "[00:01.00]")]
    public void TestTimeTagToMillionSecond(int millionSecond, string timeTag)
    {
        var actual = TimeTagUtils.MillionSecondToTimeTag(millionSecond);

        Assert.That(actual, Is.EqualTo(timeTag));
    }
}
