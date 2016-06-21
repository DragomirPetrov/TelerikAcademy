namespace Mobile
{
    using System;

    public class MobileTelephone
    {
        public static void Main()
        {
            GSMTest.DisplayGsmInformation();

            Console.WriteLine("---- MY PHONE AND CALL HISTORY ----");
            Console.WriteLine();
            var gsm = new GSM("Experia", "SONY", 999.9, "Drago", new Battery("SONY", 1, 4, BatteryType.NiMH), new Display());
            Console.WriteLine(gsm);

            //Creates calls
            for (int i = 0; i < 10; i++)
            {
                gsm.AddCall(new Call()
                {
                    DialedPhone = "000" + i,
                    Duration = (uint)(i + 1) * 120
                });
            }

            gsm.DisplayCallHistory();

            gsm.CalculateTotalCost(0.37);

            //Finds longest call
            var maxCall = new Call();
            uint longestDuration = (uint)0;

            foreach (var call in gsm.CallHistory)
            {
                if (call.Duration>longestDuration)
                {
                    longestDuration = call.Duration;
                    maxCall = call;
                }
            }

            gsm.DeleteCall(maxCall);

            Console.WriteLine();
            Console.WriteLine("---- CALL HISTORY WITHOUT THE LONGEST CALL ----");
            Console.WriteLine();
            gsm.DisplayCallHistory();

            gsm.CalculateTotalCost(0.37);
        }
    }
}
