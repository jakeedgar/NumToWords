using System;
using System.Collections.Generic;
using NumToWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumToWords.Tests
{
  [TestClass]
  public class NumConverterTests
  {
    [TestMethod]
    public void ReplaceOnes_ShouldReturnAString_String()
    {
      Assert.AreEqual("one", NumConverter.ReplaceOnes(1));
    }
    [TestMethod]
    public void CreateCharArray_ShouldConvertNumberToCharArrayOfItsDigits_CharArray()
    {
      char[] array = NumConverter.CreateCharArray(152);
      Assert.AreEqual('1', array[0]);
      Assert.AreEqual('5', array[1]);
      Assert.AreEqual('2', array[2]);
    }
    [TestMethod]
    public void ReplaceNumber_ShouldReplace5WithFive_String()
    {
      Assert.AreEqual("five", NumConverter.ReplaceNumber(5));
    }
    [TestMethod]
    public void ReplaceTens_ShouldReplace1WithTen_String()
    {
      Assert.AreEqual("ten", NumConverter.ReplaceTens(1));
    }
    [TestMethod]
    public void ReplaceTeens_ShouldReplace15WithFifteen_String()
    {
      Assert.AreEqual("fifteen", NumConverter.ReplaceTeens(15));
    }
    [TestMethod]
    public void ReplaceNumber_ShouldReplace15WithFifteen_String()
    {
      Assert.AreEqual("fifteen", NumConverter.ReplaceTeens(15));
    }
    [TestMethod]
    public void ReplaceNumber_ShouldReplace23WithTwenty_String()
    {
      Assert.AreEqual("twenty three", NumConverter.ReplaceNumber(23));
    }
    [TestMethod]
    public void ReplaceNumber_ShouldReplace512WithFiveHundredTwelve_String()
    {
      Assert.AreEqual("five hundred and twelve", NumConverter.ReplaceNumber(512));
    }
    [TestMethod]
    public void ReplaceNumber_ShouldReplace562WithFiveHundredSixtyTwo_String()
    {
      Assert.AreEqual("five hundred and sixty-two", NumConverter.ReplaceNumber(562));
    }
  }
}