﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewDanhSachLopPhanCongGiangDay.cs instead.
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
	/// An object representation of the 'View_DanhSachLopPhanCongGiangDay' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewDanhSachLopPhanCongGiangDayBase")]
	public abstract partial class ViewDanhSachLopPhanCongGiangDayBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGocLHP : 
		/// </summary>
		private System.String		  _maGocLhp = string.Empty;
		
		/// <summary>
		/// MaLHP : 
		/// </summary>
		private System.String		  _maLhp = null;
		
		/// <summary>
		/// TenHP : 
		/// </summary>
		private System.String		  _tenHp = string.Empty;
		
		/// <summary>
		/// LoaiHP : 
		/// </summary>
		private System.String		  _loaiHp = string.Empty;
		
		/// <summary>
		/// SoTC : 
		/// </summary>
		private System.String		  _soTc = null;
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		private System.Decimal?		  _siSoLop = null;
		
		/// <summary>
		/// SiSoDK : 
		/// </summary>
		private System.Int32?		  _siSoDk = null;
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = null;
		
		/// <summary>
		/// MaCBGD : 
		/// </summary>
		private System.String		  _maCbgd = null;
		
		/// <summary>
		/// TenCBGD : 
		/// </summary>
		private System.String		  _tenCbgd = null;
		
		/// <summary>
		/// TKB : 
		/// </summary>
		private System.String		  _tkb = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = string.Empty;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = string.Empty;
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.String		  _maGiangVien = string.Empty;
		
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
		/// Creates a new <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> instance.
		///</summary>
		public ViewDanhSachLopPhanCongGiangDayBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> instance.
		///</summary>
		///<param name="_maGocLhp"></param>
		///<param name="_maLhp"></param>
		///<param name="_tenHp"></param>
		///<param name="_loaiHp"></param>
		///<param name="_soTc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_siSoDk"></param>
		///<param name="_maLop"></param>
		///<param name="_maCbgd"></param>
		///<param name="_tenCbgd"></param>
		///<param name="_tkb"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		///<param name="_maGiangVien"></param>
		public ViewDanhSachLopPhanCongGiangDayBase(System.String _maGocLhp, System.String _maLhp, System.String _tenHp, System.String _loaiHp, System.String _soTc, System.Decimal? _siSoLop, System.Int32? _siSoDk, System.String _maLop, System.String _maCbgd, System.String _tenCbgd, System.String _tkb, System.String _hocKy, System.String _namHoc, System.String _maGiangVien)
		{
			this._maGocLhp = _maGocLhp;
			this._maLhp = _maLhp;
			this._tenHp = _tenHp;
			this._loaiHp = _loaiHp;
			this._soTc = _soTc;
			this._siSoLop = _siSoLop;
			this._siSoDk = _siSoDk;
			this._maLop = _maLop;
			this._maCbgd = _maCbgd;
			this._tenCbgd = _tenCbgd;
			this._tkb = _tkb;
			this._hocKy = _hocKy;
			this._namHoc = _namHoc;
			this._maGiangVien = _maGiangVien;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewDanhSachLopPhanCongGiangDay"/> instance.
		///</summary>
		///<param name="_maGocLhp"></param>
		///<param name="_maLhp"></param>
		///<param name="_tenHp"></param>
		///<param name="_loaiHp"></param>
		///<param name="_soTc"></param>
		///<param name="_siSoLop"></param>
		///<param name="_siSoDk"></param>
		///<param name="_maLop"></param>
		///<param name="_maCbgd"></param>
		///<param name="_tenCbgd"></param>
		///<param name="_tkb"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		///<param name="_maGiangVien"></param>
		public static ViewDanhSachLopPhanCongGiangDay CreateViewDanhSachLopPhanCongGiangDay(System.String _maGocLhp, System.String _maLhp, System.String _tenHp, System.String _loaiHp, System.String _soTc, System.Decimal? _siSoLop, System.Int32? _siSoDk, System.String _maLop, System.String _maCbgd, System.String _tenCbgd, System.String _tkb, System.String _hocKy, System.String _namHoc, System.String _maGiangVien)
		{
			ViewDanhSachLopPhanCongGiangDay newViewDanhSachLopPhanCongGiangDay = new ViewDanhSachLopPhanCongGiangDay();
			newViewDanhSachLopPhanCongGiangDay.MaGocLhp = _maGocLhp;
			newViewDanhSachLopPhanCongGiangDay.MaLhp = _maLhp;
			newViewDanhSachLopPhanCongGiangDay.TenHp = _tenHp;
			newViewDanhSachLopPhanCongGiangDay.LoaiHp = _loaiHp;
			newViewDanhSachLopPhanCongGiangDay.SoTc = _soTc;
			newViewDanhSachLopPhanCongGiangDay.SiSoLop = _siSoLop;
			newViewDanhSachLopPhanCongGiangDay.SiSoDk = _siSoDk;
			newViewDanhSachLopPhanCongGiangDay.MaLop = _maLop;
			newViewDanhSachLopPhanCongGiangDay.MaCbgd = _maCbgd;
			newViewDanhSachLopPhanCongGiangDay.TenCbgd = _tenCbgd;
			newViewDanhSachLopPhanCongGiangDay.Tkb = _tkb;
			newViewDanhSachLopPhanCongGiangDay.HocKy = _hocKy;
			newViewDanhSachLopPhanCongGiangDay.NamHoc = _namHoc;
			newViewDanhSachLopPhanCongGiangDay.MaGiangVien = _maGiangVien;
			return newViewDanhSachLopPhanCongGiangDay;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaGocLHP property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaGocLhp
		{
			get
			{
				return this._maGocLhp; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaGocLhp does not allow null values.");
				if (_maGocLhp == value)
					return;
					
				this._maGocLhp = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGocLhp");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLHP property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLhp
		{
			get
			{
				return this._maLhp; 
			}
			set
			{
				if (_maLhp == value)
					return;
					
				this._maLhp = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLhp");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHP property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHp
		{
			get
			{
				return this._tenHp; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenHp does not allow null values.");
				if (_tenHp == value)
					return;
					
				this._tenHp = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHp");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the LoaiHP property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String LoaiHp
		{
			get
			{
				return this._loaiHp; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "LoaiHp does not allow null values.");
				if (_loaiHp == value)
					return;
					
				this._loaiHp = value;
				this._isDirty = true;
				
				OnPropertyChanged("LoaiHp");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SoTC property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SoTc
		{
			get
			{
				return this._soTc; 
			}
			set
			{
				if (_soTc == value)
					return;
					
				this._soTc = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoTc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SiSoLop property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsSiSoLopNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? SiSoLop
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
		/// 	Gets or Sets the SiSoDK property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSiSoDkNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SiSoDk
		{
			get
			{
				return this._siSoDk; 
			}
			set
			{
				if (_siSoDk == value && SiSoDk != null )
					return;
					
				this._siSoDk = value;
				this._isDirty = true;
				
				OnPropertyChanged("SiSoDk");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLop property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLop
		{
			get
			{
				return this._maLop; 
			}
			set
			{
				if (_maLop == value)
					return;
					
				this._maLop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaCBGD property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaCbgd
		{
			get
			{
				return this._maCbgd; 
			}
			set
			{
				if (_maCbgd == value)
					return;
					
				this._maCbgd = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaCbgd");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenCBGD property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenCbgd
		{
			get
			{
				return this._tenCbgd; 
			}
			set
			{
				if (_tenCbgd == value)
					return;
					
				this._tenCbgd = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenCbgd");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TKB property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Tkb
		{
			get
			{
				return this._tkb; 
			}
			set
			{
				if (_tkb == value)
					return;
					
				this._tkb = value;
				this._isDirty = true;
				
				OnPropertyChanged("Tkb");
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
			get { return "View_DanhSachLopPhanCongGiangDay"; }
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
		///  Returns a Typed ViewDanhSachLopPhanCongGiangDayBase Entity 
		///</summary>
		public virtual ViewDanhSachLopPhanCongGiangDayBase Copy()
		{
			//shallow copy entity
			ViewDanhSachLopPhanCongGiangDay copy = new ViewDanhSachLopPhanCongGiangDay();
				copy.MaGocLhp = this.MaGocLhp;
				copy.MaLhp = this.MaLhp;
				copy.TenHp = this.TenHp;
				copy.LoaiHp = this.LoaiHp;
				copy.SoTc = this.SoTc;
				copy.SiSoLop = this.SiSoLop;
				copy.SiSoDk = this.SiSoDk;
				copy.MaLop = this.MaLop;
				copy.MaCbgd = this.MaCbgd;
				copy.TenCbgd = this.TenCbgd;
				copy.Tkb = this.Tkb;
				copy.HocKy = this.HocKy;
				copy.NamHoc = this.NamHoc;
				copy.MaGiangVien = this.MaGiangVien;
			copy.AcceptChanges();
			return (ViewDanhSachLopPhanCongGiangDay)copy;
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
		///<returns>true if toObject is a <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewDanhSachLopPhanCongGiangDayBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewDanhSachLopPhanCongGiangDayBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewDanhSachLopPhanCongGiangDayBase Object1, ViewDanhSachLopPhanCongGiangDayBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaGocLhp != Object2.MaGocLhp)
				equal = false;
			if (Object1.MaLhp != null && Object2.MaLhp != null )
			{
				if (Object1.MaLhp != Object2.MaLhp)
					equal = false;
			}
			else if (Object1.MaLhp == null ^ Object1.MaLhp == null )
			{
				equal = false;
			}
			if (Object1.TenHp != Object2.TenHp)
				equal = false;
			if (Object1.LoaiHp != Object2.LoaiHp)
				equal = false;
			if (Object1.SoTc != null && Object2.SoTc != null )
			{
				if (Object1.SoTc != Object2.SoTc)
					equal = false;
			}
			else if (Object1.SoTc == null ^ Object1.SoTc == null )
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
			if (Object1.SiSoDk != null && Object2.SiSoDk != null )
			{
				if (Object1.SiSoDk != Object2.SiSoDk)
					equal = false;
			}
			else if (Object1.SiSoDk == null ^ Object1.SiSoDk == null )
			{
				equal = false;
			}
			if (Object1.MaLop != null && Object2.MaLop != null )
			{
				if (Object1.MaLop != Object2.MaLop)
					equal = false;
			}
			else if (Object1.MaLop == null ^ Object1.MaLop == null )
			{
				equal = false;
			}
			if (Object1.MaCbgd != null && Object2.MaCbgd != null )
			{
				if (Object1.MaCbgd != Object2.MaCbgd)
					equal = false;
			}
			else if (Object1.MaCbgd == null ^ Object1.MaCbgd == null )
			{
				equal = false;
			}
			if (Object1.TenCbgd != null && Object2.TenCbgd != null )
			{
				if (Object1.TenCbgd != Object2.TenCbgd)
					equal = false;
			}
			else if (Object1.TenCbgd == null ^ Object1.TenCbgd == null )
			{
				equal = false;
			}
			if (Object1.Tkb != null && Object2.Tkb != null )
			{
				if (Object1.Tkb != Object2.Tkb)
					equal = false;
			}
			else if (Object1.Tkb == null ^ Object1.Tkb == null )
			{
				equal = false;
			}
			if (Object1.HocKy != Object2.HocKy)
				equal = false;
			if (Object1.NamHoc != Object2.NamHoc)
				equal = false;
			if (Object1.MaGiangVien != Object2.MaGiangVien)
				equal = false;
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
		public static object GetPropertyValueByName(ViewDanhSachLopPhanCongGiangDay entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGocLhp":
					return entity.MaGocLhp;
				case "MaLhp":
					return entity.MaLhp;
				case "TenHp":
					return entity.TenHp;
				case "LoaiHp":
					return entity.LoaiHp;
				case "SoTc":
					return entity.SoTc;
				case "SiSoLop":
					return entity.SiSoLop;
				case "SiSoDk":
					return entity.SiSoDk;
				case "MaLop":
					return entity.MaLop;
				case "MaCbgd":
					return entity.MaCbgd;
				case "TenCbgd":
					return entity.TenCbgd;
				case "Tkb":
					return entity.Tkb;
				case "HocKy":
					return entity.HocKy;
				case "NamHoc":
					return entity.NamHoc;
				case "MaGiangVien":
					return entity.MaGiangVien;
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
			return GetPropertyValueByName(this as ViewDanhSachLopPhanCongGiangDay, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{15}{14}- MaGocLhp: {0}{14}- MaLhp: {1}{14}- TenHp: {2}{14}- LoaiHp: {3}{14}- SoTc: {4}{14}- SiSoLop: {5}{14}- SiSoDk: {6}{14}- MaLop: {7}{14}- MaCbgd: {8}{14}- TenCbgd: {9}{14}- Tkb: {10}{14}- HocKy: {11}{14}- NamHoc: {12}{14}- MaGiangVien: {13}{14}", 
				this.MaGocLhp,
				(this.MaLhp == null) ? string.Empty : this.MaLhp.ToString(),
			     
				this.TenHp,
				this.LoaiHp,
				(this.SoTc == null) ? string.Empty : this.SoTc.ToString(),
			     
				(this.SiSoLop == null) ? string.Empty : this.SiSoLop.ToString(),
			     
				(this.SiSoDk == null) ? string.Empty : this.SiSoDk.ToString(),
			     
				(this.MaLop == null) ? string.Empty : this.MaLop.ToString(),
			     
				(this.MaCbgd == null) ? string.Empty : this.MaCbgd.ToString(),
			     
				(this.TenCbgd == null) ? string.Empty : this.TenCbgd.ToString(),
			     
				(this.Tkb == null) ? string.Empty : this.Tkb.ToString(),
			     
				this.HocKy,
				this.NamHoc,
				this.MaGiangVien,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewDanhSachLopPhanCongGiangDay columns.
	/// </summary>
	[Serializable]
	public enum ViewDanhSachLopPhanCongGiangDayColumn
	{
		/// <summary>
		/// MaGocLHP : 
		/// </summary>
		[EnumTextValue("MaGocLHP")]
		[ColumnEnum("MaGocLHP", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 30)]
		MaGocLhp,
		/// <summary>
		/// MaLHP : 
		/// </summary>
		[EnumTextValue("MaLHP")]
		[ColumnEnum("MaLHP", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 30)]
		MaLhp,
		/// <summary>
		/// TenHP : 
		/// </summary>
		[EnumTextValue("TenHP")]
		[ColumnEnum("TenHP", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenHp,
		/// <summary>
		/// LoaiHP : 
		/// </summary>
		[EnumTextValue("LoaiHP")]
		[ColumnEnum("LoaiHP", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		LoaiHp,
		/// <summary>
		/// SoTC : 
		/// </summary>
		[EnumTextValue("SoTC")]
		[ColumnEnum("SoTC", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 77)]
		SoTc,
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		[EnumTextValue("SiSoLop")]
		[ColumnEnum("SiSoLop", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		SiSoLop,
		/// <summary>
		/// SiSoDK : 
		/// </summary>
		[EnumTextValue("SiSoDK")]
		[ColumnEnum("SiSoDK", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSoDk,
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 255)]
		MaLop,
		/// <summary>
		/// MaCBGD : 
		/// </summary>
		[EnumTextValue("MaCBGD")]
		[ColumnEnum("MaCBGD", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 255)]
		MaCbgd,
		/// <summary>
		/// TenCBGD : 
		/// </summary>
		[EnumTextValue("TenCBGD")]
		[ColumnEnum("TenCBGD", typeof(System.String), System.Data.DbType.String, false, false, true, 255)]
		TenCbgd,
		/// <summary>
		/// TKB : 
		/// </summary>
		[EnumTextValue("TKB")]
		[ColumnEnum("TKB", typeof(System.String), System.Data.DbType.String, false, false, true, 255)]
		Tkb,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		HocKy,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		NamHoc,
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaGiangVien
	}//End enum

} // end namespace
