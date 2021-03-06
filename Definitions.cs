﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
	/// <summary>
	/// USB device status'
	/// </summary>
	enum USBDStatus : UInt32
	{
		SUCCESS = 0x00000000,
		PENDING = 0x40000000,
		HALTED = 0xC0000000,
		ERROR = 0x80000000,

		CRC = 0xC0000001,
		BTSTUFF = 0xC0000002,
		DATA_TOGGLE_MISMATCH = 0xC0000003,
		STALL_PID = 0xC0000004,
		DEV_NOT_RESPONDING = 0xC0000005,
		PID_CHECK_FAILURE = 0xC0000006,
		UNEXPECTED_PID = 0xC0000007,
		DATA_OVERRUN = 0xC0000008,
		DATA_UNDERRUN = 0xC0000009,
		RESERVED1 = 0xC000000A,
		RESERVED2 = 0xC000000B,
		BUFFER_OVERRUN = 0xC000000C,
		BUFFER_UNDERRUN = 0xC000000D,
		NOT_ACCESSED = 0xC000000F,
		FIFO = 0xC0000010,
		ENDPOINT_HALTED = 0xC0000030,
		NO_MEMORY = 0x80000100,
		INVALID_URB_FUNCTION = 0x80000200,
		INVALID_PARAMETER = 0x80000300,
		ERROR_BUSY = 0x80000400,
		REQUEST_FAILED = 0x80000500,
		INVALID_PIPE_HANDLE = 0x80000600,
		NO_BANDWIDTH = 0x80000700,
		INTERNAL_HC_ERROR = 0x80000800,
		ERROR_SHORT_TRANSFER = 0x80000900,
		BAD_START_FRAME = 0xC0000A00,
		ISOCH_REQUEST_FAILED = 0xC0000B00,
		FRAME_CONTROL_OWNED = 0xC0000C00,
		FRAME_CONTROL_NOT_OWNED = 0xC0000D00,
		CANCELLED = 0x00010000,
		CANCELLING = 0x00020000
	}

	/// <summary>
	/// USB HID keyboard codes. This is an incomplete list
	/// </summary>
	enum KeyboardKeymap : byte
	{
		Reserved = 0x00,
		ErrorPollOver = 0x01,
		POSTFail = 0x02,
		ErrorUndefined = 0x03,
		A = 0x04,
		B = 0x05,
		C = 0x06,
		D = 0x07,
		E = 0x08,
		F = 0x09,
		G = 0x0A,
		H = 0x0B,
		I = 0x0C,
		J = 0x0D,
		K = 0x0E,
		L = 0x0F,
		M = 0x10,
		N = 0x11,
		O = 0x12,
		P = 0x13,
		Q = 0x14,
		R = 0x15,
		S = 0x16,
		T = 0x17,
		U = 0x18,
		V = 0x19,
		W = 0x1A,
		X = 0x1B,
		Y = 0x1C,
		Z = 0x1D,
		NUM1 = 0x1E,
		NUM2 = 0x1F,
		NUM3 = 0x20,
		NUM4 = 0x21,
		NUM5 = 0x22,
		NUM6 = 0x23,
		NUM7 = 0x24,
		NUM8 = 0x25,
		NUM9 = 0x26,
		NUM0 = 0x27,
		Enter = 0x28,
		Escape = 0x29,
		Delete = 0x2A,
		TAB = 0x2B,
		SPACE = 0x2C,
		CAPSLOCK = 0x39,
		LEFTCONTROL = 0xE0,
		LEFTSHIFT = 0xE1,
		LEFTALT = 0xE2,
		RIGHTCONTROL = 0xE4,
		RIGHTSHIFT = 0xE5,
		RIGHTALT = 0xE6
	}

	/// <summary>
	/// Keyboard modifiers. This was implented to support shift key detection
	/// </summary>
	enum KeyboardModifier : byte
	{
		None = 0x00,
		Shift = 0x02
	}

	/// <summary>
	/// Enum to represent indices of interest in the payload
	/// </summary>
	enum PayloadKeys : byte
	{
		Modifier = 2,
		KeyCode = 4
	}

}
