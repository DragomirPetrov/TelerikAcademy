namespace Mobile
{
    using System;

    public class GSMTest
    {
        public static void DisplayGsmInformation()
        {
            GSM[] gsmsColection =
         {
                new GSM("Iphone 6S", "Apple", 800, "Joro", new Battery("AppleBattery", 10, 5), new Display(5.5, 16000000)),
                new GSM("Galaxy S7", "SAMSUNG", 700, "Slavi", new Battery("SAMSUNG", 1, 2, BatteryType.NiCd), new Display(5.7, 16000000)),
                new GSM("Desire 530", "HTC", 650, "Geri", new Battery("HTC", 10, 5), new Display(5.7, 16000000))
            };

            foreach (var gsm in gsmsColection)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
