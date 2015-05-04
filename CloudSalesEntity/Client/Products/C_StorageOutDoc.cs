﻿/**  版本信息模板在安装目录下，可自行修改。
* C_StorageOutDoc.cs
*
* 功 能： N/A
* 类 名： C_StorageOutDoc
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/5/3 13:38:23   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CloudSalesEntity
{
	/// <summary>
	/// C_StorageOutDoc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class C_StorageOutDoc
	{
		public C_StorageOutDoc()
		{}
		#region Model
		private int _autoid;
		private string _docid;
		private string _doctype;
		private string _docmaker="";
		private DateTime? _docmakedate= DateTime.Now;
		private string _docauditer="";
		private DateTime? _docauditdate= Convert.ToDateTime("1900-01-01");
		private string _docauditopinion="";
		private int? _status=0;
		private int? _returnstatus=0;
		private int? _flag=0;
		private DateTime? _closedate= Convert.ToDateTime("1900-01-01");
		private string _prodiverid;
		private decimal? _commonprice=0M;
		private decimal? _totalmoney=0M;
		private decimal? _taxmoney=0M;
		private decimal? _profit=0M;
		private decimal? _taxrate=1M;
		private decimal? _returnmoney=0M;
		private string _originalcode="";
		private string _warecode="";
		private string _depotcode="";
		private string _countrycode="";
		private string _citycode="";
		private string _address="";
		private string _postalcode="000000";
		private decimal? _weight=0M;
		private decimal? _fee=0M;
		private decimal? _freight=0M;
		private int? _conveyancetype=0;
		private string _conveyancecompany;
		private string _conveyancecode="";
		private string _personname="";
		private string _mobiletele="";
		private string _feedback="";
		private string _createuserid;
		private DateTime? _createtime= DateTime.Now;
		private DateTime? _updatetime= DateTime.Now;
		private string _operateip="";
		private string _clientid;
		/// <summary>
		/// 
		/// </summary>
		public int AutoID
		{
			set{ _autoid=value;}
			get{return _autoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocID
		{
			set{ _docid=value;}
			get{return _docid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocType
		{
			set{ _doctype=value;}
			get{return _doctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocMaker
		{
			set{ _docmaker=value;}
			get{return _docmaker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DocMakeDate
		{
			set{ _docmakedate=value;}
			get{return _docmakedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocAuditer
		{
			set{ _docauditer=value;}
			get{return _docauditer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DocAuditDate
		{
			set{ _docauditdate=value;}
			get{return _docauditdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DocAuditOpinion
		{
			set{ _docauditopinion=value;}
			get{return _docauditopinion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReturnStatus
		{
			set{ _returnstatus=value;}
			get{return _returnstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CloseDate
		{
			set{ _closedate=value;}
			get{return _closedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProdiverID
		{
			set{ _prodiverid=value;}
			get{return _prodiverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CommonPrice
		{
			set{ _commonprice=value;}
			get{return _commonprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxMoney
		{
			set{ _taxmoney=value;}
			get{return _taxmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Profit
		{
			set{ _profit=value;}
			get{return _profit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TaxRate
		{
			set{ _taxrate=value;}
			get{return _taxrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ReturnMoney
		{
			set{ _returnmoney=value;}
			get{return _returnmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OriginalCode
		{
			set{ _originalcode=value;}
			get{return _originalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WareCode
		{
			set{ _warecode=value;}
			get{return _warecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepotCode
		{
			set{ _depotcode=value;}
			get{return _depotcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CountryCode
		{
			set{ _countrycode=value;}
			get{return _countrycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CityCode
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostalCode
		{
			set{ _postalcode=value;}
			get{return _postalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Freight
		{
			set{ _freight=value;}
			get{return _freight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ConveyanceType
		{
			set{ _conveyancetype=value;}
			get{return _conveyancetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConveyanceCompany
		{
			set{ _conveyancecompany=value;}
			get{return _conveyancecompany;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConveyanceCode
		{
			set{ _conveyancecode=value;}
			get{return _conveyancecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PersonName
		{
			set{ _personname=value;}
			get{return _personname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MobileTele
		{
			set{ _mobiletele=value;}
			get{return _mobiletele;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FeedBack
		{
			set{ _feedback=value;}
			get{return _feedback;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateUserID
		{
			set{ _createuserid=value;}
			get{return _createuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperateIP
		{
			set{ _operateip=value;}
			get{return _operateip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientID
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		#endregion Model

	}
}
