// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionPaymentSentMe : TLMessageActionBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Info = (1 << 0),
			ShippingOptionId = (1 << 1),
		}

		public bool HasInfo { get { return Flags.HasFlag(Flag.Info); } set { Flags = value ? (Flags | Flag.Info) : (Flags & ~Flag.Info); } }
		public bool HasShippingOptionId { get { return Flags.HasFlag(Flag.ShippingOptionId); } set { Flags = value ? (Flags | Flag.ShippingOptionId) : (Flags & ~Flag.ShippingOptionId); } }

		public Flag Flags { get; set; }
		public String Currency { get; set; }
		public Int64 TotalAmount { get; set; }
		public Byte[] Payload { get; set; }
		public TLPaymentRequestedInfo Info { get; set; }
		public String ShippingOptionId { get; set; }
		public TLPaymentCharge Charge { get; set; }

		public TLMessageActionPaymentSentMe() { }
		public TLMessageActionPaymentSentMe(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionPaymentSentMe; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Currency = from.ReadString();
			TotalAmount = from.ReadInt64();
			Payload = from.ReadByteArray();
			if (HasInfo) Info = TLFactory.Read<TLPaymentRequestedInfo>(from);
			if (HasShippingOptionId) ShippingOptionId = from.ReadString();
			Charge = TLFactory.Read<TLPaymentCharge>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x8F31B327);
			to.Write((Int32)Flags);
			to.Write(Currency);
			to.Write(TotalAmount);
			to.WriteByteArray(Payload);
			if (HasInfo) to.WriteObject(Info);
			if (HasShippingOptionId) to.Write(ShippingOptionId);
			to.WriteObject(Charge);
		}

		private void UpdateFlags()
		{
			HasInfo = Info != null;
			HasShippingOptionId = ShippingOptionId != null;
		}
	}
}