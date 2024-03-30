namespace WebMVCR1.Models
{
	public class ModelClass
	{
		public static string ModelHello()
		{
			int hour = DateTime.Now.Hour;
			string Greeting = hour < 12 ? "Good morning" : "Good afternoon";
			return Greeting;
		}
	}
}
