﻿/**  版本信息模板在安装目录下，可自行修改。
* DBUserActionData.cs
*
* 功 能： N/A
* 类 名： DBUserActionData
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/5/8 星期五 下午 5:08:35   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace PartyConstruction.Model
{
	/// <summary>
	/// DBUserActionData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBUserActionData
	{
		public DBUserActionData()
		{}
		#region Model
		private string _id;
		private string _actionid;
		private string _userid;
		private bool _managerconfirmed= false;
		private string _managerid;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ActionID
		{
			set{ _actionid=value;}
			get{return _actionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ManagerConfirmed
		{
			set{ _managerconfirmed=value;}
			get{return _managerconfirmed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManagerID
		{
			set{ _managerid=value;}
			get{return _managerid;}
		}
		#endregion Model

	}
}

