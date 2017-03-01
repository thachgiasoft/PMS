﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewGiangVienChamThiLan2.cs instead.
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
	/// An object representation of the 'View_GiangVien_ChamThi_Lan2' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewGiangVienChamThiLan2Base")]
	public abstract partial class ViewGiangVienChamThiLan2Base : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaChiTietChamThi : 
		/// </summary>
		private System.Int32		  _maChiTietChamThi = (int)0;
		
		/// <summary>
		/// MaKyThi : 
		/// </summary>
		private System.Int32?		  _maKyThi = null;
		
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		private System.String		  _maLopHocPhan = null;
		
		/// <summary>
		/// MaGiangVienChamThi : 
		/// </summary>
		private System.String		  _maGiangVienChamThi = null;
		
		/// <summary>
		/// HoTen : 
		/// </summary>
		private System.String		  _hoTen = null;
		
		/// <summary>
		/// SoBaiThiDaCham : 
		/// </summary>
		private System.Int32?		  _soBaiThiDaCham = null;
		
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		private System.Int32?		  _siSoLop = null;
		
		/// <summary>
		/// HocKy : 
		/// </summary>
		private System.String		  _hocKy = null;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// NoiLamViec : 
		/// </summary>
		private System.String		  _noiLamViec = null;
		
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		private System.String		  _maMonHoc = null;
		
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		private System.String		  _tenMonHoc = string.Empty;
		
		/// <summary>
		/// ThanhTienTruocThue : 
		/// </summary>
		private System.Decimal?		  _thanhTienTruocThue = null;
		
		/// <summary>
		/// Thue10 : 
		/// </summary>
		private System.Decimal?		  _thue10 = null;
		
		/// <summary>
		/// ThanhTienSauThue : 
		/// </summary>
		private System.Decimal?		  _thanhTienSauThue = null;
		
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
		/// Creates a new <see cref="ViewGiangVienChamThiLan2Base"/> instance.
		///</summary>
		public ViewGiangVienChamThiLan2Base()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewGiangVienChamThiLan2Base"/> instance.
		///</summary>
		///<param name="_maChiTietChamThi"></param>
		///<param name="_maKyThi"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maGiangVienChamThi"></param>
		///<param name="_hoTen"></param>
		///<param name="_soBaiThiDaCham"></param>
		///<param name="_siSoLop"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		///<param name="_noiLamViec"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_thanhTienTruocThue"></param>
		///<param name="_thue10"></param>
		///<param name="_thanhTienSauThue"></param>
		public ViewGiangVienChamThiLan2Base(System.Int32 _maChiTietChamThi, System.Int32? _maKyThi, System.String _maLopHocPhan, System.String _maGiangVienChamThi, System.String _hoTen, System.Int32? _soBaiThiDaCham, System.Int32? _siSoLop, System.String _hocKy, System.String _namHoc, System.String _noiLamViec, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal? _thanhTienTruocThue, System.Decimal? _thue10, System.Decimal? _thanhTienSauThue)
		{
			this._maChiTietChamThi = _maChiTietChamThi;
			this._maKyThi = _maKyThi;
			this._maLopHocPhan = _maLopHocPhan;
			this._maGiangVienChamThi = _maGiangVienChamThi;
			this._hoTen = _hoTen;
			this._soBaiThiDaCham = _soBaiThiDaCham;
			this._siSoLop = _siSoLop;
			this._hocKy = _hocKy;
			this._namHoc = _namHoc;
			this._noiLamViec = _noiLamViec;
			this._maMonHoc = _maMonHoc;
			this._tenMonHoc = _tenMonHoc;
			this._thanhTienTruocThue = _thanhTienTruocThue;
			this._thue10 = _thue10;
			this._thanhTienSauThue = _thanhTienSauThue;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewGiangVienChamThiLan2"/> instance.
		///</summary>
		///<param name="_maChiTietChamThi"></param>
		///<param name="_maKyThi"></param>
		///<param name="_maLopHocPhan"></param>
		///<param name="_maGiangVienChamThi"></param>
		///<param name="_hoTen"></param>
		///<param name="_soBaiThiDaCham"></param>
		///<param name="_siSoLop"></param>
		///<param name="_hocKy"></param>
		///<param name="_namHoc"></param>
		///<param name="_noiLamViec"></param>
		///<param name="_maMonHoc"></param>
		///<param name="_tenMonHoc"></param>
		///<param name="_thanhTienTruocThue"></param>
		///<param name="_thue10"></param>
		///<param name="_thanhTienSauThue"></param>
		public static ViewGiangVienChamThiLan2 CreateViewGiangVienChamThiLan2(System.Int32 _maChiTietChamThi, System.Int32? _maKyThi, System.String _maLopHocPhan, System.String _maGiangVienChamThi, System.String _hoTen, System.Int32? _soBaiThiDaCham, System.Int32? _siSoLop, System.String _hocKy, System.String _namHoc, System.String _noiLamViec, System.String _maMonHoc, System.String _tenMonHoc, System.Decimal? _thanhTienTruocThue, System.Decimal? _thue10, System.Decimal? _thanhTienSauThue)
		{
			ViewGiangVienChamThiLan2 newViewGiangVienChamThiLan2 = new ViewGiangVienChamThiLan2();
			newViewGiangVienChamThiLan2.MaChiTietChamThi = _maChiTietChamThi;
			newViewGiangVienChamThiLan2.MaKyThi = _maKyThi;
			newViewGiangVienChamThiLan2.MaLopHocPhan = _maLopHocPhan;
			newViewGiangVienChamThiLan2.MaGiangVienChamThi = _maGiangVienChamThi;
			newViewGiangVienChamThiLan2.HoTen = _hoTen;
			newViewGiangVienChamThiLan2.SoBaiThiDaCham = _soBaiThiDaCham;
			newViewGiangVienChamThiLan2.SiSoLop = _siSoLop;
			newViewGiangVienChamThiLan2.HocKy = _hocKy;
			newViewGiangVienChamThiLan2.NamHoc = _namHoc;
			newViewGiangVienChamThiLan2.NoiLamViec = _noiLamViec;
			newViewGiangVienChamThiLan2.MaMonHoc = _maMonHoc;
			newViewGiangVienChamThiLan2.TenMonHoc = _tenMonHoc;
			newViewGiangVienChamThiLan2.ThanhTienTruocThue = _thanhTienTruocThue;
			newViewGiangVienChamThiLan2.Thue10 = _thue10;
			newViewGiangVienChamThiLan2.ThanhTienSauThue = _thanhTienSauThue;
			return newViewGiangVienChamThiLan2;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaChiTietChamThi property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaChiTietChamThi
		{
			get
			{
				return this._maChiTietChamThi; 
			}
			set
			{
				if (_maChiTietChamThi == value)
					return;
					
				this._maChiTietChamThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaChiTietChamThi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaKyThi property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsMaKyThiNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? MaKyThi
		{
			get
			{
				return this._maKyThi; 
			}
			set
			{
				if (_maKyThi == value && MaKyThi != null )
					return;
					
				this._maKyThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaKyThi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaLopHocPhan property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaLopHocPhan
		{
			get
			{
				return this._maLopHocPhan; 
			}
			set
			{
				if (_maLopHocPhan == value)
					return;
					
				this._maLopHocPhan = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaLopHocPhan");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaGiangVienChamThi property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaGiangVienChamThi
		{
			get
			{
				return this._maGiangVienChamThi; 
			}
			set
			{
				if (_maGiangVienChamThi == value)
					return;
					
				this._maGiangVienChamThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVienChamThi");
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
		/// 	Gets or Sets the SoBaiThiDaCham property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsSoBaiThiDaChamNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? SoBaiThiDaCham
		{
			get
			{
				return this._soBaiThiDaCham; 
			}
			set
			{
				if (_soBaiThiDaCham == value && SoBaiThiDaCham != null )
					return;
					
				this._soBaiThiDaCham = value;
				this._isDirty = true;
				
				OnPropertyChanged("SoBaiThiDaCham");
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
		/// 	Gets or Sets the HocKy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
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
		/// 	Gets or Sets the NamHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
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
		/// 	Gets or Sets the NoiLamViec property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String NoiLamViec
		{
			get
			{
				return this._noiLamViec; 
			}
			set
			{
				if (_noiLamViec == value)
					return;
					
				this._noiLamViec = value;
				this._isDirty = true;
				
				OnPropertyChanged("NoiLamViec");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaMonHoc property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaMonHoc
		{
			get
			{
				return this._maMonHoc; 
			}
			set
			{
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
		/// 	Gets or Sets the ThanhTienTruocThue property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsThanhTienTruocThueNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? ThanhTienTruocThue
		{
			get
			{
				return this._thanhTienTruocThue; 
			}
			set
			{
				if (_thanhTienTruocThue == value && ThanhTienTruocThue != null )
					return;
					
				this._thanhTienTruocThue = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThanhTienTruocThue");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Thue10 property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsThue10Null() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? Thue10
		{
			get
			{
				return this._thue10; 
			}
			set
			{
				if (_thue10 == value && Thue10 != null )
					return;
					
				this._thue10 = value;
				this._isDirty = true;
				
				OnPropertyChanged("Thue10");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ThanhTienSauThue property. 
		///		
		/// </summary>
		/// <value>This type is numeric</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsThanhTienSauThueNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? ThanhTienSauThue
		{
			get
			{
				return this._thanhTienSauThue; 
			}
			set
			{
				if (_thanhTienSauThue == value && ThanhTienSauThue != null )
					return;
					
				this._thanhTienSauThue = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThanhTienSauThue");
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
			get { return "View_GiangVien_ChamThi_Lan2"; }
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
		///  Returns a Typed ViewGiangVienChamThiLan2Base Entity 
		///</summary>
		public virtual ViewGiangVienChamThiLan2Base Copy()
		{
			//shallow copy entity
			ViewGiangVienChamThiLan2 copy = new ViewGiangVienChamThiLan2();
				copy.MaChiTietChamThi = this.MaChiTietChamThi;
				copy.MaKyThi = this.MaKyThi;
				copy.MaLopHocPhan = this.MaLopHocPhan;
				copy.MaGiangVienChamThi = this.MaGiangVienChamThi;
				copy.HoTen = this.HoTen;
				copy.SoBaiThiDaCham = this.SoBaiThiDaCham;
				copy.SiSoLop = this.SiSoLop;
				copy.HocKy = this.HocKy;
				copy.NamHoc = this.NamHoc;
				copy.NoiLamViec = this.NoiLamViec;
				copy.MaMonHoc = this.MaMonHoc;
				copy.TenMonHoc = this.TenMonHoc;
				copy.ThanhTienTruocThue = this.ThanhTienTruocThue;
				copy.Thue10 = this.Thue10;
				copy.ThanhTienSauThue = this.ThanhTienSauThue;
			copy.AcceptChanges();
			return (ViewGiangVienChamThiLan2)copy;
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
		///<returns>true if toObject is a <see cref="ViewGiangVienChamThiLan2Base"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewGiangVienChamThiLan2Base toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewGiangVienChamThiLan2Base"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewGiangVienChamThiLan2Base"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewGiangVienChamThiLan2Base"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewGiangVienChamThiLan2Base Object1, ViewGiangVienChamThiLan2Base Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaChiTietChamThi != Object2.MaChiTietChamThi)
				equal = false;
			if (Object1.MaKyThi != null && Object2.MaKyThi != null )
			{
				if (Object1.MaKyThi != Object2.MaKyThi)
					equal = false;
			}
			else if (Object1.MaKyThi == null ^ Object1.MaKyThi == null )
			{
				equal = false;
			}
			if (Object1.MaLopHocPhan != null && Object2.MaLopHocPhan != null )
			{
				if (Object1.MaLopHocPhan != Object2.MaLopHocPhan)
					equal = false;
			}
			else if (Object1.MaLopHocPhan == null ^ Object1.MaLopHocPhan == null )
			{
				equal = false;
			}
			if (Object1.MaGiangVienChamThi != null && Object2.MaGiangVienChamThi != null )
			{
				if (Object1.MaGiangVienChamThi != Object2.MaGiangVienChamThi)
					equal = false;
			}
			else if (Object1.MaGiangVienChamThi == null ^ Object1.MaGiangVienChamThi == null )
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
			if (Object1.SoBaiThiDaCham != null && Object2.SoBaiThiDaCham != null )
			{
				if (Object1.SoBaiThiDaCham != Object2.SoBaiThiDaCham)
					equal = false;
			}
			else if (Object1.SoBaiThiDaCham == null ^ Object1.SoBaiThiDaCham == null )
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
			if (Object1.HocKy != null && Object2.HocKy != null )
			{
				if (Object1.HocKy != Object2.HocKy)
					equal = false;
			}
			else if (Object1.HocKy == null ^ Object1.HocKy == null )
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
			if (Object1.NoiLamViec != null && Object2.NoiLamViec != null )
			{
				if (Object1.NoiLamViec != Object2.NoiLamViec)
					equal = false;
			}
			else if (Object1.NoiLamViec == null ^ Object1.NoiLamViec == null )
			{
				equal = false;
			}
			if (Object1.MaMonHoc != null && Object2.MaMonHoc != null )
			{
				if (Object1.MaMonHoc != Object2.MaMonHoc)
					equal = false;
			}
			else if (Object1.MaMonHoc == null ^ Object1.MaMonHoc == null )
			{
				equal = false;
			}
			if (Object1.TenMonHoc != Object2.TenMonHoc)
				equal = false;
			if (Object1.ThanhTienTruocThue != null && Object2.ThanhTienTruocThue != null )
			{
				if (Object1.ThanhTienTruocThue != Object2.ThanhTienTruocThue)
					equal = false;
			}
			else if (Object1.ThanhTienTruocThue == null ^ Object1.ThanhTienTruocThue == null )
			{
				equal = false;
			}
			if (Object1.Thue10 != null && Object2.Thue10 != null )
			{
				if (Object1.Thue10 != Object2.Thue10)
					equal = false;
			}
			else if (Object1.Thue10 == null ^ Object1.Thue10 == null )
			{
				equal = false;
			}
			if (Object1.ThanhTienSauThue != null && Object2.ThanhTienSauThue != null )
			{
				if (Object1.ThanhTienSauThue != Object2.ThanhTienSauThue)
					equal = false;
			}
			else if (Object1.ThanhTienSauThue == null ^ Object1.ThanhTienSauThue == null )
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
		public static object GetPropertyValueByName(ViewGiangVienChamThiLan2 entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaChiTietChamThi":
					return entity.MaChiTietChamThi;
				case "MaKyThi":
					return entity.MaKyThi;
				case "MaLopHocPhan":
					return entity.MaLopHocPhan;
				case "MaGiangVienChamThi":
					return entity.MaGiangVienChamThi;
				case "HoTen":
					return entity.HoTen;
				case "SoBaiThiDaCham":
					return entity.SoBaiThiDaCham;
				case "SiSoLop":
					return entity.SiSoLop;
				case "HocKy":
					return entity.HocKy;
				case "NamHoc":
					return entity.NamHoc;
				case "NoiLamViec":
					return entity.NoiLamViec;
				case "MaMonHoc":
					return entity.MaMonHoc;
				case "TenMonHoc":
					return entity.TenMonHoc;
				case "ThanhTienTruocThue":
					return entity.ThanhTienTruocThue;
				case "Thue10":
					return entity.Thue10;
				case "ThanhTienSauThue":
					return entity.ThanhTienSauThue;
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
			return GetPropertyValueByName(this as ViewGiangVienChamThiLan2, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{16}{15}- MaChiTietChamThi: {0}{15}- MaKyThi: {1}{15}- MaLopHocPhan: {2}{15}- MaGiangVienChamThi: {3}{15}- HoTen: {4}{15}- SoBaiThiDaCham: {5}{15}- SiSoLop: {6}{15}- HocKy: {7}{15}- NamHoc: {8}{15}- NoiLamViec: {9}{15}- MaMonHoc: {10}{15}- TenMonHoc: {11}{15}- ThanhTienTruocThue: {12}{15}- Thue10: {13}{15}- ThanhTienSauThue: {14}{15}", 
				this.MaChiTietChamThi,
				(this.MaKyThi == null) ? string.Empty : this.MaKyThi.ToString(),
			     
				(this.MaLopHocPhan == null) ? string.Empty : this.MaLopHocPhan.ToString(),
			     
				(this.MaGiangVienChamThi == null) ? string.Empty : this.MaGiangVienChamThi.ToString(),
			     
				(this.HoTen == null) ? string.Empty : this.HoTen.ToString(),
			     
				(this.SoBaiThiDaCham == null) ? string.Empty : this.SoBaiThiDaCham.ToString(),
			     
				(this.SiSoLop == null) ? string.Empty : this.SiSoLop.ToString(),
			     
				(this.HocKy == null) ? string.Empty : this.HocKy.ToString(),
			     
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.NoiLamViec == null) ? string.Empty : this.NoiLamViec.ToString(),
			     
				(this.MaMonHoc == null) ? string.Empty : this.MaMonHoc.ToString(),
			     
				this.TenMonHoc,
				(this.ThanhTienTruocThue == null) ? string.Empty : this.ThanhTienTruocThue.ToString(),
			     
				(this.Thue10 == null) ? string.Empty : this.Thue10.ToString(),
			     
				(this.ThanhTienSauThue == null) ? string.Empty : this.ThanhTienSauThue.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewGiangVienChamThiLan2 columns.
	/// </summary>
	[Serializable]
	public enum ViewGiangVienChamThiLan2Column
	{
		/// <summary>
		/// MaChiTietChamThi : 
		/// </summary>
		[EnumTextValue("MaChiTietChamThi")]
		[ColumnEnum("MaChiTietChamThi", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaChiTietChamThi,
		/// <summary>
		/// MaKyThi : 
		/// </summary>
		[EnumTextValue("MaKyThi")]
		[ColumnEnum("MaKyThi", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		MaKyThi,
		/// <summary>
		/// MaLopHocPhan : 
		/// </summary>
		[EnumTextValue("MaLopHocPhan")]
		[ColumnEnum("MaLopHocPhan", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaLopHocPhan,
		/// <summary>
		/// MaGiangVienChamThi : 
		/// </summary>
		[EnumTextValue("MaGiangVienChamThi")]
		[ColumnEnum("MaGiangVienChamThi", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaGiangVienChamThi,
		/// <summary>
		/// HoTen : 
		/// </summary>
		[EnumTextValue("HoTen")]
		[ColumnEnum("HoTen", typeof(System.String), System.Data.DbType.String, false, false, true, 152)]
		HoTen,
		/// <summary>
		/// SoBaiThiDaCham : 
		/// </summary>
		[EnumTextValue("SoBaiThiDaCham")]
		[ColumnEnum("SoBaiThiDaCham", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SoBaiThiDaCham,
		/// <summary>
		/// SiSoLop : 
		/// </summary>
		[EnumTextValue("SiSoLop")]
		[ColumnEnum("SiSoLop", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		SiSoLop,
		/// <summary>
		/// HocKy : 
		/// </summary>
		[EnumTextValue("HocKy")]
		[ColumnEnum("HocKy", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		HocKy,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// NoiLamViec : 
		/// </summary>
		[EnumTextValue("NoiLamViec")]
		[ColumnEnum("NoiLamViec", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		NoiLamViec,
		/// <summary>
		/// MaMonHoc : 
		/// </summary>
		[EnumTextValue("MaMonHoc")]
		[ColumnEnum("MaMonHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		MaMonHoc,
		/// <summary>
		/// TenMonHoc : 
		/// </summary>
		[EnumTextValue("TenMonHoc")]
		[ColumnEnum("TenMonHoc", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenMonHoc,
		/// <summary>
		/// ThanhTienTruocThue : 
		/// </summary>
		[EnumTextValue("ThanhTienTruocThue")]
		[ColumnEnum("ThanhTienTruocThue", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		ThanhTienTruocThue,
		/// <summary>
		/// Thue10 : 
		/// </summary>
		[EnumTextValue("Thue10")]
		[ColumnEnum("Thue10", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		Thue10,
		/// <summary>
		/// ThanhTienSauThue : 
		/// </summary>
		[EnumTextValue("ThanhTienSauThue")]
		[ColumnEnum("ThanhTienSauThue", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		ThanhTienSauThue
	}//End enum

} // end namespace
