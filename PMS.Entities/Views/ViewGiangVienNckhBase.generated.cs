﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewGiangVienNckh.cs instead.
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
	/// An object representation of the 'View_GiangVien_Nckh' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewGiangVienNckhBase")]
	public abstract partial class ViewGiangVienNckhBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
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
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// Id : 
		/// </summary>
		private System.Int32		  _id = (int)0;
		
		/// <summary>
		/// MaNckh : 
		/// </summary>
		private System.String		  _maNckh = null;
		
		/// <summary>
		/// TenNghienCuuKhoaHoc : 
		/// </summary>
		private System.String		  _tenNghienCuuKhoaHoc = null;
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		private System.Decimal?		  _soTiet = null;
		
		/// <summary>
		/// NgayHieuLuc : 
		/// </summary>
		private System.String		  _ngayHieuLuc = null;
		
		/// <summary>
		/// NgayHetHieuLuc : 
		/// </summary>
		private System.String		  _ngayHetHieuLuc = null;
		
		/// <summary>
		/// TrangThai : 
		/// </summary>
		private System.Boolean?		  _trangThai = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = string.Empty;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = string.Empty;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.String		  _ngayCapNhat = null;
		
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		private System.String		  _nguoiCapNhat = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		private System.String		  _ghiChu = null;
		
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		private System.String		  _tenDonVi = null;
		
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
		/// Creates a new <see cref="ViewGiangVienNckhBase"/> instance.
		///</summary>
		public ViewGiangVienNckhBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewGiangVienNckhBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_id"></param>
		///<param name="_maNckh"></param>
		///<param name="_tenNghienCuuKhoaHoc"></param>
		///<param name="_soTiet"></param>
		///<param name="_ngayHieuLuc"></param>
		///<param name="_ngayHetHieuLuc"></param>
		///<param name="_trangThai"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_ghiChu"></param>
		///<param name="_tenDonVi"></param>
		public ViewGiangVienNckhBase(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.Int32 _id, System.String _maNckh, System.String _tenNghienCuuKhoaHoc, System.Decimal? _soTiet, System.String _ngayHieuLuc, System.String _ngayHetHieuLuc, System.Boolean? _trangThai, System.String _namHoc, System.String _hocKy, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.String _ghiChu, System.String _tenDonVi)
		{
			this._maGiangVien = _maGiangVien;
			this._maQuanLy = _maQuanLy;
			this._ho = _ho;
			this._ten = _ten;
			this._hoTen = _hoTen;
			this._id = _id;
			this._maNckh = _maNckh;
			this._tenNghienCuuKhoaHoc = _tenNghienCuuKhoaHoc;
			this._soTiet = _soTiet;
			this._ngayHieuLuc = _ngayHieuLuc;
			this._ngayHetHieuLuc = _ngayHetHieuLuc;
			this._trangThai = _trangThai;
			this._namHoc = _namHoc;
			this._hocKy = _hocKy;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
			this._ghiChu = _ghiChu;
			this._tenDonVi = _tenDonVi;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiangVienNckh"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maQuanLy"></param>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_hoTen"></param>
		///<param name="_id"></param>
		///<param name="_maNckh"></param>
		///<param name="_tenNghienCuuKhoaHoc"></param>
		///<param name="_soTiet"></param>
		///<param name="_ngayHieuLuc"></param>
		///<param name="_ngayHetHieuLuc"></param>
		///<param name="_trangThai"></param>
		///<param name="_namHoc"></param>
		///<param name="_hocKy"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		///<param name="_ghiChu"></param>
		///<param name="_tenDonVi"></param>
		public static ViewGiangVienNckh CreateViewGiangVienNckh(System.Int32 _maGiangVien, System.String _maQuanLy, System.String _ho, System.String _ten, System.String _hoTen, System.Int32 _id, System.String _maNckh, System.String _tenNghienCuuKhoaHoc, System.Decimal? _soTiet, System.String _ngayHieuLuc, System.String _ngayHetHieuLuc, System.Boolean? _trangThai, System.String _namHoc, System.String _hocKy, System.String _ngayCapNhat, System.String _nguoiCapNhat, System.String _ghiChu, System.String _tenDonVi)
		{
			ViewGiangVienNckh newViewGiangVienNckh = new ViewGiangVienNckh();
			newViewGiangVienNckh.MaGiangVien = _maGiangVien;
			newViewGiangVienNckh.MaQuanLy = _maQuanLy;
			newViewGiangVienNckh.Ho = _ho;
			newViewGiangVienNckh.Ten = _ten;
			newViewGiangVienNckh.HoTen = _hoTen;
			newViewGiangVienNckh.Id = _id;
			newViewGiangVienNckh.MaNckh = _maNckh;
			newViewGiangVienNckh.TenNghienCuuKhoaHoc = _tenNghienCuuKhoaHoc;
			newViewGiangVienNckh.SoTiet = _soTiet;
			newViewGiangVienNckh.NgayHieuLuc = _ngayHieuLuc;
			newViewGiangVienNckh.NgayHetHieuLuc = _ngayHetHieuLuc;
			newViewGiangVienNckh.TrangThai = _trangThai;
			newViewGiangVienNckh.NamHoc = _namHoc;
			newViewGiangVienNckh.HocKy = _hocKy;
			newViewGiangVienNckh.NgayCapNhat = _ngayCapNhat;
			newViewGiangVienNckh.NguoiCapNhat = _nguoiCapNhat;
			newViewGiangVienNckh.GhiChu = _ghiChu;
			newViewGiangVienNckh.TenDonVi = _tenDonVi;
			return newViewGiangVienNckh;
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
		/// 	Gets or Sets the Id property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 Id
		{
			get
			{
				return this._id; 
			}
			set
			{
				if (_id == value)
					return;
					
				this._id = value;
				this._isDirty = true;
				
				OnPropertyChanged("Id");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaNckh property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaNckh
		{
			get
			{
				return this._maNckh; 
			}
			set
			{
				if (_maNckh == value)
					return;
					
				this._maNckh = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaNckh");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenNghienCuuKhoaHoc property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenNghienCuuKhoaHoc
		{
			get
			{
				return this._tenNghienCuuKhoaHoc; 
			}
			set
			{
				if (_tenNghienCuuKhoaHoc == value)
					return;
					
				this._tenNghienCuuKhoaHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenNghienCuuKhoaHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTiet property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsSoTietNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SoTiet
		{
			get
			{
				return this._soTiet; 
			}
			set
			{
				if (_soTiet == value && SoTiet != null )
					return;
					
				this._soTiet = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTiet");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayHieuLuc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NgayHieuLuc
		{
			get
			{
				return this._ngayHieuLuc; 
			}
			set
			{
				if (_ngayHieuLuc == value)
					return;
					
				this._ngayHieuLuc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayHieuLuc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayHetHieuLuc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NgayHetHieuLuc
		{
			get
			{
				return this._ngayHetHieuLuc; 
			}
			set
			{
				if (_ngayHetHieuLuc == value)
					return;
					
				this._ngayHetHieuLuc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayHetHieuLuc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TrangThai property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsTrangThaiNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean? TrangThai
		{
			get
			{
				return this._trangThai; 
			}
			set
			{
				if (_trangThai == value && TrangThai != null )
					return;
					
				this._trangThai = value;
				this._isDirty = true;
				
				OnPropertyChanged("TrangThai");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NamHoc
		{
			get
			{
				return this._namHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "NamHoc does not allow null values.");
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
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String HocKy
		{
			get
			{
				return this._hocKy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "HocKy does not allow null values.");
				if (_hocKy == value)
					return;
					
				this._hocKy = value;
				this._isDirty = true;
				
				OnPropertyChanged("HocKy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayCapNhat property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NgayCapNhat
		{
			get
			{
				return this._ngayCapNhat; 
			}
			set
			{
				if (_ngayCapNhat == value)
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
		/// 	Gets or Sets the TenDonVi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenDonVi
		{
			get
			{
				return this._tenDonVi; 
			}
			set
			{
				if (_tenDonVi == value)
					return;
					
				this._tenDonVi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenDonVi");
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
			get { return "View_GiangVien_Nckh"; }
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
		///  Returns a Typed ViewGiangVienNckhBase Entity 
		///</summary>
		public virtual ViewGiangVienNckhBase Copy()
		{
			//shallow copy entity
			ViewGiangVienNckh copy = new ViewGiangVienNckh();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaQuanLy = this.MaQuanLy;
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.HoTen = this.HoTen;
				copy.Id = this.Id;
				copy.MaNckh = this.MaNckh;
				copy.TenNghienCuuKhoaHoc = this.TenNghienCuuKhoaHoc;
				copy.SoTiet = this.SoTiet;
				copy.NgayHieuLuc = this.NgayHieuLuc;
				copy.NgayHetHieuLuc = this.NgayHetHieuLuc;
				copy.TrangThai = this.TrangThai;
				copy.NamHoc = this.NamHoc;
				copy.HocKy = this.HocKy;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
				copy.GhiChu = this.GhiChu;
				copy.TenDonVi = this.TenDonVi;
			copy.AcceptChanges();
			return (ViewGiangVienNckh)copy;
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
		///<returns>true if toObject is a <see cref="ViewGiangVienNckhBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewGiangVienNckhBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewGiangVienNckhBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewGiangVienNckhBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewGiangVienNckhBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewGiangVienNckhBase Object1, ViewGiangVienNckhBase Object2)
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
			if (Object1.HoTen != null && Object2.HoTen != null )
			{
				if (Object1.HoTen != Object2.HoTen)
					equal = false;
			}
			else if (Object1.HoTen == null ^ Object1.HoTen == null )
			{
				equal = false;
			}
			if (Object1.Id != Object2.Id)
				equal = false;
			if (Object1.MaNckh != null && Object2.MaNckh != null )
			{
				if (Object1.MaNckh != Object2.MaNckh)
					equal = false;
			}
			else if (Object1.MaNckh == null ^ Object1.MaNckh == null )
			{
				equal = false;
			}
			if (Object1.TenNghienCuuKhoaHoc != null && Object2.TenNghienCuuKhoaHoc != null )
			{
				if (Object1.TenNghienCuuKhoaHoc != Object2.TenNghienCuuKhoaHoc)
					equal = false;
			}
			else if (Object1.TenNghienCuuKhoaHoc == null ^ Object1.TenNghienCuuKhoaHoc == null )
			{
				equal = false;
			}
			if (Object1.SoTiet != null && Object2.SoTiet != null )
			{
				if (Object1.SoTiet != Object2.SoTiet)
					equal = false;
			}
			else if (Object1.SoTiet == null ^ Object1.SoTiet == null )
			{
				equal = false;
			}
			if (Object1.NgayHieuLuc != null && Object2.NgayHieuLuc != null )
			{
				if (Object1.NgayHieuLuc != Object2.NgayHieuLuc)
					equal = false;
			}
			else if (Object1.NgayHieuLuc == null ^ Object1.NgayHieuLuc == null )
			{
				equal = false;
			}
			if (Object1.NgayHetHieuLuc != null && Object2.NgayHetHieuLuc != null )
			{
				if (Object1.NgayHetHieuLuc != Object2.NgayHetHieuLuc)
					equal = false;
			}
			else if (Object1.NgayHetHieuLuc == null ^ Object1.NgayHetHieuLuc == null )
			{
				equal = false;
			}
			if (Object1.TrangThai != null && Object2.TrangThai != null )
			{
				if (Object1.TrangThai != Object2.TrangThai)
					equal = false;
			}
			else if (Object1.TrangThai == null ^ Object1.TrangThai == null )
			{
				equal = false;
			}
			if (Object1.NamHoc != Object2.NamHoc)
				equal = false;
			if (Object1.HocKy != Object2.HocKy)
				equal = false;
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
			if (Object1.GhiChu != null && Object2.GhiChu != null )
			{
				if (Object1.GhiChu != Object2.GhiChu)
					equal = false;
			}
			else if (Object1.GhiChu == null ^ Object1.GhiChu == null )
			{
				equal = false;
			}
			if (Object1.TenDonVi != null && Object2.TenDonVi != null )
			{
				if (Object1.TenDonVi != Object2.TenDonVi)
					equal = false;
			}
			else if (Object1.TenDonVi == null ^ Object1.TenDonVi == null )
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
		public static object GetPropertyValueByName(ViewGiangVienNckh entity, string propertyName)
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
				case "Id":
					return entity.Id;
				case "MaNckh":
					return entity.MaNckh;
				case "TenNghienCuuKhoaHoc":
					return entity.TenNghienCuuKhoaHoc;
				case "SoTiet":
					return entity.SoTiet;
				case "NgayHieuLuc":
					return entity.NgayHieuLuc;
				case "NgayHetHieuLuc":
					return entity.NgayHetHieuLuc;
				case "TrangThai":
					return entity.TrangThai;
				case "NamHoc":
					return entity.NamHoc;
				case "HocKy":
					return entity.HocKy;
				case "NgayCapNhat":
					return entity.NgayCapNhat;
				case "NguoiCapNhat":
					return entity.NguoiCapNhat;
				case "GhiChu":
					return entity.GhiChu;
				case "TenDonVi":
					return entity.TenDonVi;
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
			return GetPropertyValueByName(this as ViewGiangVienNckh, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{19}{18}- MaGiangVien: {0}{18}- MaQuanLy: {1}{18}- Ho: {2}{18}- Ten: {3}{18}- HoTen: {4}{18}- Id: {5}{18}- MaNckh: {6}{18}- TenNghienCuuKhoaHoc: {7}{18}- SoTiet: {8}{18}- NgayHieuLuc: {9}{18}- NgayHetHieuLuc: {10}{18}- TrangThai: {11}{18}- NamHoc: {12}{18}- HocKy: {13}{18}- NgayCapNhat: {14}{18}- NguoiCapNhat: {15}{18}- GhiChu: {16}{18}- TenDonVi: {17}{18}", 
				this.MaGiangVien,
				this.MaQuanLy,
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				this.Id,
				(this.MaNckh == null) ? string.Empty : this.MaNckh.ToString(),
			     
				(this.TenNghienCuuKhoaHoc == null) ? string.Empty : this.TenNghienCuuKhoaHoc.ToString(),
			     
				(this.SoTiet == null) ? string.Empty : this.SoTiet.ToString(),
			     
				(this.NgayHieuLuc == null) ? string.Empty : this.NgayHieuLuc.ToString(),
			     
				(this.NgayHetHieuLuc == null) ? string.Empty : this.NgayHetHieuLuc.ToString(),
			     
				(this.TrangThai == null) ? string.Empty : this.TrangThai.ToString(),
			     
				this.NamHoc,
				this.HocKy,
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
			     
				(this.TenDonVi == null) ? string.Empty : this.TenDonVi.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewGiangVienNckh columns.
	/// </summary>
	[Serializable]
	public enum ViewGiangVienNckhColumn
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
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// Id : 
		/// </summary>
		[EnumTextValue("Id")]
		[ColumnEnum("Id", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		Id,
		/// <summary>
		/// MaNckh : 
		/// </summary>
		[EnumTextValue("MaNckh")]
		[ColumnEnum("MaNckh", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaNckh,
		/// <summary>
		/// TenNghienCuuKhoaHoc : 
		/// </summary>
		[EnumTextValue("TenNghienCuuKhoaHoc")]
		[ColumnEnum("TenNghienCuuKhoaHoc", typeof(System.String), System.Data.DbType.String, false, false, true, 1000)]
		TenNghienCuuKhoaHoc,
		/// <summary>
		/// SoTiet : 
		/// </summary>
		[EnumTextValue("SoTiet")]
		[ColumnEnum("SoTiet", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		SoTiet,
		/// <summary>
		/// NgayHieuLuc : 
		/// </summary>
		[EnumTextValue("NgayHieuLuc")]
		[ColumnEnum("NgayHieuLuc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 10)]
		NgayHieuLuc,
		/// <summary>
		/// NgayHetHieuLuc : 
		/// </summary>
		[EnumTextValue("NgayHetHieuLuc")]
		[ColumnEnum("NgayHetHieuLuc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 10)]
		NgayHetHieuLuc,
		/// <summary>
		/// TrangThai : 
		/// </summary>
		[EnumTextValue("TrangThai")]
		[ColumnEnum("TrangThai", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		TrangThai,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		NamHoc,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		HocKy,
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		[EnumTextValue("NgayCapNhat")]
		[ColumnEnum("NgayCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NgayCapNhat,
		/// <summary>
		/// NguoiCapNhat : 
		/// </summary>
		[EnumTextValue("NguoiCapNhat")]
		[ColumnEnum("NguoiCapNhat", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		NguoiCapNhat,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("GhiChu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true, 500)]
		GhiChu,
		/// <summary>
		/// TenDonVi : 
		/// </summary>
		[EnumTextValue("TenDonVi")]
		[ColumnEnum("TenDonVi", typeof(System.String), System.Data.DbType.String, false, false, true, 255)]
		TenDonVi
	}//End enum

} // end namespace
