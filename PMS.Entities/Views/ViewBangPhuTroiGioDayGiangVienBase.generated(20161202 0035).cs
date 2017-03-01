﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewBangPhuTroiGioDayGiangVien.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace PMS.Entities
{
	///<summary>
	/// An object representation of the 'View_BangPhuTroiGioDay_GiangVien' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewBangPhuTroiGioDayGiangVienBase")]
	public abstract partial class ViewBangPhuTroiGioDayGiangVienBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32		  _maGiangVien = (int)0;
		
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		private System.String		  _maQuanLy = string.Empty;
		
		/// <summary>
		/// Ho : 
		/// </summary>
		private System.String		  _ho = null;
		
		/// <summary>
		/// Ten : 
		/// </summary>
		private System.String		  _ten = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		private System.String		  _maDonVi = null;
		
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		private System.String		  _tenDonVi = string.Empty;
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		private System.Int32		  _maLoaiGiangVien = (int)0;
		
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		private System.String		  _tenLoaiGiangVien = null;
		
		/// <summary>
		/// TCThucDay : 
		/// </summary>
		private System.Decimal?		  _tcThucDay = null;
		
		/// <summary>
		/// TietQD : 
		/// </summary>
		private System.Decimal?		  _tietQd = null;
		
		/// <summary>
		/// NhiemVuGD : 
		/// </summary>
		private System.Int32?		  _nhiemVuGd = null;
		
		/// <summary>
		/// NhiemVuNCKH : 
		/// </summary>
		private System.Decimal?		  _nhiemVuNckh = null;
		
		/// <summary>
		/// PhanCongCN : 
		/// </summary>
		private System.Int32?		  _phanCongCn = null;
		
		/// <summary>
		/// CongTrinhCD : 
		/// </summary>
		private System.Int32?		  _congTrinhCd = null;
		
		/// <summary>
		/// CongTrinhTC : 
		/// </summary>
		private System.Int32?		  _congTrinhTc = null;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> instance.
		///</summary>
		public ViewBangPhuTroiGioDayGiangVienBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_namHoc"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_tcThucDay"></param>
		///<param name="_tietQd"></param>
		///<param name="_nhiemVuGd"></param>
		///<param name="_nhiemVuNckh"></param>
		///<param name="_phanCongCn"></param>
		///<param name="_congTrinhCd"></param>
		///<param name="_congTrinhTc"></param>
		public ViewBangPhuTroiGioDayGiangVienBase(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _namHoc, System.String _maDonVi, System.String _tenDonVi, System.Int32 _maLoaiGiangVien, System.String _tenLoaiGiangVien, System.Decimal? _tcThucDay, System.Decimal? _tietQd, System.Int32? _nhiemVuGd, System.Decimal? _nhiemVuNckh, System.Int32? _phanCongCn, System.Int32? _congTrinhCd, System.Int32? _congTrinhTc)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._ho = _ho;
			this._ten = _ten;
			this._namHoc = _namHoc;
			this._maDonVi = _maDonVi;
			this._tenDonVi = _tenDonVi;
			this._maLoaiGiangVien = _maLoaiGiangVien;
			this._tenLoaiGiangVien = _tenLoaiGiangVien;
			this._tcThucDay = _tcThucDay;
			this._tietQd = _tietQd;
			this._nhiemVuGd = _nhiemVuGd;
			this._nhiemVuNckh = _nhiemVuNckh;
			this._phanCongCn = _phanCongCn;
			this._congTrinhCd = _congTrinhCd;
			this._congTrinhTc = _congTrinhTc;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewBangPhuTroiGioDayGiangVien"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_namHoc"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_tcThucDay"></param>
		///<param name="_tietQd"></param>
		///<param name="_nhiemVuGd"></param>
		///<param name="_nhiemVuNckh"></param>
		///<param name="_phanCongCn"></param>
		///<param name="_congTrinhCd"></param>
		///<param name="_congTrinhTc"></param>
		public static ViewBangPhuTroiGioDayGiangVien CreateViewBangPhuTroiGioDayGiangVien(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _namHoc, System.String _maDonVi, System.String _tenDonVi, System.Int32 _maLoaiGiangVien, System.String _tenLoaiGiangVien, System.Decimal? _tcThucDay, System.Decimal? _tietQd, System.Int32? _nhiemVuGd, System.Decimal? _nhiemVuNckh, System.Int32? _phanCongCn, System.Int32? _congTrinhCd, System.Int32? _congTrinhTc)
		{
			ViewBangPhuTroiGioDayGiangVien newViewBangPhuTroiGioDayGiangVien = new ViewBangPhuTroiGioDayGiangVien();
			newViewBangPhuTroiGioDayGiangVien.MaGiangVien = _maGiangVien;
			newViewBangPhuTroiGioDayGiangVien.MaQuanLy = _maQuanLy;
			newViewBangPhuTroiGioDayGiangVien.Ho = _ho;
			newViewBangPhuTroiGioDayGiangVien.Ten = _ten;
			newViewBangPhuTroiGioDayGiangVien.NamHoc = _namHoc;
			newViewBangPhuTroiGioDayGiangVien.MaDonVi = _maDonVi;
			newViewBangPhuTroiGioDayGiangVien.TenDonVi = _tenDonVi;
			newViewBangPhuTroiGioDayGiangVien.MaLoaiGiangVien = _maLoaiGiangVien;
			newViewBangPhuTroiGioDayGiangVien.TenLoaiGiangVien = _tenLoaiGiangVien;
			newViewBangPhuTroiGioDayGiangVien.TcThucDay = _tcThucDay;
			newViewBangPhuTroiGioDayGiangVien.TietQd = _tietQd;
			newViewBangPhuTroiGioDayGiangVien.NhiemVuGd = _nhiemVuGd;
			newViewBangPhuTroiGioDayGiangVien.NhiemVuNckh = _nhiemVuNckh;
			newViewBangPhuTroiGioDayGiangVien.PhanCongCn = _phanCongCn;
			newViewBangPhuTroiGioDayGiangVien.CongTrinhCd = _congTrinhCd;
			newViewBangPhuTroiGioDayGiangVien.CongTrinhTc = _congTrinhTc;
			return newViewBangPhuTroiGioDayGiangVien;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if (_maGiangVien == value)
					return;
					
				this._maGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaQuanLy
		{
			get
			{
				return this._maQuanLy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaQuanLy does not allow null values.");
				if (_maQuanLy == value)
					return;
					
				this._maQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaQuanLy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Ho property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Ho
		{
			get
			{
				return this._ho; 
			}
			set
			{
				if (_ho == value)
					return;
					
				this._ho = value;
				this._isDirty = true;
				
				OnPropertyChanged("Ho");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Ten property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Ten
		{
			get
			{
				return this._ten; 
			}
			set
			{
				if (_ten == value)
					return;
					
				this._ten = value;
				this._isDirty = true;
				
				OnPropertyChanged("Ten");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NamHoc
		{
			get
			{
				return this._namHoc; 
			}
			set
			{
				if (_namHoc == value)
					return;
					
				this._namHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NamHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaDonVi property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaDonVi
		{
			get
			{
				return this._maDonVi; 
			}
			set
			{
				if (_maDonVi == value)
					return;
					
				this._maDonVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaDonVi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenDonVi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenDonVi
		{
			get
			{
				return this._tenDonVi; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenDonVi does not allow null values.");
				if (_tenDonVi == value)
					return;
					
				this._tenDonVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenDonVi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLoaiGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaLoaiGiangVien
		{
			get
			{
				return this._maLoaiGiangVien; 
			}
			set
			{
				if (_maLoaiGiangVien == value)
					return;
					
				this._maLoaiGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLoaiGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLoaiGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLoaiGiangVien
		{
			get
			{
				return this._tenLoaiGiangVien; 
			}
			set
			{
				if (_tenLoaiGiangVien == value)
					return;
					
				this._tenLoaiGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLoaiGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TCThucDay property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTcThucDayNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TcThucDay
		{
			get
			{
				return this._tcThucDay; 
			}
			set
			{
				if (_tcThucDay == value && TcThucDay != null )
					return;
					
				this._tcThucDay = value;
				this._isDirty = true;
				
				OnPropertyChanged("TcThucDay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TietQD property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsTietQdNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? TietQd
		{
			get
			{
				return this._tietQd; 
			}
			set
			{
				if (_tietQd == value && TietQd != null )
					return;
					
				this._tietQd = value;
				this._isDirty = true;
				
				OnPropertyChanged("TietQd");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NhiemVuGD property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsNhiemVuGdNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? NhiemVuGd
		{
			get
			{
				return this._nhiemVuGd; 
			}
			set
			{
				if (_nhiemVuGd == value && NhiemVuGd != null )
					return;
					
				this._nhiemVuGd = value;
				this._isDirty = true;
				
				OnPropertyChanged("NhiemVuGd");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NhiemVuNCKH property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsNhiemVuNckhNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? NhiemVuNckh
		{
			get
			{
				return this._nhiemVuNckh; 
			}
			set
			{
				if (_nhiemVuNckh == value && NhiemVuNckh != null )
					return;
					
				this._nhiemVuNckh = value;
				this._isDirty = true;
				
				OnPropertyChanged("NhiemVuNckh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the PhanCongCN property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsPhanCongCnNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? PhanCongCn
		{
			get
			{
				return this._phanCongCn; 
			}
			set
			{
				if (_phanCongCn == value && PhanCongCn != null )
					return;
					
				this._phanCongCn = value;
				this._isDirty = true;
				
				OnPropertyChanged("PhanCongCn");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CongTrinhCD property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsCongTrinhCdNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? CongTrinhCd
		{
			get
			{
				return this._congTrinhCd; 
			}
			set
			{
				if (_congTrinhCd == value && CongTrinhCd != null )
					return;
					
				this._congTrinhCd = value;
				this._isDirty = true;
				
				OnPropertyChanged("CongTrinhCd");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CongTrinhTC property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsCongTrinhTcNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? CongTrinhTc
		{
			get
			{
				return this._congTrinhTc; 
			}
			set
			{
				if (_congTrinhTc == value && CongTrinhTc != null )
					return;
					
				this._congTrinhTc = value;
				this._isDirty = true;
				
				OnPropertyChanged("CongTrinhTc");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "View_BangPhuTroiGioDay_GiangVien"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed ViewBangPhuTroiGioDayGiangVienBase Entity 
		///</summary>
		public virtual ViewBangPhuTroiGioDayGiangVienBase Copy()
		{
			//shallow copy entity
			ViewBangPhuTroiGioDayGiangVien copy = new ViewBangPhuTroiGioDayGiangVien();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.NamHoc = this.NamHoc;
				copy.MaDonVi = this.MaDonVi;
				copy.TenDonVi = this.TenDonVi;
				copy.MaLoaiGiangVien = this.MaLoaiGiangVien;
				copy.TenLoaiGiangVien = this.TenLoaiGiangVien;
				copy.TcThucDay = this.TcThucDay;
				copy.TietQd = this.TietQd;
				copy.NhiemVuGd = this.NhiemVuGd;
				copy.NhiemVuNckh = this.NhiemVuNckh;
				copy.PhanCongCn = this.PhanCongCn;
				copy.CongTrinhCd = this.CongTrinhCd;
				copy.CongTrinhTc = this.CongTrinhTc;
			copy.AcceptChanges();
			return (ViewBangPhuTroiGioDayGiangVien)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewBangPhuTroiGioDayGiangVienBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewBangPhuTroiGioDayGiangVienBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewBangPhuTroiGioDayGiangVienBase Object1, ViewBangPhuTroiGioDayGiangVienBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
			if (Object1.MaQuanLy != Object2.MaQuanLy)
				equal = false;
			if (Object1.Ho != null && Object2.Ho != null )
			{
				if (Object1.Ho != Object2.Ho)
					equal = false;
			}
			else if (Object1.Ho == null ^ Object1.Ho == null )
			{
				equal = false;
			}
			if (Object1.Ten != null && Object2.Ten != null )
			{
				if (Object1.Ten != Object2.Ten)
					equal = false;
			}
			else if (Object1.Ten == null ^ Object1.Ten == null )
			{
				equal = false;
			}
			if (Object1.NamHoc != null && Object2.NamHoc != null )
			{
				if (Object1.NamHoc != Object2.NamHoc)
					equal = false;
			}
			else if (Object1.NamHoc == null ^ Object1.NamHoc == null )
			{
				equal = false;
			}
			if (Object1.MaDonVi != null && Object2.MaDonVi != null )
			{
				if (Object1.MaDonVi != Object2.MaDonVi)
					equal = false;
			}
			else if (Object1.MaDonVi == null ^ Object1.MaDonVi == null )
			{
				equal = false;
			}
			if (Object1.TenDonVi != Object2.TenDonVi)
				equal = false;
			if (Object1.MaLoaiGiangVien != Object2.MaLoaiGiangVien)
				equal = false;
			if (Object1.TenLoaiGiangVien != null && Object2.TenLoaiGiangVien != null )
			{
				if (Object1.TenLoaiGiangVien != Object2.TenLoaiGiangVien)
					equal = false;
			}
			else if (Object1.TenLoaiGiangVien == null ^ Object1.TenLoaiGiangVien == null )
			{
				equal = false;
			}
			if (Object1.TcThucDay != null && Object2.TcThucDay != null )
			{
				if (Object1.TcThucDay != Object2.TcThucDay)
					equal = false;
			}
			else if (Object1.TcThucDay == null ^ Object1.TcThucDay == null )
			{
				equal = false;
			}
			if (Object1.TietQd != null && Object2.TietQd != null )
			{
				if (Object1.TietQd != Object2.TietQd)
					equal = false;
			}
			else if (Object1.TietQd == null ^ Object1.TietQd == null )
			{
				equal = false;
			}
			if (Object1.NhiemVuGd != null && Object2.NhiemVuGd != null )
			{
				if (Object1.NhiemVuGd != Object2.NhiemVuGd)
					equal = false;
			}
			else if (Object1.NhiemVuGd == null ^ Object1.NhiemVuGd == null )
			{
				equal = false;
			}
			if (Object1.NhiemVuNckh != null && Object2.NhiemVuNckh != null )
			{
				if (Object1.NhiemVuNckh != Object2.NhiemVuNckh)
					equal = false;
			}
			else if (Object1.NhiemVuNckh == null ^ Object1.NhiemVuNckh == null )
			{
				equal = false;
			}
			if (Object1.PhanCongCn != null && Object2.PhanCongCn != null )
			{
				if (Object1.PhanCongCn != Object2.PhanCongCn)
					equal = false;
			}
			else if (Object1.PhanCongCn == null ^ Object1.PhanCongCn == null )
			{
				equal = false;
			}
			if (Object1.CongTrinhCd != null && Object2.CongTrinhCd != null )
			{
				if (Object1.CongTrinhCd != Object2.CongTrinhCd)
					equal = false;
			}
			else if (Object1.CongTrinhCd == null ^ Object1.CongTrinhCd == null )
			{
				equal = false;
			}
			if (Object1.CongTrinhTc != null && Object2.CongTrinhTc != null )
			{
				if (Object1.CongTrinhTc != Object2.CongTrinhTc)
					equal = false;
			}
			else if (Object1.CongTrinhTc == null ^ Object1.CongTrinhTc == null )
			{
				equal = false;
			}
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(ViewBangPhuTroiGioDayGiangVien entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaQuanLy":
					return entity.MaQuanLy;
				case "Ho":
					return entity.Ho;
				case "Ten":
					return entity.Ten;
				case "NamHoc":
					return entity.NamHoc;
				case "MaDonVi":
					return entity.MaDonVi;
				case "TenDonVi":
					return entity.TenDonVi;
				case "MaLoaiGiangVien":
					return entity.MaLoaiGiangVien;
				case "TenLoaiGiangVien":
					return entity.TenLoaiGiangVien;
				case "TcThucDay":
					return entity.TcThucDay;
				case "TietQd":
					return entity.TietQd;
				case "NhiemVuGd":
					return entity.NhiemVuGd;
				case "NhiemVuNckh":
					return entity.NhiemVuNckh;
				case "PhanCongCn":
					return entity.PhanCongCn;
				case "CongTrinhCd":
					return entity.CongTrinhCd;
				case "CongTrinhTc":
					return entity.CongTrinhTc;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as ViewBangPhuTroiGioDayGiangVien, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{17}{16}- MaGiangVien: {0}{16}- MaQuanLy: {1}{16}- Ho: {2}{16}- Ten: {3}{16}- NamHoc: {4}{16}- MaDonVi: {5}{16}- TenDonVi: {6}{16}- MaLoaiGiangVien: {7}{16}- TenLoaiGiangVien: {8}{16}- TcThucDay: {9}{16}- TietQd: {10}{16}- NhiemVuGd: {11}{16}- NhiemVuNckh: {12}{16}- PhanCongCn: {13}{16}- CongTrinhCd: {14}{16}- CongTrinhTc: {15}{16}", 
				this.MaGiangVien,
				this.MaQuanLy,
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.MaDonVi == null) ? string.Empty : this.MaDonVi.ToString(),
			     
				this.TenDonVi,
				this.MaLoaiGiangVien,
				(this.TenLoaiGiangVien == null) ? string.Empty : this.TenLoaiGiangVien.ToString(),
			     
				(this.TcThucDay == null) ? string.Empty : this.TcThucDay.ToString(),
			     
				(this.TietQd == null) ? string.Empty : this.TietQd.ToString(),
			     
				(this.NhiemVuGd == null) ? string.Empty : this.NhiemVuGd.ToString(),
			     
				(this.NhiemVuNckh == null) ? string.Empty : this.NhiemVuNckh.ToString(),
			     
				(this.PhanCongCn == null) ? string.Empty : this.PhanCongCn.ToString(),
			     
				(this.CongTrinhCd == null) ? string.Empty : this.CongTrinhCd.ToString(),
			     
				(this.CongTrinhTc == null) ? string.Empty : this.CongTrinhTc.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewBangPhuTroiGioDayGiangVien columns.
	/// </summary>
	[Serializable]
	public enum ViewBangPhuTroiGioDayGiangVienColumn
	{
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaGiangVien,
		/// <summary>
		/// MaQuanLy : 
		/// </summary>
		[EnumTextValue("MaQuanLy")]
		[ColumnEnum("MaQuanLy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaQuanLy,
		/// <summary>
		/// Ho : 
		/// </summary>
		[EnumTextValue("Ho")]
		[ColumnEnum("Ho", typeof(System.String), System.Data.DbType.String, false, false, true, 101)]
		Ho,
		/// <summary>
		/// Ten : 
		/// </summary>
		[EnumTextValue("Ten")]
		[ColumnEnum("Ten", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		Ten,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		[EnumTextValue("MaDonVi")]
		[ColumnEnum("MaDonVi", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaDonVi,
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		[EnumTextValue("TenDonVi")]
		[ColumnEnum("TenDonVi", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenDonVi,
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		[EnumTextValue("MaLoaiGiangVien")]
		[ColumnEnum("MaLoaiGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaLoaiGiangVien,
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		[EnumTextValue("TenLoaiGiangVien")]
		[ColumnEnum("TenLoaiGiangVien", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenLoaiGiangVien,
		/// <summary>
		/// TCThucDay : 
		/// </summary>
		[EnumTextValue("TCThucDay")]
		[ColumnEnum("TCThucDay", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TcThucDay,
		/// <summary>
		/// TietQD : 
		/// </summary>
		[EnumTextValue("TietQD")]
		[ColumnEnum("TietQD", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		TietQd,
		/// <summary>
		/// NhiemVuGD : 
		/// </summary>
		[EnumTextValue("NhiemVuGD")]
		[ColumnEnum("NhiemVuGD", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		NhiemVuGd,
		/// <summary>
		/// NhiemVuNCKH : 
		/// </summary>
		[EnumTextValue("NhiemVuNCKH")]
		[ColumnEnum("NhiemVuNCKH", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		NhiemVuNckh,
		/// <summary>
		/// PhanCongCN : 
		/// </summary>
		[EnumTextValue("PhanCongCN")]
		[ColumnEnum("PhanCongCN", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		PhanCongCn,
		/// <summary>
		/// CongTrinhCD : 
		/// </summary>
		[EnumTextValue("CongTrinhCD")]
		[ColumnEnum("CongTrinhCD", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		CongTrinhCd,
		/// <summary>
		/// CongTrinhTC : 
		/// </summary>
		[EnumTextValue("CongTrinhTC")]
		[ColumnEnum("CongTrinhTC", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		CongTrinhTc
	}//End enum

} // end namespace
