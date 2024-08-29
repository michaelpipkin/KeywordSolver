using System.Text;
using static System.Net.HttpStatusCode;

namespace KeywordSolverForms
{
	public partial class Form1 : Form
	{
		private CancellationTokenSource _cancellationTokenSource = new();

		public Form1() {
			InitializeComponent();
		}

		private void EnterLetters(object sender, EventArgs e) {
			if (sender is TextBox textBox && textBox.Text.Length > 0) {
				textBox.Text = string.Concat(textBox.Text.ToUpper().Replace(" ", "").Distinct().OrderBy(c => c));
			}
		}

		private async void FindWordsButton_ClickAsync(object sender, EventArgs e) {
			Answers.Text = string.Empty;
			if (string.IsNullOrEmpty(FirstLetter.Text) ||
					string.IsNullOrEmpty(SecondLetter.Text) ||
					string.IsNullOrEmpty(ThirdLetter.Text) ||
					string.IsNullOrEmpty(FourthLetter.Text) ||
					string.IsNullOrEmpty(FifthLetter.Text) ||
					string.IsNullOrEmpty(SixthLetter.Text)) {
				Answers.Text = "At least one letter is required in every field.";
				return;
			}
			FindWordsButton.Enabled = false;
			ClearButton.Enabled = false;
			StopButton.Enabled = true;
			Answers.Text = string.Empty;
			await TestLetters();
			FindWordsButton.Enabled = true;
			ClearButton.Enabled = true;
			StopButton.Enabled = false;
			FirstLetter.Focus();
		}

		private void ClearButton_Click(object sender, EventArgs e) {
			FirstLetter.Text = string.Empty;
			SecondLetter.Text = string.Empty;
			ThirdLetter.Text = string.Empty;
			FourthLetter.Text = string.Empty;
			FifthLetter.Text = string.Empty;
			SixthLetter.Text = string.Empty;
			Answers.Text = string.Empty;
			FirstLetter.Focus();
		}

		private void StopButton_Click(object sender, EventArgs e) {
			_cancellationTokenSource?.Cancel();
			StopButton.Enabled = false;
			FindWordsButton.Enabled = true;
			ClearButton.Enabled = true;
		}

		private async Task TestLetters() {
			_cancellationTokenSource = new CancellationTokenSource();
			var firstLetters = string.Concat(FirstLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var secondLetters = string.Concat(SecondLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var thirdLetters = string.Concat(ThirdLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var fourthLetters = string.Concat(FourthLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var fifthLetters = string.Concat(FifthLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var sixthLetters = string.Concat(SixthLetter.Text).ToUpper().Replace(" ", "").OrderBy(c => c);
			var answers = new StringBuilder();
			var http = new HttpClient();
			await Task.Run(() => {
				foreach (var firstetter in firstLetters) {
					foreach (var secondletter in secondLetters) {
						foreach (var thirdletter in thirdLetters) {
							foreach (var fourthletter in fourthLetters) {
								foreach (var fifthletter in fifthLetters) {
									foreach (var sixthletter in sixthLetters) {
										if (_cancellationTokenSource.Token.IsCancellationRequested) {
											Answers.Invoke(new Action(() => Answers.AppendText($"{Environment.NewLine}Search cancelled.")));
											return;
										}
										var possibleWord = $"{firstetter}{secondletter}{thirdletter}{fourthletter}{fifthletter}{sixthletter}";
										try {
											var isWord = http.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{possibleWord.ToLower()}").Result;
											if (Answers.Text.Length > 0) Answers.Invoke(new Action(() => Answers.AppendText(Environment.NewLine)));
											switch (isWord.StatusCode) {
												case OK: {
														Answers.Invoke(new Action(() => Answers.AppendText($"*** {possibleWord} ***")));
														return;
													}
												case NotFound: {
														Answers.Invoke(new Action(() => Answers.AppendText(possibleWord)));
														break;
													}
												case TooManyRequests: {
														Answers.Invoke(new Action(() => Answers.AppendText("Too Many Requests response. Please wait and try again later.")));
														return;
													}
												default: {
														Answers.Invoke(new Action(() => Answers.AppendText($"Error {isWord.StatusCode}:{isWord.ReasonPhrase}. Please try again.")));
														return;
													}
											}
										}
										catch (Exception ex) {
											Answers.Invoke(new Action(() => Answers.AppendText(ex.Message)));
											return;
										}
										Thread.Sleep(1000);
									}
								}
							}
						}
					}
				}
				http.Dispose();
				Answers.Invoke(new Action(() => Answers.AppendText($"{Environment.NewLine}No valid words found.")));
			});
		}
	}
}
