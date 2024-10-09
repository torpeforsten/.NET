namespace ConsoleApp
{
    public class BasicCalculator
    {
        public int? CalculateArea(int width, int height)
        {
            if (width < 0 || height < 0)
            {
                return null;
            }

            try
            {
                checked
                {
                    return width * height;
                }
            }
            catch (OverflowException)
            {
                return null;
            }
        }
    }
}