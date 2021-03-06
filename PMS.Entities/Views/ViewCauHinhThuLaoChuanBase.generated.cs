﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewCauHinhThuLaoChuan.cs instead.
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
	/// An object representation of the 'View_CauHinh_ThuLaoChuan' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewCauHinhThuLaoChuanBase")]
	public abstract partial class ViewCauHinhThuLaoChuanBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		private System.String		  _maHeDaoTao = string.Empty;
		
		/// <summary>
		/// TenHeDaoTao : 
		/// </summary>
		private System.String		  _tenHeDaoTao = string.Empty;
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		private System.String		  _maBacDaoTao = string.Empty;
		
		/// <summary>
		/// TenBacDaoTao : 
		/// </summary>
		private System.String		  _tenBacDaoTao = string.Empty;
		
		/// <summary>
		/// MaLoaiGiangVien : 
		/// </summary>
		private System.Int32		  _maLoaiGiangVien = (int)0;
		
		/// <summary>
		/// TenLoaiGiangVien : 
		/// </summary>
		private System.String		  _tenLoaiGiangVien = null;
		
		/// <summary>
		/// MaVaiTroGiangDay : 
		/// </summary>
		private System.String		  _maVaiTroGiangDay = string.Empty;
		
		/// <summary>
		/// TenVaiTroGiangDay : 
		/// </summary>
		private System.String		  _tenVaiTroGiangDay = string.Empty;
		
		/// <summary>
		/// ThuLaoChuan : 
		/// </summary>
		private System.Int64?		  _thuLaoChuan = null;
		
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
		/// Creates a new <see cref="ViewCauHinhThuLaoChuanBase"/> instance.
		///</summary>
		public ViewCauHinhThuLaoChuanBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewCauHinhThuLaoChuanBase"/> instance.
		///</summary>
		///<param name="_maHeDaoTao"></param>
		///<param name="_tenHeDaoTao"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_tenBacDaoTao"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maVaiTroGiangDay"></param>
		///<param name="_tenVaiTroGiangDay"></param>
		///<param name="_thuLaoChuan"></param>
		public ViewCauHinhThuLaoChuanBase(System.String _maHeDaoTao, System.String _tenHeDaoTao, System.String _maBacDaoTao, System.String _tenBacDaoTao, System.Int32 _maLoaiGiangVien, System.String _tenLoaiGiangVien, System.String _maVaiTroGiangDay, System.String _tenVaiTroGiangDay, System.Int64? _thuLaoChuan)
		{
			this._maHeDaoTao = _maHeDaoTao;
			this._tenHeDaoTao = _tenHeDaoTao;
			this._maBacDaoTao = _maBacDaoTao;
			this._tenBacDaoTao = _tenBacDaoTao;
			this._maLoaiGiangVien = _maLoaiGiangVien;
			this._tenLoaiGiangVien = _tenLoaiGiangVien;
			this._maVaiTroGiangDay = _maVaiTroGiangDay;
			this._tenVaiTroGiangDay = _tenVaiTroGiangDay;
			this._thuLaoChuan = _thuLaoChuan;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewCauHinhThuLaoChuan"/> instance.
		///</summary>
		///<param name="_maHeDaoTao"></param>
		///<param name="_tenHeDaoTao"></param>
		///<param name="_maBacDaoTao"></param>
		///<param name="_tenBacDaoTao"></param>
		///<param name="_maLoaiGiangVien"></param>
		///<param name="_tenLoaiGiangVien"></param>
		///<param name="_maVaiTroGiangDay"></param>
		///<param name="_tenVaiTroGiangDay"></param>
		///<param name="_thuLaoChuan"></param>
		public static ViewCauHinhThuLaoChuan CreateViewCauHinhThuLaoChuan(System.String _maHeDaoTao, System.String _tenHeDaoTao, System.String _maBacDaoTao, System.String _tenBacDaoTao, System.Int32 _maLoaiGiangVien, System.String _tenLoaiGiangVien, System.String _maVaiTroGiangDay, System.String _tenVaiTroGiangDay, System.Int64? _thuLaoChuan)
		{
			ViewCauHinhThuLaoChuan newViewCauHinhThuLaoChuan = new ViewCauHinhThuLaoChuan();
			newViewCauHinhThuLaoChuan.MaHeDaoTao = _maHeDaoTao;
			newViewCauHinhThuLaoChuan.TenHeDaoTao = _tenHeDaoTao;
			newViewCauHinhThuLaoChuan.MaBacDaoTao = _maBacDaoTao;
			newViewCauHinhThuLaoChuan.TenBacDaoTao = _tenBacDaoTao;
			newViewCauHinhThuLaoChuan.MaLoaiGiangVien = _maLoaiGiangVien;
			newViewCauHinhThuLaoChuan.TenLoaiGiangVien = _tenLoaiGiangVien;
			newViewCauHinhThuLaoChuan.MaVaiTroGiangDay = _maVaiTroGiangDay;
			newViewCauHinhThuLaoChuan.TenVaiTroGiangDay = _tenVaiTroGiangDay;
			newViewCauHinhThuLaoChuan.ThuLaoChuan = _thuLaoChuan;
			return newViewCauHinhThuLaoChuan;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaHeDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHeDaoTao
		{
			get
			{
				return this._maHeDaoTao; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaHeDaoTao does not allow null values.");
				if (_maHeDaoTao == value)
					return;
					
				this._maHeDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHeDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHeDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHeDaoTao
		{
			get
			{
				return this._tenHeDaoTao; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenHeDaoTao does not allow null values.");
				if (_tenHeDaoTao == value)
					return;
					
				this._tenHeDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHeDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaBacDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaBacDaoTao
		{
			get
			{
				return this._maBacDaoTao; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaBacDaoTao does not allow null values.");
				if (_maBacDaoTao == value)
					return;
					
				this._maBacDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaBacDaoTao");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenBacDaoTao property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenBacDaoTao
		{
			get
			{
				return this._tenBacDaoTao; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenBacDaoTao does not allow null values.");
				if (_tenBacDaoTao == value)
					return;
					
				this._tenBacDaoTao = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenBacDaoTao");
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
		/// 	Gets or Sets the MaVaiTroGiangDay property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaVaiTroGiangDay
		{
			get
			{
				return this._maVaiTroGiangDay; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaVaiTroGiangDay does not allow null values.");
				if (_maVaiTroGiangDay == value)
					return;
					
				this._maVaiTroGiangDay = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaVaiTroGiangDay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenVaiTroGiangDay property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenVaiTroGiangDay
		{
			get
			{
				return this._tenVaiTroGiangDay; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenVaiTroGiangDay does not allow null values.");
				if (_tenVaiTroGiangDay == value)
					return;
					
				this._tenVaiTroGiangDay = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenVaiTroGiangDay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ThuLaoChuan property. 
		///		
		/// </summary>
		/// <value>This type is bigint</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (long)0. It is up to the developer
		/// to check the value of IsThuLaoChuanNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int64? ThuLaoChuan
		{
			get
			{
				return this._thuLaoChuan; 
			}
			set
			{
				if (_thuLaoChuan == value && ThuLaoChuan != null )
					return;
					
				this._thuLaoChuan = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThuLaoChuan");
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
			get { return "View_CauHinh_ThuLaoChuan"; }
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
		///  Returns a Typed ViewCauHinhThuLaoChuanBase Entity 
		///</summary>
		public virtual ViewCauHinhThuLaoChuanBase Copy()
		{
			//shallow copy entity
			ViewCauHinhThuLaoChuan copy = new ViewCauHinhThuLaoChuan();
				copy.MaHeDaoTao = this.MaHeDaoTao;
				copy.TenHeDaoTao = this.TenHeDaoTao;
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.TenBacDaoTao = this.TenBacDaoTao;
				copy.MaLoaiGiangVien = this.MaLoaiGiangVien;
				copy.TenLoaiGiangVien = this.TenLoaiGiangVien;
				copy.MaVaiTroGiangDay = this.MaVaiTroGiangDay;
				copy.TenVaiTroGiangDay = this.TenVaiTroGiangDay;
				copy.ThuLaoChuan = this.ThuLaoChuan;
			copy.AcceptChanges();
			return (ViewCauHinhThuLaoChuan)copy;
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
		///<returns>true if toObject is a <see cref="ViewCauHinhThuLaoChuanBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewCauHinhThuLaoChuanBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewCauHinhThuLaoChuanBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewCauHinhThuLaoChuanBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewCauHinhThuLaoChuanBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewCauHinhThuLaoChuanBase Object1, ViewCauHinhThuLaoChuanBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaHeDaoTao != Object2.MaHeDaoTao)
				equal = false;
			if (Object1.TenHeDaoTao != Object2.TenHeDaoTao)
				equal = false;
			if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
				equal = false;
			if (Object1.TenBacDaoTao != Object2.TenBacDaoTao)
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
			if (Object1.MaVaiTroGiangDay != Object2.MaVaiTroGiangDay)
				equal = false;
			if (Object1.TenVaiTroGiangDay != Object2.TenVaiTroGiangDay)
				equal = false;
			if (Object1.ThuLaoChuan != null && Object2.ThuLaoChuan != null )
			{
				if (Object1.ThuLaoChuan != Object2.ThuLaoChuan)
					equal = false;
			}
			else if (Object1.ThuLaoChuan == null ^ Object1.ThuLaoChuan == null )
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
		public static object GetPropertyValueByName(ViewCauHinhThuLaoChuan entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaHeDaoTao":
					return entity.MaHeDaoTao;
				case "TenHeDaoTao":
					return entity.TenHeDaoTao;
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "TenBacDaoTao":
					return entity.TenBacDaoTao;
				case "MaLoaiGiangVien":
					return entity.MaLoaiGiangVien;
				case "TenLoaiGiangVien":
					return entity.TenLoaiGiangVien;
				case "MaVaiTroGiangDay":
					return entity.MaVaiTroGiangDay;
				case "TenVaiTroGiangDay":
					return entity.TenVaiTroGiangDay;
				case "ThuLaoChuan":
					return entity.ThuLaoChuan;
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
			return GetPropertyValueByName(this as ViewCauHinhThuLaoChuan, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{10}{9}- MaHeDaoTao: {0}{9}- TenHeDaoTao: {1}{9}- MaBacDaoTao: {2}{9}- TenBacDaoTao: {3}{9}- MaLoaiGiangVien: {4}{9}- TenLoaiGiangVien: {5}{9}- MaVaiTroGiangDay: {6}{9}- TenVaiTroGiangDay: {7}{9}- ThuLaoChuan: {8}{9}", 
				this.MaHeDaoTao,
				this.TenHeDaoTao,
				this.MaBacDaoTao,
				this.TenBacDaoTao,
				this.MaLoaiGiangVien,
				(this.TenLoaiGiangVien == null) ? string.Empty : this.TenLoaiGiangVien.ToString(),
			     
				this.MaVaiTroGiangDay,
				this.TenVaiTroGiangDay,
				(this.ThuLaoChuan == null) ? string.Empty : this.ThuLaoChuan.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewCauHinhThuLaoChuan columns.
	/// </summary>
	[Serializable]
	public enum ViewCauHinhThuLaoChuanColumn
	{
		/// <summary>
		/// MaHeDaoTao : 
		/// </summary>
		[EnumTextValue("MaHeDaoTao")]
		[ColumnEnum("MaHeDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaHeDaoTao,
		/// <summary>
		/// TenHeDaoTao : 
		/// </summary>
		[EnumTextValue("TenHeDaoTao")]
		[ColumnEnum("TenHeDaoTao", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenHeDaoTao,
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		[EnumTextValue("MaBacDaoTao")]
		[ColumnEnum("MaBacDaoTao", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaBacDaoTao,
		/// <summary>
		/// TenBacDaoTao : 
		/// </summary>
		[EnumTextValue("TenBacDaoTao")]
		[ColumnEnum("TenBacDaoTao", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenBacDaoTao,
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
		/// MaVaiTroGiangDay : 
		/// </summary>
		[EnumTextValue("MaVaiTroGiangDay")]
		[ColumnEnum("MaVaiTroGiangDay", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaVaiTroGiangDay,
		/// <summary>
		/// TenVaiTroGiangDay : 
		/// </summary>
		[EnumTextValue("TenVaiTroGiangDay")]
		[ColumnEnum("TenVaiTroGiangDay", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenVaiTroGiangDay,
		/// <summary>
		/// ThuLaoChuan : 
		/// </summary>
		[EnumTextValue("ThuLaoChuan")]
		[ColumnEnum("ThuLaoChuan", typeof(System.Int64), System.Data.DbType.Int64, false, false, true)]
		ThuLaoChuan
	}//End enum

} // end namespace
