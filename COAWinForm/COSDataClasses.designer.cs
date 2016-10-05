﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COAWinForm
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="COAdatabase")]
	public partial class COSDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLeadger(Leadger instance);
    partial void UpdateLeadger(Leadger instance);
    partial void DeleteLeadger(Leadger instance);
    partial void InsertChartOfAccount(ChartOfAccount instance);
    partial void UpdateChartOfAccount(ChartOfAccount instance);
    partial void DeleteChartOfAccount(ChartOfAccount instance);
    #endregion
		
		public COSDataClassesDataContext() : 
				base(global::COAWinForm.Properties.Settings.Default.COAdatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public COSDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public COSDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public COSDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public COSDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Leadger> Leadgers
		{
			get
			{
				return this.GetTable<Leadger>();
			}
		}
		
		public System.Data.Linq.Table<ChartOfAccount> ChartOfAccounts
		{
			get
			{
				return this.GetTable<ChartOfAccount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Leadger")]
	public partial class Leadger : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Tran_ID;
		
		private System.Nullable<System.DateTime> _Tran_Date;
		
		private string _Source_ID;
		
		private string _Source_Name;
		
		private string _Describtion;
		
		private string _Destination_ID;
		
		private string _Destination_Name;
		
		private System.Nullable<decimal> _Dr;
		
		private System.Nullable<decimal> _Cr;
		
		private System.Nullable<decimal> _Balance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTran_IDChanging(int value);
    partial void OnTran_IDChanged();
    partial void OnTran_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnTran_DateChanged();
    partial void OnSource_IDChanging(string value);
    partial void OnSource_IDChanged();
    partial void OnSource_NameChanging(string value);
    partial void OnSource_NameChanged();
    partial void OnDescribtionChanging(string value);
    partial void OnDescribtionChanged();
    partial void OnDestination_IDChanging(string value);
    partial void OnDestination_IDChanged();
    partial void OnDestination_NameChanging(string value);
    partial void OnDestination_NameChanged();
    partial void OnDrChanging(System.Nullable<decimal> value);
    partial void OnDrChanged();
    partial void OnCrChanging(System.Nullable<decimal> value);
    partial void OnCrChanged();
    partial void OnBalanceChanging(System.Nullable<decimal> value);
    partial void OnBalanceChanged();
    #endregion
		
		public Leadger()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tran_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Tran_ID
		{
			get
			{
				return this._Tran_ID;
			}
			set
			{
				if ((this._Tran_ID != value))
				{
					this.OnTran_IDChanging(value);
					this.SendPropertyChanging();
					this._Tran_ID = value;
					this.SendPropertyChanged("Tran_ID");
					this.OnTran_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tran_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Tran_Date
		{
			get
			{
				return this._Tran_Date;
			}
			set
			{
				if ((this._Tran_Date != value))
				{
					this.OnTran_DateChanging(value);
					this.SendPropertyChanging();
					this._Tran_Date = value;
					this.SendPropertyChanged("Tran_Date");
					this.OnTran_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source_ID", DbType="NChar(10)")]
		public string Source_ID
		{
			get
			{
				return this._Source_ID;
			}
			set
			{
				if ((this._Source_ID != value))
				{
					this.OnSource_IDChanging(value);
					this.SendPropertyChanging();
					this._Source_ID = value;
					this.SendPropertyChanged("Source_ID");
					this.OnSource_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source_Name", DbType="NVarChar(50)")]
		public string Source_Name
		{
			get
			{
				return this._Source_Name;
			}
			set
			{
				if ((this._Source_Name != value))
				{
					this.OnSource_NameChanging(value);
					this.SendPropertyChanging();
					this._Source_Name = value;
					this.SendPropertyChanged("Source_Name");
					this.OnSource_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Describtion", DbType="NVarChar(50)")]
		public string Describtion
		{
			get
			{
				return this._Describtion;
			}
			set
			{
				if ((this._Describtion != value))
				{
					this.OnDescribtionChanging(value);
					this.SendPropertyChanging();
					this._Describtion = value;
					this.SendPropertyChanged("Describtion");
					this.OnDescribtionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destination_ID", DbType="NChar(10)")]
		public string Destination_ID
		{
			get
			{
				return this._Destination_ID;
			}
			set
			{
				if ((this._Destination_ID != value))
				{
					this.OnDestination_IDChanging(value);
					this.SendPropertyChanging();
					this._Destination_ID = value;
					this.SendPropertyChanged("Destination_ID");
					this.OnDestination_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destination_Name", DbType="NVarChar(50)")]
		public string Destination_Name
		{
			get
			{
				return this._Destination_Name;
			}
			set
			{
				if ((this._Destination_Name != value))
				{
					this.OnDestination_NameChanging(value);
					this.SendPropertyChanging();
					this._Destination_Name = value;
					this.SendPropertyChanged("Destination_Name");
					this.OnDestination_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dr", DbType="Money")]
		public System.Nullable<decimal> Dr
		{
			get
			{
				return this._Dr;
			}
			set
			{
				if ((this._Dr != value))
				{
					this.OnDrChanging(value);
					this.SendPropertyChanging();
					this._Dr = value;
					this.SendPropertyChanged("Dr");
					this.OnDrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cr", DbType="Money")]
		public System.Nullable<decimal> Cr
		{
			get
			{
				return this._Cr;
			}
			set
			{
				if ((this._Cr != value))
				{
					this.OnCrChanging(value);
					this.SendPropertyChanging();
					this._Cr = value;
					this.SendPropertyChanged("Cr");
					this.OnCrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Money")]
		public System.Nullable<decimal> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChartOfAccounts")]
	public partial class ChartOfAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Acct_ID;
		
		private string _Acct_Name;
		
		private string _Parent_ID;
		
		private System.Nullable<decimal> _Balance;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAcct_IDChanging(string value);
    partial void OnAcct_IDChanged();
    partial void OnAcct_NameChanging(string value);
    partial void OnAcct_NameChanged();
    partial void OnParent_IDChanging(string value);
    partial void OnParent_IDChanged();
    partial void OnBalanceChanging(System.Nullable<decimal> value);
    partial void OnBalanceChanged();
    #endregion
		
		public ChartOfAccount()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acct_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Acct_ID
		{
			get
			{
				return this._Acct_ID;
			}
			set
			{
				if ((this._Acct_ID != value))
				{
					this.OnAcct_IDChanging(value);
					this.SendPropertyChanging();
					this._Acct_ID = value;
					this.SendPropertyChanged("Acct_ID");
					this.OnAcct_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acct_Name", DbType="NVarChar(50)")]
		public string Acct_Name
		{
			get
			{
				return this._Acct_Name;
			}
			set
			{
				if ((this._Acct_Name != value))
				{
					this.OnAcct_NameChanging(value);
					this.SendPropertyChanging();
					this._Acct_Name = value;
					this.SendPropertyChanged("Acct_Name");
					this.OnAcct_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent_ID", DbType="NChar(10)")]
		public string Parent_ID
		{
			get
			{
				return this._Parent_ID;
			}
			set
			{
				if ((this._Parent_ID != value))
				{
					this.OnParent_IDChanging(value);
					this.SendPropertyChanging();
					this._Parent_ID = value;
					this.SendPropertyChanged("Parent_ID");
					this.OnParent_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Money")]
		public System.Nullable<decimal> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
