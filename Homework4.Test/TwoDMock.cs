using System;


namespace Homework4.Test
{
    public  class TwoDMock
    {
       public enum TDAMockType
        {
            Positive3X3,
            Positive3X3Swap,
            Positive4X4,
            Positive4X4Swap,
            Negative3X3,
            Negative3X3Swap,
            Negative2X2,
            Negative2X2Swap,
            Empty

        }


        public static int[,] GetMock(TDAMockType type)
        {

            switch (type)
            {
                case TDAMockType.Positive3X3:
                    return new int[,]
                    {
                        {1, 3, 2},
                        {2, 3, 0},
                        {3, 4, 5},
                    };
                    case TDAMockType.Positive3X3Swap:
                    return new int[,]
                    {
                        {1, 2, 3},
                        {3, 3, 4},
                        {2, 0, 5},
                    };
                case TDAMockType.Positive4X4:
                    return new int[,]
                    {
                        {2, 4, 3, 4},
                        {2, 3, 1, 5},
                        {3, 8, 5, 6},
                        {3, 4, 5, 8},
                    };
            
                case TDAMockType.Positive4X4Swap:
                    return new int[,]
                    {
                        { 2, 2, 3, 3},
                        { 4, 3, 8, 4},
                        { 3, 1, 5, 5},
                        { 4, 5, 6, 8},
                    };
                        
                case TDAMockType.Negative3X3:
                    return new int[,]
                    {
                        {-1, -2, -3},
                        {-4, -5, -6},
                        {-5, -6, -55},

                    };

                case TDAMockType.Negative3X3Swap:
                    return new int[,]
                    {
                        {-1, -4, -5},
                        {-2, -5, -6},
                        {-3, -6, -55},

                    };

                case TDAMockType.Negative2X2:
                    return new int[,]
                    {
                        {-1, -2,},
                        {-4, -5,},
                        
                    };

                case TDAMockType.Negative2X2Swap:
                    return new int[,]
                    {
                        {-1, -4,},
                        {-2, -5,},

                    };

                case TDAMockType.Empty:
                    return new int[,] { };


                default:
                    throw new Exception();
            }

        }

       

    }
}
