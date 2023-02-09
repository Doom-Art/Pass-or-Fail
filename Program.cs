namespace Pass_or_Fail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = -1;
            int secondNum = -1;
            int thirdNum = -1;
            int fourthNum = -1;
            int ppl = -1;

            foreach (string line in File.ReadLines("@DATA10.txt"))
            {
                if (ppl == -1)
                {
                    string secondLine = line + ' ';
                    string temp = "";
                    foreach (char c in secondLine)
                    {
                        if (c != ' ')
                            temp += c;
                        else
                        {
                            if (firstNum == -1)
                            {
                                firstNum = Convert.ToInt32(temp);
                            }
                            else if (secondNum == -1)
                                secondNum = Convert.ToInt32(temp);
                            else if (thirdNum == -1)
                                thirdNum =Convert.ToInt32(temp);
                            else if (fourthNum == -1)
                                fourthNum = Convert.ToInt32(temp);
                            temp = "";
                        }
                    }
                }
            }
        }
    }
}