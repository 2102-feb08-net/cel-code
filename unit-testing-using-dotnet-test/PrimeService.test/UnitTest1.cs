using System;
using Xunit;

namespace PrimeService.test
{
	public class PrimeService_IsPrimeShould
	{
		[Fact]
		public void IsPrime_InputIs1_ReturnFalse()
		{
			var primeService = new PrimeService();
			bool result = primeService.IsPrime(1);

			Assert.False(primeService.IsPrime(1), "1 should not be prime");
		}
	}
}
