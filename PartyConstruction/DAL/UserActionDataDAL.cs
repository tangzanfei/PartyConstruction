﻿/**  版本信息模板在安装目录下，可自行修改。
* UserActionDataDAL.cs
*
* 功 能： N/A
* 类 名： UserActionDataDAL
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
using System.Data;
using System.Text;
using System.Data.SQLite;
using Maticsoft.DBUtility;//Please add references
namespace PartyConstruction.DAL
{
	/// <summary>
	/// 数据访问类:UserActionDataDAL
	/// </summary>
	public partial class UserActionDataDAL
	{
		public UserActionDataDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserActionData");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.String,2147483647)			};
			parameters[0].Value = ID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(PartyConstruction.Model.DBUserActionData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserActionData(");
			strSql.Append("ID,ActionID,UserID,ManagerConfirmed,ManagerID)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ActionID,@UserID,@ManagerConfirmed,@ManagerID)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.String,2147483647),
					new SQLiteParameter("@ActionID", DbType.String,2147483647),
					new SQLiteParameter("@UserID", DbType.String,2147483647),
					new SQLiteParameter("@ManagerConfirmed", DbType.Boolean),
					new SQLiteParameter("@ManagerID", DbType.String,2147483647)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ActionID;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.ManagerConfirmed;
			parameters[4].Value = model.ManagerID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(PartyConstruction.Model.DBUserActionData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserActionData set ");
			strSql.Append("ActionID=@ActionID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("ManagerConfirmed=@ManagerConfirmed,");
			strSql.Append("ManagerID=@ManagerID");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ActionID", DbType.String,2147483647),
					new SQLiteParameter("@UserID", DbType.String,2147483647),
					new SQLiteParameter("@ManagerConfirmed", DbType.Boolean),
					new SQLiteParameter("@ManagerID", DbType.String,2147483647),
					new SQLiteParameter("@ID", DbType.String,2147483647)};
			parameters[0].Value = model.ActionID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.ManagerConfirmed;
			parameters[3].Value = model.ManagerID;
			parameters[4].Value = model.ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserActionData ");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.String,2147483647)			};
			parameters[0].Value = ID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserActionData ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PartyConstruction.Model.DBUserActionData GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ActionID,UserID,ManagerConfirmed,ManagerID from UserActionData ");
			strSql.Append(" where ID=@ID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@ID", DbType.String,2147483647)			};
			parameters[0].Value = ID;

			PartyConstruction.Model.DBUserActionData model=new PartyConstruction.Model.DBUserActionData();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public PartyConstruction.Model.DBUserActionData DataRowToModel(DataRow row)
		{
			PartyConstruction.Model.DBUserActionData model=new PartyConstruction.Model.DBUserActionData();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ActionID"]!=null)
				{
					model.ActionID=row["ActionID"].ToString();
				}
				if(row["UserID"]!=null)
				{
					model.UserID=row["UserID"].ToString();
				}
				if(row["ManagerConfirmed"]!=null && row["ManagerConfirmed"].ToString()!="")
				{
					if((row["ManagerConfirmed"].ToString()=="1")||(row["ManagerConfirmed"].ToString().ToLower()=="true"))
					{
						model.ManagerConfirmed=true;
					}
					else
					{
						model.ManagerConfirmed=false;
					}
				}
				if(row["ManagerID"]!=null)
				{
					model.ManagerID=row["ManagerID"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ActionID,UserID,ManagerConfirmed,ManagerID ");
			strSql.Append(" FROM UserActionData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM UserActionData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from UserActionData T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "UserActionData";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

