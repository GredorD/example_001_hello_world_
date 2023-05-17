Console.Write("Enter a 3-digit number:");
try {
	int Value = Convert.ToInt32(Console.ReadLine());
	int Length = Value.ToString().Length;
	if (Length == 3) {
		int result = ( Value/10 ) % 10;
		Console.WriteLine($"The second digit is {result}");
	} else {
		Console.WriteLine("Not a 3-digit number");
	}
} catch (System.Threading.ThreadAbortException) {
	System.Threading.Thread.ResetAbort();
} catch (Exception e) {
	Console.WriteLine(e.Message);
}
