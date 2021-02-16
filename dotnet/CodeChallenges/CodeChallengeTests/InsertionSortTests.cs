using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using InsertionSort;
using DataStructures;


namespace CodeChallengeTests
{
  
  public class InsertionSortTests
  {
    [Fact]
    public void Tests_That_Output_In_Correct_Order()
    {
    int[] arr = new int[] { 8, 4, 23, 43, 16, 15 };
    int[] expected = new int[] { 4, 8, 15, 16, 23, 43 };

      int[] result = InsertionSort(arr);

    }
  }
}
