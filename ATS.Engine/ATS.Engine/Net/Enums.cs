using System;

namespace ATS.Engine.Net
{
	public enum DOEntityType
	{
		Customer = 1,

		Account,

		Card,

		Setting,

		Adviser,

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