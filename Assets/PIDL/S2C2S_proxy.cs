﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
using System.Net;

namespace S2C2S
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool RequestLogin(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String id, System.String password)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.RequestLogin;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, id);
		Nettention.Proud.Marshaler.Write(__msg, password);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_RequestLogin, Common.RequestLogin);
}

public bool RequestLogin(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String id, System.String password)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.RequestLogin;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, id);
Nettention.Proud.Marshaler.Write(__msg, password);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_RequestLogin, Common.RequestLogin);
}
public bool NotifyLoginSuccess(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.NotifyLoginSuccess;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_NotifyLoginSuccess, Common.NotifyLoginSuccess);
}

public bool NotifyLoginSuccess(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.NotifyLoginSuccess;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_NotifyLoginSuccess, Common.NotifyLoginSuccess);
}
public bool NotifyLoginFailed(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String reason)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.NotifyLoginFailed;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, reason);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_NotifyLoginFailed, Common.NotifyLoginFailed);
}

public bool NotifyLoginFailed(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String reason)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.NotifyLoginFailed;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, reason);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_NotifyLoginFailed, Common.NotifyLoginFailed);
}
public bool JoinGameRoom(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int character_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.JoinGameRoom;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_JoinGameRoom, Common.JoinGameRoom);
}

public bool JoinGameRoom(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int character_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.JoinGameRoom;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, character_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_JoinGameRoom, Common.JoinGameRoom);
}
public bool JoinInGame(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int character_num, int Room_id)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.JoinInGame;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		Nettention.Proud.Marshaler.Write(__msg, Room_id);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_JoinInGame, Common.JoinInGame);
}

public bool JoinInGame(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int character_num, int Room_id)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.JoinInGame;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, character_num);
Nettention.Proud.Marshaler.Write(__msg, Room_id);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_JoinInGame, Common.JoinInGame);
}
public bool LeaveGameRoom(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.LeaveGameRoom;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_LeaveGameRoom, Common.LeaveGameRoom);
}

public bool LeaveGameRoom(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.LeaveGameRoom;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_LeaveGameRoom, Common.LeaveGameRoom);
}
public bool Room_Appear(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int hostID, System.String id, int character_num, System.String team_color, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_Appear;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, hostID);
		Nettention.Proud.Marshaler.Write(__msg, id);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		Nettention.Proud.Marshaler.Write(__msg, team_color);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_Appear, Common.Room_Appear);
}

public bool Room_Appear(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int hostID, System.String id, int character_num, System.String team_color, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_Appear;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, hostID);
Nettention.Proud.Marshaler.Write(__msg, id);
Nettention.Proud.Marshaler.Write(__msg, character_num);
Nettention.Proud.Marshaler.Write(__msg, team_color);
Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_Appear, Common.Room_Appear);
}
public bool Room_Disappear(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_Disappear;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_Disappear, Common.Room_Disappear);
}

public bool Room_Disappear(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_Disappear;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_Disappear, Common.Room_Disappear);
}
public bool Game_Appear(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int value, int team_num, int Min, int Sec, int S_score, int R_score)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Game_Appear;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, value);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		Nettention.Proud.Marshaler.Write(__msg, Min);
		Nettention.Proud.Marshaler.Write(__msg, Sec);
		Nettention.Proud.Marshaler.Write(__msg, S_score);
		Nettention.Proud.Marshaler.Write(__msg, R_score);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Game_Appear, Common.Game_Appear);
}

public bool Game_Appear(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int value, int team_num, int Min, int Sec, int S_score, int R_score)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Game_Appear;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, value);
Nettention.Proud.Marshaler.Write(__msg, team_num);
Nettention.Proud.Marshaler.Write(__msg, Min);
Nettention.Proud.Marshaler.Write(__msg, Sec);
Nettention.Proud.Marshaler.Write(__msg, S_score);
Nettention.Proud.Marshaler.Write(__msg, R_score);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Game_Appear, Common.Game_Appear);
}
public bool CountStart(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.CountStart;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_CountStart, Common.CountStart);
}

