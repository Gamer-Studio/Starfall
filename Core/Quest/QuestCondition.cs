namespace Starfall.Core.Quest
{
	public class QuestCondition
	{
		public static readonly QuestCondition NULL = new();
		public string Target { get; set; } = "";    // 예: "Minion", "STR"
		public int CurrentCount { get; set; }  // 예: 3
	}
}
