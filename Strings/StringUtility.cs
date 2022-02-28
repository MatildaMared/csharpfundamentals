namespace Strings {
public class StringUtility {
		public static string SummarizeText(string text, int maxLength = 20) {
			if (text.Length < maxLength) {
				return text;
			}
			else {
				var words = text.Split(" ");
				var totalCharacters = 0;
				var summaryWords = new List<string>();

				foreach (var word in words) {
					totalCharacters += word.Length + 1;
					summaryWords.Add(word);
					if (totalCharacters > maxLength) {
						break;
					}
				}

				var summary = String.Join(" ", summaryWords) + "...";
				return summary;
			}
		}
	}
}