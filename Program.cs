namespace Pass_or_Fail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = -1;
            double secondNum = -1;
            double thirdNum = -1;
            double fourthNum = -1;
            int ppl = -1;
            int counter = 0;
            int passed = 0;

            foreach (string line in File.ReadLines(@"DATA11.txt"))
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
                                firstNum = (double)Convert.ToInt32(temp)/100;
                            }
                            else if (secondNum == -1)
                                secondNum = (double)Convert.ToInt32(temp)/100;
                            else if (thirdNum == -1)
                                thirdNum = (double)Convert.ToInt32(temp)/100;
                            else if (fourthNum == -1)
                                fourthNum = (double)Convert.ToInt32(temp)/100;
                            temp = "";
                        }
                    }
                    ppl = 0;
                }
                else if (ppl == 0)
                {
                    ppl = Convert.ToInt32(line);
                }
                else
                {
                    if (counter <= ppl)
                    {
                        counter++;
                        string secondLine = line + ' ';
                        string temp = "";
                        int temp1Num = -1;
                        int temp2Num = -1;
                        int temp3Num = -1;
                        int temp4Num = -1;
                        foreach (char c in secondLine)
                        {
                            if (c != ' ')
                                temp += c;
                            else
                            {
                                if (temp1Num == -1)
                                {
                                    temp1Num = Convert.ToInt32(temp);
                                }
                                else if (temp2Num == -1)
                                    temp2Num = Convert.ToInt32(temp);
                                else if (temp3Num == -1)
                                    temp3Num = Convert.ToInt32(temp);
                                else if (temp4Num == -1)
                                    temp4Num = Convert.ToInt32(temp);
                                temp = "";
                            }
                        }
                        double markCalc = (temp1Num * firstNum) + (temp2Num * secondNum) + (temp3Num * thirdNum) + (temp4Num * fourthNum);
                        //Console.WriteLine($"{markCalc} is mark");
                        if (Math.Round(markCalc,2) >= 50)
                        {
                            passed++;
                        }
                        
                    }
                    if (counter == ppl)
                    {
                        Console.WriteLine(passed);
                        firstNum = -1;
                        secondNum = -1;
                        thirdNum = -1;
                        fourthNum = -1;
                        ppl = -1;
                        counter = 0;
                        passed = 0;
                    }
                }
            }
        }
    }
}