public bool CountStart(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.CountStart;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_CountStart, Common.CountStart);
}
public bool GameStart(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.GameStart;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_GameStart, Common.GameStart);
}

public bool GameStart(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.GameStart;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_GameStart, Common.GameStart);
}
public bool Player_SetReady(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_SetReady;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_SetReady, Common.Player_SetReady);
}

public bool Player_SetReady(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_SetReady;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_SetReady, Common.Player_SetReady);
}
public bool Player_SetResponse(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int team_num, bool value)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_SetResponse;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		Nettention.Proud.Marshaler.Write(__msg, value);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_SetResponse, Common.Player_SetResponse);
}

public bool Player_SetResponse(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int team_num, bool value)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_SetResponse;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, team_num);
Nettention.Proud.Marshaler.Write(__msg, value);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_SetResponse, Common.Player_SetResponse);
}
public bool PlayerInfo(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int team_num, int character_num, float px, float py, float pz, float rx, float ry, float rz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.PlayerInfo;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		Nettention.Proud.Marshaler.Write(__msg, px);
		Nettention.Proud.Marshaler.Write(__msg, py);
		Nettention.Proud.Marshaler.Write(__msg, pz);
		Nettention.Proud.Marshaler.Write(__msg, rx);
		Nettention.Proud.Marshaler.Write(__msg, ry);
		Nettention.Proud.Marshaler.Write(__msg, rz);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_PlayerInfo, Common.PlayerInfo);
}

public bool PlayerInfo(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int team_num, int character_num, float px, float py, float pz, float rx, float ry, float rz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.PlayerInfo;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, team_num);
Nettention.Proud.Marshaler.Write(__msg, character_num);
Nettention.Proud.Marshaler.Write(__msg, px);
Nettention.Proud.Marshaler.Write(__msg, py);
Nettention.Proud.Marshaler.Write(__msg, pz);
Nettention.Proud.Marshaler.Write(__msg, rx);
Nettention.Proud.Marshaler.Write(__msg, ry);
Nettention.Proud.Marshaler.Write(__msg, rz);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_PlayerInfo, Common.PlayerInfo);
}
public bool Player_Move(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_team_num, float m_move, float m_rotate, bool m_reload, float px, float py, float pz, float rx, float ry, float rz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_Move;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		Nettention.Proud.Marshaler.Write(__msg, m_move);
		Nettention.Proud.Marshaler.Write(__msg, m_rotate);
		Nettention.Proud.Marshaler.Write(__msg, m_reload);
		Nettention.Proud.Marshaler.Write(__msg, px);
		Nettention.Proud.Marshaler.Write(__msg, py);
		Nettention.Proud.Marshaler.Write(__msg, pz);
		Nettention.Proud.Marshaler.Write(__msg, rx);
		Nettention.Proud.Marshaler.Write(__msg, ry);
		Nettention.Proud.Marshaler.Write(__msg, rz);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_Move, Common.Player_Move);
}

public bool Player_Move(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_team_num, float m_move, float m_rotate, bool m_reload, float px, float py, float pz, float rx, float ry, float rz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_Move;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_team_num);
Nettention.Proud.Marshaler.Write(__msg, m_move);
Nettention.Proud.Marshaler.Write(__msg, m_rotate);
Nettention.Proud.Marshaler.Write(__msg, m_reload);
Nettention.Proud.Marshaler.Write(__msg, px);
Nettention.Proud.Marshaler.Write(__msg, py);
Nettention.Proud.Marshaler.Write(__msg, pz);
Nettention.Proud.Marshaler.Write(__msg, rx);
Nettention.Proud.Marshaler.Write(__msg, ry);
Nettention.Proud.Marshaler.Write(__msg, rz);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_Move, Common.Player_Move);
}
public bool Player_Chat(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String id, System.String text)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_Chat;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, id);
		Nettention.Proud.Marshaler.Write(__msg, text);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_Chat, Common.Player_Chat);
}

