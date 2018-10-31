using System.Text;

namespace UnityExtensions
{
	public static class StringBuilderExtensions
	{
		public static void AppendLineFormat(this StringBuilder self, string format, params object[] args)
		{
			self.AppendLine(string.Format(format, args));
		}
	}
}
