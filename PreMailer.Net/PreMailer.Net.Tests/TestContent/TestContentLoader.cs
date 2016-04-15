using System.IO;
using System.Reflection;

namespace PreMailer.Net.Tests.TestContent
{
	public static class TestContentLoader
	{
		public static string GetHugeEmailContent()
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourceName = "PreMailer.Net.Tests.TestContent.HugeMail.html";

			using (Stream stream = assembly.GetManifestResourceStream(resourceName))
			using (StreamReader reader = new StreamReader(stream))
			{
				return reader.ReadToEnd();
			}
		}
	}
}
