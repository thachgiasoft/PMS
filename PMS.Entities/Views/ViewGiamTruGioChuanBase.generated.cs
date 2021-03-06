﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewGiamTruGioChuan.cs instead.
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
	/// An object representation of the 'View_GiamTruGioChuan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewGiamTruGioChuanBase")]
	public abstract partial class ViewGiamTruGioChuanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32?		  _maGiangVien = null;
		
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
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// TenHocHam : 
		/// </summary>
		private System.String		  _tenHocHam = null;
		
		/// <summary>
		/// TenHocVi : 
		/// </summary>
		private System.String		  _tenHocVi = null;
		
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		private System.String		  _tenLoaiGiangVien = null;
		
		/// <summary>
		/// MaDonVi : 
		/// </summary>
		private System.String		  _maDonVi = null;
		
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		private System.String		  _tenDonVi = string.Empty;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// GioGiamChatLuongCao : 
		/// </summary>
		private System.Decimal?		  _gioGiamChatLuongCao = null;
		
		/// <summary>
		/// GioGiamSauDaiHoc : 
		/// </summary>
		private System.Decimal?		  _gioGiamSauDaiHoc = null;
		
		/// <summary>
		/// GioGiamNckh : 
		/// </summary>
		private System.Decimal?		  _gioGiamNckh = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		private System.String		  _ghiChu = null;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.DateTime?		  _ngayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		private System.String		  _nguoiCapNhat = null;
		
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
		/// Creates a new <see cref="ViewGiamTruGioChuanBase"/> instance.
		///</summary>
		public ViewGiamTruGioChuanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewGiamTruGioChuanBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_gioGiamChatLuongCao"></param>
		///<param name="_gioGiamSauDaiHoc"></param>
		///<param name="_gioGiamNckh"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public ViewGiamTruGioChuanBase(System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _maDonVi, System.String _tenDonVi, System.String _namHoc, System.String _hocKy, System.Decimal? _gioGiamChatLuongCao, System.Decimal? _gioGiamSauDaiHoc, System.Decimal? _gioGiamNckh, System.String _ghiChu, System.DateTime? _ngayCapNhat, System.String _nguoiCapNhat)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._ho = _ho;
			this._ten = _ten;
			this._hoTen = _hoTen;
			this._tenHocHam = _tenHocHam;
			this._tenHocVi = _tenHocVi;
			this._tenLoaiGiangVien = _tenLoaiGiangVien;
			this._maDonVi = _maDonVi;
			this._tenDonVi = _tenDonVi;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._gioGiamChatLuongCao = _gioGiamChatLuongCao;
			this._gioGiamSauDaiHoc = _gioGiamSauDaiHoc;
			this._gioGiamNckh = _gioGiamNckh;
			this._ghiChu = _ghiChu;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiamTruGioChuan"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_tenHocHam"></param>
		///<param name="_tenHocVi"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maDonVi"></param>
		///<param name="_tenDonVi"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_gioGiamChatLuongCao"></param>
		///<param name="_gioGiamSauDaiHoc"></param>
		///<param name="_gioGiamNckh"></param>
		///<param name="_ghiChu"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static ViewGiamTruGioChuan CreateViewGiamTruGioChuan(System.Int32? _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.String _tenHocHam, System.String _tenHocVi, System.String _tenLoaiGiangVien, System.String _maDonVi, System.String _tenDonVi, System.String _namHoc, System.String _hocKy, System.Decimal? _gioGiamChatLuongCao, System.Decimal? _gioGiamSauDaiHoc, System.Decimal? _gioGiamNckh, System.String _ghiChu, System.DateTime? _ngayCapNhat, System.String _nguoiCapNhat)
		{
			ViewGiamTruGioChuan newViewGiamTruGioChuan = new ViewGiamTruGioChuan();
			newViewGiamTruGioChuan.MaGiangVien = _maGiangVien;
			newViewGiamTruGioChuan.MaQuanLy = _maQuanLy;
			newViewGiamTruGioChuan.Ho = _ho;
			newViewGiamTruGioChuan.Ten = _ten;
			newViewGiamTruGioChuan.HoTen = _hoTen;
			newViewGiamTruGioChuan.TenHocHam = _tenHocHam;
			newViewGiamTruGioChuan.TenHocVi = _tenHocVi;
			newViewGiamTruGioChuan.TenLoaiGiangVien = _tenLoaiGiangVien;
			newViewGiamTruGioChuan.MaDonVi = _maDonVi;
			newViewGiamTruGioChuan.TenDonVi = _tenDonVi;
			newViewGiamTruGioChuan.NamHoc = _namHoc;
			newViewGiamTruGioChuan.HocKy = _hocKy;
			newViewGiamTruGioChuan.GioGiamChatLuongCao = _gioGiamChatLuongCao;
			newViewGiamTruGioChuan.GioGiamSauDaiHoc = _gioGiamSauDaiHoc;
			newViewGiamTruGioChuan.GioGiamNckh = _gioGiamNckh;
			newViewGiamTruGioChuan.GhiChu = _ghiChu;
			newViewGiamTruGioChuan.NgayCapNhat = _ngayCapNhat;
			newViewGiamTruGioChuan.NguoiCapNhat = _nguoiCapNhat;
			return newViewGiamTruGioChuan;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaGiangVienNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if (_maGiangVien == value && MaGiangVien != null )
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
		/// 	Gets or Sets the HoTen property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HoTen
		{
			get
			{
				return this._hoTen; 
			}
			set
			{
				if (_hoTen == value)
					return;
					
				this._hoTen = value;
				this._isDirty = true;
				
				OnPropertyChanged("HoTen");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHocHam property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHocHam
		{
			get
			{
				return this._tenHocHam; 
			}
			set
			{
				if (_tenHocHam == value)
					return;
					
				this._tenHocHam = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHocHam");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHocVi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHocVi
		{
			get
			{
				return this._tenHocVi; 
			}
			set
			{
				if (_tenHocVi == value)
					return;
					
				this._tenHocVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHocVi");
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
		/// 	Gets or Sets the HocKy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HocKy
		{
			get
			{
				return this._hocKy; 
			}
			set
			{
				if (_hocKy == value)
					return;
					
				this._hocKy = value;
				this._isDirty = true;
				
				OnPropertyChanged("HocKy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GioGiamChatLuongCao property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsGioGiamChatLuongCaoNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? GioGiamChatLuongCao
		{
			get
			{
				return this._gioGiamChatLuongCao; 
			}
			set
			{
				if (_gioGiamChatLuongCao == value && GioGiamChatLuongCao != null )
					return;
					
				this._gioGiamChatLuongCao = value;
				this._isDirty = true;
				
				OnPropertyChanged("GioGiamChatLuongCao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GioGiamSauDaiHoc property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsGioGiamSauDaiHocNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? GioGiamSauDaiHoc
		{
			get
			{
				return this._gioGiamSauDaiHoc; 
			}
			set
			{
				if (_gioGiamSauDaiHoc == value && GioGiamSauDaiHoc != null )
					return;
					
				this._gioGiamSauDaiHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("GioGiamSauDaiHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GioGiamNckh property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsGioGiamNckhNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? GioGiamNckh
		{
			get
			{
				return this._gioGiamNckh; 
			}
			set
			{
				if (_gioGiamNckh == value && GioGiamNckh != null )
					return;
					
				this._gioGiamNckh = value;
				this._isDirty = true;
				
				OnPropertyChanged("GioGiamNckh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the GhiChu property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String GhiChu
		{
			get
			{
				return this._ghiChu; 
			}
			set
			{
				if (_ghiChu == value)
					return;
					
				this._ghiChu = value;
				this._isDirty = true;
				
				OnPropertyChanged("GhiChu");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayCapNhatNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayCapNhat
		{
			get
			{
				return this._ngayCapNhat; 
			}
			set
			{
				if (_ngayCapNhat == value && NgayCapNhat != null )
					return;
					
				this._ngayCapNhat = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayCapNhat");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NguoiCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NguoiCapNhat
		{
			get
			{
				return this._nguoiCapNhat; 
			}
			set
			{
				if (_nguoiCapNhat == value)
					return;
					
				this._nguoiCapNhat = value;
				this._isDirty = true;
				
				OnPropertyChanged("NguoiCapNhat");
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
			get { return "View_GiamTruGioChuan"; }
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
		///  Returns a Typed ViewGiamTruGioChuanBase Entity 
		///</summary>
		public virtual ViewGiamTruGioChuanBase Copy()
		{
			//shallow copy entity
			ViewGiamTruGioChuan copy = new ViewGiamTruGioChuan();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.HoTen = this.HoTen;
				copy.TenHocHam = this.TenHocHam;
				copy.TenHocVi = this.TenHocVi;
				copy.TenLoaiGiangVien = this.TenLoaiGiangVien;
				copy.MaDonVi = this.MaDonVi;
				copy.TenDonVi = this.TenDonVi;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.GioGiamChatLuongCao = this.GioGiamChatLuongCao;
				copy.GioGiamSauDaiHoc = this.GioGiamSauDaiHoc;
				copy.GioGiamNckh = this.GioGiamNckh;
				copy.GhiChu = this.GhiChu;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
			copy.AcceptChanges();
			return (ViewGiamTruGioChuan)copy;
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
		///<returns>true if toObject is a <see cref="ViewGiamTruGioChuanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewGiamTruGioChuanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewGiamTruGioChuanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewGiamTruGioChuanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewGiamTruGioChuanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewGiamTruGioChuanBase Object1, ViewGiamTruGioChuanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaGiangVien != null && Object2.MaGiangVien != null )
			{
				if (Object1.MaGiangVien != Object2.MaGiangVien)
					equal = false;
			}
			else if (Object1.MaGiangVien == null ^ Object1.MaGiangVien == null )
			{
				equal = false;
			}
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
			if (Object1.HoTen != null && Object2.HoTen != null )
			{
				if (Object1.HoTen != Object2.HoTen)
					equal = false;
			}
			else if (Object1.HoTen == null ^ Object1.HoTen == null )
			{
				equal = false;
			}
			if (Object1.TenHocHam != null && Object2.TenHocHam != null )
			{
				if (Object1.TenHocHam != Object2.TenHocHam)
					equal = false;
			}
			else if (Object1.TenHocHam == null ^ Object1.TenHocHam == null )
			{
				equal = false;
			}
			if (Object1.TenHocVi != null && Object2.TenHocVi != null )
			{
				if (Object1.TenHocVi != Object2.TenHocVi)
					equal = false;
			}
			else if (Object1.TenHocVi == null ^ Object1.TenHocVi == null )
			{
				equal = false;
			}
			if (Object1.TenLoaiGiangVien != null && Object2.TenLoaiGiangVien != null )
			{
				if (Object1.TenLoaiGiangVien != Object2.TenLoaiGiangVien)
					equal = false;
			}
			else if (Object1.TenLoaiGiangVien == null ^ Object1.TenLoaiGiangVien == null )
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
			if (Object1.NamHoc != null && Object2.NamHoc != null )
			{
				if (Object1.NamHoc != Object2.NamHoc)
					equal = false;
			}
			else if (Object1.NamHoc == null ^ Object1.NamHoc == null )
			{
				equal = false;
			}
			if (Object1.HocKy != null && Object2.HocKy != null )
			{
				if (Object1.HocKy != Object2.HocKy)
					equal = false;
			}
			else if (Object1.HocKy == null ^ Object1.HocKy == null )
			{
				equal = false;
			}
			if (Object1.GioGiamChatLuongCao != null && Object2.GioGiamChatLuongCao != null )
			{
				if (Object1.GioGiamChatLuongCao != Object2.GioGiamChatLuongCao)
					equal = false;
			}
			else if (Object1.GioGiamChatLuongCao == null ^ Object1.GioGiamChatLuongCao == null )
			{
				equal = false;
			}
			if (Object1.GioGiamSauDaiHoc != null && Object2.GioGiamSauDaiHoc != null )
			{
				if (Object1.GioGiamSauDaiHoc != Object2.GioGiamSauDaiHoc)
					equal = false;
			}
			else if (Object1.GioGiamSauDaiHoc == null ^ Object1.GioGiamSauDaiHoc == null )
			{
				equal = false;
			}
			if (Object1.GioGiamNckh != null && Object2.GioGiamNckh != null )
			{
				if (Object1.GioGiamNckh != Object2.GioGiamNckh)
					equal = false;
			}
			else if (Object1.GioGiamNckh == null ^ Object1.GioGiamNckh == null )
			{
				equal = false;
			}
			if (Object1.GhiChu != null && Object2.GhiChu != null )
			{
				if (Object1.GhiChu != Object2.GhiChu)
					equal = false;
			}
			else if (Object1.GhiChu == null ^ Object1.GhiChu == null )
			{
				equal = false;
			}
			if (Object1.NgayCapNhat != null && Object2.NgayCapNhat != null )
			{
				if (Object1.NgayCapNhat != Object2.NgayCapNhat)
					equal = false;
			}
			else if (Object1.NgayCapNhat == null ^ Object1.NgayCapNhat == null )
			{
				equal = false;
			}
			if (Object1.NguoiCapNhat != null && Object2.NguoiCapNhat != null )
			{
				if (Object1.NguoiCapNhat != Object2.NguoiCapNhat)
					equal = false;
			}
			else if (Object1.NguoiCapNhat == null ^ Object1.NguoiCapNhat == null )
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
		public static object GetPropertyValueByName(ViewGiamTruGioChuan entity, string propertyName)
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
				case "HoTen":
					return entity.HoTen;
				case "TenHocHam":
					return entity.TenHocHam;
				case "TenHocVi":
					return entity.TenHocVi;
				case "TenLoaiGiangVien":
					return entity.TenLoaiGiangVien;
				case "MaDonVi":
					return entity.MaDonVi;
				case "TenDonVi":
					return entity.TenDonVi;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "GioGiamChatLuongCao":
					return entity.GioGiamChatLuongCao;
				case "GioGiamSauDaiHoc":
					return entity.GioGiamSauDaiHoc;
				case "GioGiamNckh":
					return entity.GioGiamNckh;
				case "GhiChu":
					return entity.GhiChu;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "NguoiCapNhat":
					return entity.NguoiCapNhat;
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
			return GetPropertyValueByName(this as ViewGiamTruGioChuan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{19}{18}- MaGiangVien: {0}{18}- MaQuanLy: {1}{18}- Ho: {2}{18}- Ten: {3}{18}- HoTen: {4}{18}- TenHocHam: {5}{18}- TenHocVi: {6}{18}- TenLoaiGiangVien: {7}{18}- MaDonVi: {8}{18}- TenDonVi: {9}{18}- NamHoc: {10}{18}- HocKy: {11}{18}- GioGiamChatLuongCao: {12}{18}- GioGiamSauDaiHoc: {13}{18}- GioGiamNckh: {14}{18}- GhiChu: {15}{18}- NgayCapNhat: {16}{18}- NguoiCapNhat: {17}{18}", 
				(this.MaGiangVien == null) ? string.Empty : this.MaGiangVien.ToString(),
			     
				this.MaQuanLy,
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.TenHocHam == null) ? string.Empty : this.TenHocHam.ToString(),
			     
				(this.TenHocVi == null) ? string.Empty : this.TenHocVi.ToString(),
			     
				(this.TenLoaiGiangVien == null) ? string.Empty : this.TenLoaiGiangVien.ToString(),
			     
				(this.MaDonVi == null) ? string.Empty : this.MaDonVi.ToString(),
			     
				this.TenDonVi,
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				(this.GioGiamChatLuongCao == null) ? string.Empty : this.GioGiamChatLuongCao.ToString(),
			     
				(this.GioGiamSauDaiHoc == null) ? string.Empty : this.GioGiamSauDaiHoc.ToString(),
			     
				(this.GioGiamNckh == null) ? string.Empty : this.GioGiamNckh.ToString(),
			     
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
			     
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewGiamTruGioChuan columns.
	/// </summary>
	[Serializable]
	public enum ViewGiamTruGioChuanColumn
	{
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
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
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// TenHocHam : 
		/// </summary>
		[EnumTextValue("TenHocHam")]
		[ColumnEnum("TenHocHam", typeof(System.String), System.Data.DbType.String, false, false, true, 200)]
		TenHocHam,
		/// <summary>
		/// TenHocVi : 
		/// </summary>
		[EnumTextValue("TenHocVi")]
		[ColumnEnum("TenHocVi", typeof(System.String), System.Data.DbType.String, false, false, true, 200)]
		TenHocVi,
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		[EnumTextValue("TenLoaiGiangVien")]
		[ColumnEnum("TenLoaiGiangVien", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenLoaiGiangVien,
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
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		HocKy,
		/// <summary>
		/// GioGiamChatLuongCao : 
		/// </summary>
		[EnumTextValue("GioGiamChatLuongCao")]
		[ColumnEnum("GioGiamChatLuongCao", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		GioGiamChatLuongCao,
		/// <summary>
		/// GioGiamSauDaiHoc : 
		/// </summary>
		[EnumTextValue("GioGiamSauDaiHoc")]
		[ColumnEnum("GioGiamSauDaiHoc", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		GioGiamSauDaiHoc,
		/// <summary>
		/// GioGiamNckh : 
		/// </summary>
		[EnumTextValue("GioGiamNckh")]
		[ColumnEnum("GioGiamNckh", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		GioGiamNckh,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("GhiChu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true, 1000)]
		GhiChu,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayCapNhat,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("NguoiCapNhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat
	}//End enum

} // end namespace