public bool Player_Chat(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String id, System.String text)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_Chat;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, id);
Nettention.Proud.Marshaler.Write(__msg, text);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_Chat, Common.Player_Chat);
}
public bool Player_Shoot(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_team_num, float bx, float by, float bz, int kind)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_Shoot;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		Nettention.Proud.Marshaler.Write(__msg, bx);
		Nettention.Proud.Marshaler.Write(__msg, by);
		Nettention.Proud.Marshaler.Write(__msg, bz);
		Nettention.Proud.Marshaler.Write(__msg, kind);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_Shoot, Common.Player_Shoot);
}

public bool Player_Shoot(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_team_num, float bx, float by, float bz, int kind)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_Shoot;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_team_num);
Nettention.Proud.Marshaler.Write(__msg, bx);
Nettention.Proud.Marshaler.Write(__msg, by);
Nettention.Proud.Marshaler.Write(__msg, bz);
Nettention.Proud.Marshaler.Write(__msg, kind);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_Shoot, Common.Player_Shoot);
}
public bool Player_GetHP(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_humidity)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_GetHP;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_humidity);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_GetHP, Common.Player_GetHP);
}

public bool Player_GetHP(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_humidity)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_GetHP;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_humidity);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_GetHP, Common.Player_GetHP);
}
public bool Player_SetHP(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_team_num, int m_damage)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_SetHP;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		Nettention.Proud.Marshaler.Write(__msg, m_damage);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_SetHP, Common.Player_SetHP);
}

public bool Player_SetHP(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_team_num, int m_damage)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_SetHP;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_team_num);
Nettention.Proud.Marshaler.Write(__msg, m_damage);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_SetHP, Common.Player_SetHP);
}
public bool Show_Player_Color(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_team_num, int m_humidity, float m_Max_humidity)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Show_Player_Color;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		Nettention.Proud.Marshaler.Write(__msg, m_humidity);
		Nettention.Proud.Marshaler.Write(__msg, m_Max_humidity);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Show_Player_Color, Common.Show_Player_Color);
}

public bool Show_Player_Color(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_team_num, int m_humidity, float m_Max_humidity)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Show_Player_Color;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_team_num);
Nettention.Proud.Marshaler.Write(__msg, m_humidity);
Nettention.Proud.Marshaler.Write(__msg, m_Max_humidity);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Show_Player_Color, Common.Show_Player_Color);
}
public bool Room_weather(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String _weather)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_weather;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, _weather);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_weather, Common.Room_weather);
}

public bool Room_weather(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String _weather)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_weather;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, _weather);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_weather, Common.Room_weather);
}
public bool Room_Item(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int idx, float ix, float iy, float iz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_Item;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, idx);
		Nettention.Proud.Marshaler.Write(__msg, ix);
		Nettention.Proud.Marshaler.Write(__msg, iy);
		Nettention.Proud.Marshaler.Write(__msg, iz);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_Item, Common.Room_Item);
}

public bool Room_Item(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int idx, float ix, float iy, float iz)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_Item;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, idx);
Nettention.Proud.Marshaler.Write(__msg, ix);
Nettention.Proud.Marshaler.Write(__msg, iy);
Nettention.Proud.Marshaler.Write(__msg, iz);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_Item, Common.Room_Item);
}
public bool Player_Kill(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int m_team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Player_Kill;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Player_Kill, Common.Player_Kill);
}

public bool Player_Kill(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int m_team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Player_Kill;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, m_team_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Player_Kill, Common.Player_Kill);
}
public bool Get_selete(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Get_selete;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Get_selete, Common.Get_selete);
}

