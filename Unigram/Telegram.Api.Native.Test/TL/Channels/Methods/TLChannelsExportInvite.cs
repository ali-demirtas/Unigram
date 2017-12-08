// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.exportInvite.
	/// Returns <see cref="Telegram.Api.TL.TLExportedChatInviteBase"/>
	/// </summary>
	public partial class TLChannelsExportInvite : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsExportInvite() { }
		public TLChannelsExportInvite(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsExportInvite; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
		}
	}
}