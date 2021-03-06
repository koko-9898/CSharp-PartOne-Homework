﻿using System;

class Neuron
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        while (inputLine != "-1")
        {
            uint inputNumber = uint.Parse(inputLine);

            char[] numberBinaryDigits = Convert.ToString(inputNumber, 2).
                PadLeft(32,'0').ToCharArray();
            //Console.WriteLine(new string(numberBinaryDigits));

            bool isInsideNeuron = false;
            bool isOnBoundary = false;
            bool beenInNeuron = false;

            //Console.WriteLine(new string(numberBinaryDigits));

            for (int i = 0; i < numberBinaryDigits.Length; i++)
            {
                if (numberBinaryDigits[i] == '1')
                {
                    isOnBoundary = true;
                    if (isInsideNeuron)
                    {
                        isInsideNeuron = false;
                        beenInNeuron = true;
                    }

                    numberBinaryDigits[i] = '0';
                }
                else if (numberBinaryDigits[i] == '0')
                {
                     if (!beenInNeuron && isOnBoundary)
                    {
                        isInsideNeuron = true;
                        isOnBoundary = false;
                        
                    }

                    if (isInsideNeuron)
                    {
                        numberBinaryDigits[i] = '1';
                    }
                }
            }
            

            if (!beenInNeuron)
            {
                Console.WriteLine(0);
            }
            else
            {
                uint resultNumber = Convert.ToUInt32(new string(numberBinaryDigits), 2);

                Console.WriteLine(resultNumber);
                //Console.WriteLine(new string(numberBinaryDigits));
            }

            inputLine = Console.ReadLine();
        }
    }
}