public bool Get_selete(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Get_selete;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Get_selete, Common.Get_selete);
}
public bool Set_selete(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int result, int Room_id, int Min, int Sec)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Set_selete;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, result);
		Nettention.Proud.Marshaler.Write(__msg, Room_id);
		Nettention.Proud.Marshaler.Write(__msg, Min);
		Nettention.Proud.Marshaler.Write(__msg, Sec);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Set_selete, Common.Set_selete);
}

public bool Set_selete(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int result, int Room_id, int Min, int Sec)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Set_selete;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, result);
Nettention.Proud.Marshaler.Write(__msg, Room_id);
Nettention.Proud.Marshaler.Write(__msg, Min);
Nettention.Proud.Marshaler.Write(__msg, Sec);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Set_selete, Common.Set_selete);
}
public bool Get_END(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Get_END;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Get_END, Common.Get_END);
}

public bool Get_END(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Get_END;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Get_END, Common.Get_END);
}
public bool Set_END(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String team_color)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Set_END;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, team_color);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Set_END, Common.Set_END);
}

public bool Set_END(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String team_color)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Set_END;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, team_color);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Set_END, Common.Set_END);
}
#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_RequestLogin="RequestLogin";
public const string RmiName_NotifyLoginSuccess="NotifyLoginSuccess";
public const string RmiName_NotifyLoginFailed="NotifyLoginFailed";
public const string RmiName_JoinGameRoom="JoinGameRoom";
public const string RmiName_JoinInGame="JoinInGame";
public const string RmiName_LeaveGameRoom="LeaveGameRoom";
public const string RmiName_Room_Appear="Room_Appear";
public const string RmiName_Room_Disappear="Room_Disappear";
public const string RmiName_Game_Appear="Game_Appear";
public const string RmiName_CountStart="CountStart";
public const string RmiName_GameStart="GameStart";
public const string RmiName_Player_SetReady="Player_SetReady";
public const string RmiName_Player_SetResponse="Player_SetResponse";
public const string RmiName_PlayerInfo="PlayerInfo";
public const string RmiName_Player_Move="Player_Move";
public const string RmiName_Player_Chat="Player_Chat";
public const string RmiName_Player_Shoot="Player_Shoot";
public const string RmiName_Player_GetHP="Player_GetHP";
public const string RmiName_Player_SetHP="Player_SetHP";
public const string RmiName_Show_Player_Color="Show_Player_Color";
public const string RmiName_Room_weather="Room_weather";
public const string RmiName_Room_Item="Room_Item";
public const string RmiName_Player_Kill="Player_Kill";
public const string RmiName_Get_selete="Get_selete";
public const string RmiName_Set_selete="Set_selete";
public const string RmiName_Get_END="Get_END";
public const string RmiName_Set_END="Set_END";
       
public const string RmiName_First = RmiName_RequestLogin;
#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_RequestLogin="";
public const string RmiName_NotifyLoginSuccess="";
public const string RmiName_NotifyLoginFailed="";
public const string RmiName_JoinGameRoom="";
public const string RmiName_JoinInGame="";
public const string RmiName_LeaveGameRoom="";
public const string RmiName_Room_Appear="";
public const string RmiName_Room_Disappear="";
public const string RmiName_Game_Appear="";
public const string RmiName_CountStart="";
public const string RmiName_GameStart="";
public const string RmiName_Player_SetReady="";
public const string RmiName_Player_SetResponse="";
public const string RmiName_PlayerInfo="";
public const string RmiName_Player_Move="";
public const string RmiName_Player_Chat="";
public const string RmiName_Player_Shoot="";
public const string RmiName_Player_GetHP="";
public const string RmiName_Player_SetHP="";
public const string RmiName_Show_Player_Color="";
public const string RmiName_Room_weather="";
public const string RmiName_Room_Item="";
public const string RmiName_Player_Kill="";
public const string RmiName_Get_selete="";
public const string RmiName_Set_selete="";
public const string RmiName_Get_END="";
public const string RmiName_Set_END="";
       
public const string RmiName_First = "";
#endif
		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}

