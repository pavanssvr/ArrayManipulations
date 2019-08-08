using System;

namespace BAL
{
    public class ArrayManipulationsService : IArrayManipulationsService
    {
        public int[] ReverseArray(int[] productIds)
        {
            int tempValue;

            for (int i = 0; i < productIds.Length - 1; i++)
            {
                for (int j = i + 1; j < productIds.Length; j++)
                {
                    if (productIds[i] < productIds[j])
                    {
                        tempValue = productIds[i];
                        productIds[i] = productIds[j];
                        productIds[j] = tempValue;
                    }
                }
            }
            return productIds;
        }

        public int[] RemoveElementFromArray(int position, int[] productIds)
        {
            for (int i = position - 1; i < productIds.Length - 1; i++)
            {
                productIds[i] = productIds[i + 1];
            }

            Array.Resize(ref productIds, productIds.Length - 1);
            return productIds;
        }
    }
}
