namespace HealthMate.BLL.Healthtrend
{
	public interface IHealthTrend
	{
		List<int> ConditionSummarayInThePastMonth(int patientId, int durationInMonth);
	}
}
