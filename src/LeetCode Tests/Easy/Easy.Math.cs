﻿using System;
using System.Collections.Generic;
using Xunit;
using LeetCodeProblems;
using static LeetCodeProblems.Easy;

namespace LeetCodeTests.Easy
{
    public class Math
    {
        public class IslandPerimeter
        {
            [Theory]
            [MemberData(nameof(PerimeterData))]
            public void ValidInputs(int[,] grid, int expectedResult)
            {
                int actualResult = CalculateIslandPerimeter(grid);
                Assert.Equal(expectedResult, actualResult);
            }

            private static readonly List<object[]> _perimeterData
                = new List<object[]>
                {
                    new object[] { new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } }, 0 },
                    new object[] { new int[,] { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } }, 16 },
                    new object[] { new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 1, 0 } }, 18 },
                    new object[] { new int[,] { { 0, 0 }, { 1, 1 } }, 6 }
                };
            public static IEnumerable<object[]> PerimeterData
            {
                get { return _perimeterData; }
            }
        }
        public class ComplementNumber
        {
            [Theory]
            [MemberData(nameof(ComplementData))]
            public void ValidInputs(int number, int expectedResult)
            {
                int actualResult = FindComplementNumber(number);
                Assert.Equal(expectedResult, actualResult);
            }

            private static readonly List<object[]> _complementData
                = new List<object[]>
                {
                    new object[] { 3, 0 },
                    new object[] { 5, 2 },
                    new object[] { 7, 0 },
                    new object[] { 8, 7 }
                    //new object[] { 2147483647, 0 },
                    //new object[] { 2147483646, 1 },
                    //new object[] { 2147483645, 2 },
                    //new object[] { 2147483644, 3 }
                };
            public static IEnumerable<object[]> ComplementData
            {
                get { return _complementData; }
            }

        }
        public class HammingDistance
        {
            [Theory]
            [InlineData(1, 1, 0)]
            [InlineData(1, 0, 1)]
            [InlineData(17, 324, 5)]
            public void ValidInputs(int x, int y, int expectedResult)
            {
                int actualResult = FindHammingDistance(x, y);
                Assert.Equal(expectedResult, actualResult);
            }
        }
        public class LargestSumMinValues
        {
            [Theory]
            [MemberData(nameof(PartitionData))]
            public void ValidInputs(int[] intArray, int expectedResult)
            {
                int actualResult = FindLargestSumOfMinValues(intArray);
                Assert.Equal(expectedResult, actualResult);
            }

            private static readonly List<object[]> _partitionData
                = new List<object[]>
                {
                    new object[] { new int[] { 1, 2, 3, 4}, 4 },
                    new object[] { new int[] { 1, 4, 2, 3}, 4 },
                    new object[] { new int[] { 1, 1, 1, 1}, 2 },
                    new object[] { new int[] { 1, 6, 15, 93}, 16 }
                };
            public static IEnumerable<object[]> PartitionData
            {
                get { return _partitionData; }
            }
        }
        public class DistributeCandies
        {
            [Theory]
            [MemberData(nameof(CandyData))]
            public void ValidInputs(int[] candies, int expectedResult)
            {
                int actualResult = DistributeCandies(candies);
                Assert.Equal(expectedResult, actualResult);
            }
            private static readonly List<object[]> _candyData
                = new List<object[]>
                {
                    new object[] { new int[] { 1, 2, 3, 4 }, 2 },
                    new object[] { new int[] { 1, 1, 1, 1 }, 1 },
                    new object[] { new int[] { 1, 2, 1, 1 }, 2 }
                };
            public static IEnumerable<object[]> CandyData
            {
                get { return _candyData; }
            }
        }
        public class MatrixReshape
        {
            [Theory]
            [MemberData(nameof(MatrixData))]
            public void ValidInputs(int[,] inputMatrix, int outputRows, int outputColumns, int[,] expectedResult)
            {
                int[,] actualResult = MatrixReshape(inputMatrix, outputRows, outputColumns);
                Assert.Equal(expectedResult, actualResult);
            }

            private static readonly List<object[]> _matrixData
                = new List<object[]>
                {
                    new object[]
                    {
                        new int[,] { { 1, 2 }, { 3, 4 } }, 1, 4, new int[,] { { 1, 2, 3, 4 } }
                    },
                    new object[]
                    {
                        new int[,] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } }, 1, 4, new int[,] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } }
                    },
                    new object[]
                    {
                        new int[,] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } }, 8, 1, new int[,] { { 1 }, { 2 }, { 3 }, { 4 }, { 4 }, { 5 }, { 6 }, { 7 } }
                    }
                };
            public static IEnumerable<object[]> MatrixData
            {
                get { return _matrixData; }
            }
        }
        public class NextGreater
        {
            [Theory]
            [MemberData(nameof(GreaterNumberData))]
            public void ValidInputs(int[] findNums, int[] nums, int[] expectedResult)
            {
                int[] actualResult = NextGreaterElement(findNums, nums);
                Assert.Equal(expectedResult, actualResult);
            }

            private static readonly List<object[]> _greaterNumberData
                = new List<object[]>
                {
                    new object[] { new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 }, new int[] { -1, 3, -1 } }
                };
            public static IEnumerable<object[]> GreaterNumberData
            {
                get { return _greaterNumberData; }
            }

        }
        public class ConsecutiveOnes
        {
            [Theory]
            [InlineData(new int[] { 1, 1 }, 2)]
            [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
            public void ValidInputs(int[] nums, int expectedResult)
            {
                int actualResult = MaxConsecutiveOnes(nums);
                Assert.Equal(expectedResult, actualResult);
            }
        }
        public class MaxTreeDepth
        {
            [Theory]
            [MemberData(nameof(TreeData))]
            public void ValidInputs(TreeNode x, int expectedResult)
            {
                int actualResult = MaxDepth(x);
                Assert.True(expectedResult.Equals(actualResult));
            }
            private static readonly List<object[]> _treeData
                = new List<object[]>
                {
                        new object[] { new TreeNode(1), 1 },
                        new object[] { new TreeNode(1, new TreeNode(2), new TreeNode(3)), 2 },
                        new object[] { null, 0 }
                };
            public static IEnumerable<object[]> TreeData
            {
                get { return _treeData; }
            }
        }
        public class MergeBinaryTrees
        {
            [Theory]
            [MemberData(nameof(TreeData))]
            public void ValidInputs(TreeNode x, TreeNode y, TreeNode expectedResult)
            {
                TreeNode actualResult = MergeTrees(x, y);
                Assert.True(expectedResult.Equals(actualResult));
            }
            private static readonly List<object[]> _treeData
                = new List<object[]>
                {
                        new object[]
                        {
                            new TreeNode(1), new TreeNode(7), new TreeNode(8)
                        }
                };
            public static IEnumerable<object[]> TreeData
            {
                get { return _treeData; }
            }
        }

    }
}
