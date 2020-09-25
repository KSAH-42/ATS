using System;

namespace ATS.Engine.Net
{
	public enum DOEntityType
	{
		User = 1,

		Account,

		Card,

		Setting,
	}

	public enum EventRecordType
	{
		None = 0,

		UserConnected,

		UserDisconnected,

		CardOrdered,

		CardEnabled,

		CardDisabled,

		AccountOpened,

		AccountClosed,

		WithdrawMoney,

		DepositMoney,
	}

}