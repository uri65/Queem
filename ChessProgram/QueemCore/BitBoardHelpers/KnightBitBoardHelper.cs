using System;

namespace QueemCore.BitBoards.Helpers
{
	public static class KnightBitBoardHelper
	{
		// precalculated moves
		public static readonly ulong[] KnightMoves = 
			{0x20400UL, 0x50800UL, 0xA1100UL, 0x142200UL, 0x284400UL, 0x508800UL, 
			0xA01000UL, 0x402000UL, 0x2040004UL, 0x5080008UL, 0xA110011UL, 0x14220022UL, 
			0x28440044UL, 0x50880088UL, 0xA0100010UL, 0x40200020UL, 0x204000402UL, 0x508000805UL, 
			0xA1100110AUL, 0x1422002214UL, 0x2844004428UL, 0x5088008850UL, 0xA0100010A0UL, 
			0x4020002040UL, 0x20400040200UL, 0x50800080500UL, 0xA1100110A00UL, 0x142200221400UL, 
			0x284400442800UL, 0x508800885000UL, 0xA0100010A000UL, 0x402000204000UL, 0x2040004020000UL, 
			0x5080008050000UL, 0xA1100110A0000UL, 0x14220022140000UL, 0x28440044280000UL, 0x50880088500000UL, 
			0xA0100010A00000UL, 0x40200020400000UL, 0x204000402000000UL, 0x508000805000000UL, 0xA1100110A000000UL, 
			0x1422002214000000UL, 0x2844004428000000UL, 0x5088008850000000UL, 0xA0100010A0000000UL, 0x4020002040000000UL, 
			0x400040200000000UL, 0x800080500000000UL, 0x1100110A00000000UL, 0x2200221400000000UL, 0x4400442800000000UL, 
			0x8800885000000000UL, 0x100010A000000000UL, 0x2000204000000000UL, 0x4020000000000UL, 0x8050000000000UL, 
			0x110A0000000000UL, 0x22140000000000UL, 0x44280000000000UL, 0x88500000000000UL, 0x10A00000000000UL, 
			0x20400000000000UL};
	}
}
