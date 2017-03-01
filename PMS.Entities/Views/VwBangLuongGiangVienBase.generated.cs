﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwBangLuongGiangVien.cs instead.
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
	/// An object representation of the 'vw_BangLuong_GiangVien' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwBangLuongGiangVienBase")]
	public abstract partial class VwBangLuongGiangVienBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// Ho : 
		/// </summary>
		private System.String		  _ho = null;
		
		/// <summary>
		/// Ten : 
		/// </summary>
		private System.String		  _ten = null;
		
		/// <summary>
		/// SoTaiKhoan : 
		/// </summary>
		private System.String		  _soTaiKhoan = null;
		
		/// <summary>
		/// TenLop : 
		/// </summary>
		private System.String		  _tenLop = string.Empty;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = string.Empty;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = string.Empty;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		private System.DateTime?		  _ngayBatDau = null;
		
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		private System.DateTime?		  _ngayKetThuc = null;
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		private System.Int32?		  _siSoLop = null;
		
		/// <summary>
		/// SoTien : 
		/// </summary>
		private System.Decimal?		  _soTien = null;
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		private System.String		  _maBacDaoTao = null;
		
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		private System.String		  _maHeDaoTao = null;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.String		  _maGiangVien = string.Empty;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = string.Empty;
		
		/// <summary>
		/// SoTiet : 
		/// </summary>
		private System.Int32?		  _soTiet = null;
		
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
		/// Creates a new <see cref="VwBangLuongGiangVienBase"/> instance.
		///</summary>
		public VwBangLuongGiangVienBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwBangLuongGiangVienBase"/> instance.
		///</summary>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_soTaiKhoan"></param>
		///<param name="_tenLop"></param>
		///<param name="_maLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_soTien"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_soTiet"></param>
		public VwBangLuongGiangVienBase(System.String _ho, System.String _ten, System.String _soTaiKhoan, System.String _tenLop, System.String _maLop, System.String _maMonHoc, System.String _tenMonHoc, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.Int32? _siSoLop, System.Decimal? _soTien, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maGiangVien, System.String _maLopHocPhan, System.Int32? _soTiet)
		{
			this._ho = _ho;
			this._ten = _ten;
			this._soTaiKhoan = _soTaiKhoan;
			this._tenLop = _tenLop;
			this._maLop = _maLop;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._ngayBatDau = _ngayBatDau;
			this._ngayKetThuc = _ngayKetThuc;
			this._siSoLop = _siSoLop;
			this._soTien = _soTien;
			this._maBacDaoTao = _maBacDaoTao;
			this._maHeDaoTao = _maHeDaoTao;
			this._maGiangVien = _maGiangVien;
			this._maLopHocPhan = _maLopHocPhan;
			this._soTiet = _soTiet;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwBangLuongGiangVien"/> instance.
		///</summary>
		///<param name="_ho"></param>
		///<param name="_ten"></param>
		///<param name="_soTaiKhoan"></param>
		///<param name="_tenLop"></param>
		///<param name="_maLop"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_ngayBatDau"></param>
		///<param name="_ngayKetThuc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_soTien"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_maHeDaoTao"></param>
		///<param name="_maGiangVien"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_soTiet"></param>
		public static VwBangLuongGiangVien CreateVwBangLuongGiangVien(System.String _ho, System.String _ten, System.String _soTaiKhoan, System.String _tenLop, System.String _maLop, System.String _maMonHoc, System.String _tenMonHoc, System.DateTime? _ngayBatDau, System.DateTime? _ngayKetThuc, System.Int32? _siSoLop, System.Decimal? _soTien, System.String _maBacDaoTao, System.String _maHeDaoTao, System.String _maGiangVien, System.String _maLopHocPhan, System.Int32? _soTiet)
		{
			VwBangLuongGiangVien newVwBangLuongGiangVien = new VwBangLuongGiangVien();
			newVwBangLuongGiangVien.Ho = _ho;
			newVwBangLuongGiangVien.Ten = _ten;
			newVwBangLuongGiangVien.SoTaiKhoan = _soTaiKhoan;
			newVwBangLuongGiangVien.TenLop = _tenLop;
			newVwBangLuongGiangVien.MaLop = _maLop;
			newVwBangLuongGiangVien.MaMonHoc = _maMonHoc;
			newVwBangLuongGiangVien.TenMonHoc = _tenMonHoc;
			newVwBangLuongGiangVien.NgayBatDau = _ngayBatDau;
			newVwBangLuongGiangVien.NgayKetThuc = _ngayKetThuc;
			newVwBangLuongGiangVien.SiSoLop = _siSoLop;
			newVwBangLuongGiangVien.SoTien = _soTien;
			newVwBangLuongGiangVien.MaBacDaoTao = _maBacDaoTao;
			newVwBangLuongGiangVien.MaHeDaoTao = _maHeDaoTao;
			newVwBangLuongGiangVien.MaGiangVien = _maGiangVien;
			newVwBangLuongGiangVien.MaLopHocPhan = _maLopHocPhan;
			newVwBangLuongGiangVien.SoTiet = _soTiet;
			return newVwBangLuongGiangVien;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the Ho property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
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
		/// 	Gets or Sets the SoTaiKhoan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SoTaiKhoan
		{
			get
			{
				return this._soTaiKhoan; 
			}
			set
			{
				if (_soTaiKhoan == value)
					return;
					
				this._soTaiKhoan = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTaiKhoan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenLop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenLop
		{
			get
			{
				return this._tenLop; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenLop does not allow null values.");
				if (_tenLop == value)
					return;
					
				this._tenLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLop
		{
			get
			{
				return this._maLop; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaLop does not allow null values.");
				if (_maLop == value)
					return;
					
				this._maLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaMonHoc
		{
			get
			{
				return this._maMonHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaMonHoc does not allow null values.");
				if (_maMonHoc == value)
					return;
					
				this._maMonHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaMonHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenMonHoc
		{
			get
			{
				return this._tenMonHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenMonHoc does not allow null values.");
				if (_tenMonHoc == value)
					return;
					
				this._tenMonHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenMonHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayBatDau property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayBatDauNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayBatDau
		{
			get
			{
				return this._ngayBatDau; 
			}
			set
			{
				if (_ngayBatDau == value && NgayBatDau != null )
					return;
					
				this._ngayBatDau = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayBatDau");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the NgayKetThuc property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsNgayKetThucNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? NgayKetThuc
		{
			get
			{
				return this._ngayKetThuc; 
			}
			set
			{
				if (_ngayKetThuc == value && NgayKetThuc != null )
					return;
					
				this._ngayKetThuc = value;
				this._isDirty = true;
				
				OnPropertyChanged("NgayKetThuc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SiSoLop property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSiSoLopNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SiSoLop
		{
			get
			{
				return this._siSoLop; 
			}
			set
			{
				if (_siSoLop == value && SiSoLop != null )
					return;
					
				this._siSoLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("SiSoLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTien property. 
		///		
		/// </summary>
		/// <value>This type is money</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0. It is up to the developer
		/// to check the value of IsSoTienNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SoTien
		{
			get
			{
				return this._soTien; 
			}
			set
			{
				if (_soTien == value && SoTien != null )
					return;
					
				this._soTien = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaBacDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaBacDaoTao
		{
			get
			{
				return this._maBacDaoTao; 
			}
			set
			{
				if (_maBacDaoTao == value)
					return;
					
				this._maBacDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaBacDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaHeDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHeDaoTao
		{
			get
			{
				return this._maHeDaoTao; 
			}
			set
			{
				if (_maHeDaoTao == value)
					return;
					
				this._maHeDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHeDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaGiangVien property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaGiangVien
		{
			get
			{
				return this._maGiangVien; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaGiangVien does not allow null values.");
				if (_maGiangVien == value)
					return;
					
				this._maGiangVien = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVien");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLopHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLopHocPhan
		{
			get
			{
				return this._maLopHocPhan; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaLopHocPhan does not allow null values.");
				if (_maLopHocPhan == value)
					return;
					
				this._maLopHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLopHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTiet property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSoTietNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SoTiet
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
			get { return "vw_BangLuong_GiangVien"; }
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
		///  Returns a Typed VwBangLuongGiangVienBase Entity 
		///</summary>
		public virtual VwBangLuongGiangVienBase Copy()
		{
			//shallow copy entity
			VwBangLuongGiangVien copy = new VwBangLuongGiangVien();
				copy.Ho = this.Ho;
				copy.Ten = this.Ten;
				copy.SoTaiKhoan = this.SoTaiKhoan;
				copy.TenLop = this.TenLop;
				copy.MaLop = this.MaLop;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.NgayBatDau = this.NgayBatDau;
				copy.NgayKetThuc = this.NgayKetThuc;
				copy.SiSoLop = this.SiSoLop;
				copy.SoTien = this.SoTien;
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.MaHeDaoTao = this.MaHeDaoTao;
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.SoTiet = this.SoTiet;
			copy.AcceptChanges();
			return (VwBangLuongGiangVien)copy;
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
		///<returns>true if toObject is a <see cref="VwBangLuongGiangVienBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwBangLuongGiangVienBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwBangLuongGiangVienBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwBangLuongGiangVienBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwBangLuongGiangVienBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwBangLuongGiangVienBase Object1, VwBangLuongGiangVienBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
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
			if (Object1.SoTaiKhoan != null && Object2.SoTaiKhoan != null )
			{
				if (Object1.SoTaiKhoan != Object2.SoTaiKhoan)
					equal = false;
			}
			else if (Object1.SoTaiKhoan == null ^ Object1.SoTaiKhoan == null )
			{
				equal = false;
			}
			if (Object1.TenLop != Object2.TenLop)
				equal = false;
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if (Object1.MaMonHoc != Object2.MaMonHoc)
				equal = false;
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.NgayBatDau != null && Object2.NgayBatDau != null )
			{
				if (Object1.NgayBatDau != Object2.NgayBatDau)
					equal = false;
			}
			else if (Object1.NgayBatDau == null ^ Object1.NgayBatDau == null )
			{
				equal = false;
			}
			if (Object1.NgayKetThuc != null && Object2.NgayKetThuc != null )
			{
				if (Object1.NgayKetThuc != Object2.NgayKetThuc)
					equal = false;
			}
			else if (Object1.NgayKetThuc == null ^ Object1.NgayKetThuc == null )
			{
				equal = false;
			}
			if (Object1.SiSoLop != null && Object2.SiSoLop != null )
			{
				if (Object1.SiSoLop != Object2.SiSoLop)
					equal = false;
			}
			else if (Object1.SiSoLop == null ^ Object1.SiSoLop == null )
			{
				equal = false;
			}
			if (Object1.SoTien != null && Object2.SoTien != null )
			{
				if (Object1.SoTien != Object2.SoTien)
					equal = false;
			}
			else if (Object1.SoTien == null ^ Object1.SoTien == null )
			{
				equal = false;
			}
			if (Object1.MaBacDaoTao != null && Object2.MaBacDaoTao != null )
			{
				if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
					equal = false;
			}
			else if (Object1.MaBacDaoTao == null ^ Object1.MaBacDaoTao == null )
			{
				equal = false;
			}
			if (Object1.MaHeDaoTao != null && Object2.MaHeDaoTao != null )
			{
				if (Object1.MaHeDaoTao != Object2.MaHeDaoTao)
					equal = false;
			}
			else if (Object1.MaHeDaoTao == null ^ Object1.MaHeDaoTao == null )
			{
				equal = false;
			}
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
			if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
				equal = false;
			if (Object1.SoTiet != null && Object2.SoTiet != null )
			{
				if (Object1.SoTiet != Object2.SoTiet)
					equal = false;
			}
			else if (Object1.SoTiet == null ^ Object1.SoTiet == null )
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
		public static object GetPropertyValueByName(VwBangLuongGiangVien entity, string propertyName)
		{
			switch (propertyName)
			{
				case "Ho":
					return entity.Ho;
				case "Ten":
					return entity.Ten;
				case "SoTaiKhoan":
					return entity.SoTaiKhoan;
				case "TenLop":
					return entity.TenLop;
				case "MaLop":
					return entity.MaLop;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "NgayBatDau":
					return entity.NgayBatDau;
				case "NgayKetThuc":
					return entity.NgayKetThuc;
				case "SiSoLop":
					return entity.SiSoLop;
				case "SoTien":
					return entity.SoTien;
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "MaHeDaoTao":
					return entity.MaHeDaoTao;
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "SoTiet":
					return entity.SoTiet;
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
			return GetPropertyValueByName(this as VwBangLuongGiangVien, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{17}{16}- Ho: {0}{16}- Ten: {1}{16}- SoTaiKhoan: {2}{16}- TenLop: {3}{16}- MaLop: {4}{16}- MaMonHoc: {5}{16}- TenMonHoc: {6}{16}- NgayBatDau: {7}{16}- NgayKetThuc: {8}{16}- SiSoLop: {9}{16}- SoTien: {10}{16}- MaBacDaoTao: {11}{16}- MaHeDaoTao: {12}{16}- MaGiangVien: {13}{16}- MaLopHocPhan: {14}{16}- SoTiet: {15}{16}", 
				(this.Ho == null) ? string.Empty : this.Ho.ToString(),
			     
				(this.Ten == null) ? string.Empty : this.Ten.ToString(),
			     
				(this.SoTaiKhoan == null) ? string.Empty : this.SoTaiKhoan.ToString(),
			     
				this.TenLop,
				this.MaLop,
				this.MaMonHoc,
				this.TenMonHoc,
				(this.NgayBatDau == null) ? string.Empty : this.NgayBatDau.ToString(),
			     
				(this.NgayKetThuc == null) ? string.Empty : this.NgayKetThuc.ToString(),
			     
				(this.SiSoLop == null) ? string.Empty : this.SiSoLop.ToString(),
			     
				(this.SoTien == null) ? string.Empty : this.SoTien.ToString(),
			     
				(this.MaBacDaoTao == null) ? string.Empty : this.MaBacDaoTao.ToString(),
			     
				(this.MaHeDaoTao == null) ? string.Empty : this.MaHeDaoTao.ToString(),
			     
				this.MaGiangVien,
				this.MaLopHocPhan,
				(this.SoTiet == null) ? string.Empty : this.SoTiet.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwBangLuongGiangVien columns.
	/// </summary>
	[Serializable]
	public enum VwBangLuongGiangVienColumn
	{
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
		/// SoTaiKhoan : 
		/// </summary>
		[EnumTextValue("SoTaiKhoan")]
		[ColumnEnum("SoTaiKhoan", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 50)]
		SoTaiKhoan,
		/// <summary>
		/// TenLop : 
		/// </summary>
		[EnumTextValue("TenLop")]
		[ColumnEnum("TenLop", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenLop,
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLop,
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		[EnumTextValue("MaMonHoc")]
		[ColumnEnum("MaMonHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaMonHoc,
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		[EnumTextValue("TenMonHoc")]
		[ColumnEnum("TenMonHoc", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenMonHoc,
		/// <summary>
		/// NgayBatDau : 
		/// </summary>
		[EnumTextValue("NgayBatDau")]
		[ColumnEnum("NgayBatDau", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayBatDau,
		/// <summary>
		/// NgayKetThuc : 
		/// </summary>
		[EnumTextValue("NgayKetThuc")]
		[ColumnEnum("NgayKetThuc", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		NgayKetThuc,
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		[EnumTextValue("SiSoLop")]
		[ColumnEnum("SiSoLop", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSoLop,
		/// <summary>
		/// SoTien : 
		/// </summary>
		[EnumTextValue("SoTien")]
		[ColumnEnum("SoTien", typeof(System.Decimal), System.Data.DbType.Currency, false, false, true)]
		SoTien,
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		[EnumTextValue("MaBacDaoTao")]
		[ColumnEnum("MaBacDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaBacDaoTao,
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		[EnumTextValue("MaHeDaoTao")]
		[ColumnEnum("MaHeDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaHeDaoTao,
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaGiangVien,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLopHocPhan,
		/// <summary>
		/// SoTiet : 
		/// </summary>
		[EnumTextValue("SoTiet")]
		[ColumnEnum("SoTiet", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SoTiet
	}//End enum

} // end namespace