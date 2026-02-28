namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string originalText = "";
        private string currentText = "";

        // Set new text
        public void SetText(string text)
        {
            originalText = text;
            currentText = text;
        }

        // Get current text
        public string GetText()
        {
            return currentText;
        }

        // Convert to uppercase
        public void ToUpperCase()
        {
            currentText = currentText.ToUpper();
        }

        // Convert to lowercase
        public void ToLowerCase()
        {
            currentText = currentText.ToLower();
        }

        // Count characters
        public int CountCharacters()
        {
            return currentText.Length;
        }

        // Check if contains word
        public bool ContainsWord(string word)
        {
            return currentText.Contains(word);
        }

        // Replace word
        public void ReplaceWord(string oldWord, string newWord)
        {
            currentText = currentText.Replace(oldWord, newWord);
        }

        // Extract substring
        public string ExtractSubstring(int startIndex, int length)
        {
            return currentText.Substring(startIndex, length);
        }

        // Trim spaces
        public void TrimSpaces()
        {
            currentText = currentText.Trim();
        }

        // Reset to original
        public void ResetText()
        {
            currentText = originalText;
        }
    }
}
