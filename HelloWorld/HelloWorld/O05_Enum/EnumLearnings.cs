using System;
namespace HelloWorld.O05_Enum
{
	public enum ShippingMethods : int
    {
		RegisteredAirMail=4,
		RegularAirMails,
		Express
    }

	public class EnumLearnings
	{
		public static void Learn()
		{
			Console.WriteLine("\nAccessing Enum\n");

			int RegularAirMails = (int) ShippingMethods.RegularAirMails;
			int RegisteredAirMail= (int)ShippingMethods.RegisteredAirMail;
			int Express = (int)ShippingMethods.Express;

			Console.WriteLine(RegisteredAirMail);
			Console.WriteLine(RegularAirMails);
			Console.WriteLine(Express);

			ShippingMethods enumShippingMethods = ShippingMethods.Express;
			Console.WriteLine(enumShippingMethods.ToString());

			string methodName = "RegisteredAirMail";
			ShippingMethods ShippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);
			Console.WriteLine(ShippingMethod);
		}
	}
}

