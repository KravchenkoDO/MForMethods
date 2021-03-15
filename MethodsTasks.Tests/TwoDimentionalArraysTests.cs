using NUnit.Framework;

namespace MethodsTasks.Tests
{
    class TwoDimentionalArraysTests
    {
        [TestCase(1, 4)]
        [TestCase(3, 8)]
        [TestCase(6, 2)]
        [TestCase(5, 5)]
        public void CountElementsThatLargerThenNeighbors_Tests(int mockNumber, int expected)
        {
            int[,] array = TwoDimentionalArraysMock.Get(mockNumber);

            int actual = TwoDimentionalArrays.CountElementsThatLargerThenNeighbors(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(6, 7)]
        public void Transpose_Tests(int mockNumber, int expectedMockNumber)
        {
            int[,] actArr = TwoDimentionalArraysMock.Get(mockNumber);
            int[,] actual = TwoDimentionalArrays.Transpose(actArr);

            int[,] expArr = TwoDimentionalArraysMock.Get(expectedMockNumber);

            Assert.AreEqual(expArr, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 9)]
        [TestCase(3, 54)]
        [TestCase(4, 54)]
        [TestCase(5, 29)]
        [TestCase(6, 46)]
        public void GetMaxElement_Tests(int mockNumber, int expected)
        {
            int[,] array = TwoDimentionalArraysMock.Get(mockNumber);

            int actual = TwoDimentionalArrays.GetMaxElement(array);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 0)]
        [TestCase(5, 2)]
        [TestCase(6, 1)]
        public void GetMinElement_Tests(int mockNumber, int expected)
        {
            int[,] array = TwoDimentionalArraysMock.Get(mockNumber);

            int actual = TwoDimentionalArrays.GetMinElement(array);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, new[] {2, 2})]
        [TestCase(6, new[] {1, 2})]
        [TestCase(5, new[] {0, 1})]
        public void GetIndexOfMinElement_Tests(int mockNumber, int[] expected)
        {
            int[,] array = TwoDimentionalArraysMock.Get(mockNumber);
            int[] actual = TwoDimentionalArrays.GetIndexOfMinElement(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new[] {1, 2})]
        [TestCase(3, new[] {1, 1})]
        [TestCase(6, new[] {1, 0})]
        public void GetIndexOfMaxElement_Tests(int mockNumber, int[] expected)
        {
            int[,] array = TwoDimentionalArraysMock.Get(mockNumber);
            int[] actual = TwoDimentionalArrays.GetIndexOfMaxElement(array);

            Assert.AreEqual(expected, actual);
        }

        public static class TwoDimentionalArraysMock
        {
            public static int[,] Get(int mockNumber)
            {
                int[,] twoDimentionalArray = new int[0, 0];
                switch (mockNumber)
                {
                    case 1:
                        twoDimentionalArray = new[,]
                        {
                            {1, 3, 5},
                            {2, 4, 6},
                            {7, 9, 0},
                            {8, 0, 2}
                        };
                        break;
                    case 2:
                        twoDimentionalArray = new[,]
                        {
                            {1, 2, 7, 8},
                            {3, 4, 9, 0},
                            {5, 6, 0, 2}
                        };
                        break;
                    case 3:
                        twoDimentionalArray = new[,]
                        {
                            {5, 2, 4, 7},
                            {3, 54, 9, 0},
                            {5, 6, 6, 2},
                            {9, 2, 7, 8},
                            {3, 4, 29, 0},
                            {46, 6, 0, 12}
                        };
                        break;
                    case 4:
                        twoDimentionalArray = new[,]
                        {
                            {5, 2, 4, 7},
                            {3, 54, 9, 0},
                            {5, 6, 6, 2}
                        };
                        break;
                    case 5:
                        twoDimentionalArray = new[,]
                        {
                            {9, 2, 7, 8},
                            {3, 4, 29, 2},
                            {4, 6, 3, 12}
                        };
                        break;
                    case 6:
                        twoDimentionalArray = new[,]
                        {
                            {5, 2, 4, 7},
                            {46, 6, 1, 12}
                        };
                        break;
                    case 7:
                        twoDimentionalArray = new[,]
                        {
                            {5, 46},
                            {2, 6},
                            {4, 1},
                            {7, 12}
                        };
                        break;
                }

                return twoDimentionalArray;

            }
        }

    }
}
