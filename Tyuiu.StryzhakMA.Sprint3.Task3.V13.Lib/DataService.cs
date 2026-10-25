using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StryzhakMA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string str = " ";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                { 
                    str += chr;
                }
            }
            return Convert.ToInt32(str);
        }
    }
}
