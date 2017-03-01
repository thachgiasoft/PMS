﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewLopChatLuongCao.cs instead.
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
	/// An object representation of the 'View_LopChatLuongCao' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewLopChatLuongCaoBase")]
	public abstract partial class ViewLopChatLuongCaoBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaLop : 
		/// </summary>
		private System.String		  _maLop = string.Empty;
		
		/// <summary>
		/// TenLop : 
		/// </summary>
		private System.String		  _tenLop = string.Empty;
		
		/// <summary>
		/// TenKhoaHoc : 
		/// </summary>
		private System.String		  _tenKhoaHoc = string.Empty;
		
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		private System.String		  _tenKhoa = string.Empty;
		
		/// <summary>
		/// NamHoc : 
		/// </summary>
		private System.String		  _namHoc = null;
		
		/// <summary>
		/// Chon : 
		/// </summary>
		private System.Boolean?		  _chon = null;
		
		/// <summary>
		/// NgayCapNhat : 
		/// </summary>
		private System.String		  _ngayCapNhat = null;
		
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
		/// Creates a new <see cref="ViewLopChatLuongCaoBase"/> instance.
		///</summary>
		public ViewLopChatLuongCaoBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewLopChatLuongCaoBase"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_tenLop"></param>
		///<param name="_tenKhoaHoc"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_namHoc"></param>
		///<param name="_chon"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public ViewLopChatLuongCaoBase(System.String _maLop, System.String _tenLop, System.String _tenKhoaHoc, System.String _tenKhoa, System.String _namHoc, System.Boolean? _chon, System.String _ngayCapNhat, System.String _nguoiCapNhat)
		{
			this._maLop = _maLop;
			this._tenLop = _tenLop;
			this._tenKhoaHoc = _tenKhoaHoc;
			this._tenKhoa = _tenKhoa;
			this._namHoc = _namHoc;
			this._chon = _chon;
			this._ngayCapNhat = _ngayCapNhat;
			this._nguoiCapNhat = _nguoiCapNhat;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewLopChatLuongCao"/> instance.
		///</summary>
		///<param name="_maLop"></param>
		///<param name="_tenLop"></param>
		///<param name="_tenKhoaHoc"></param>
		///<param name="_tenKhoa"></param>
		///<param name="_namHoc"></param>
		///<param name="_chon"></param>
		///<param name="_ngayCapNhat"></param>
		///<param name="_nguoiCapNhat"></param>
		public static ViewLopChatLuongCao CreateViewLopChatLuongCao(System.String _maLop, System.String _tenLop, System.String _tenKhoaHoc, System.String _tenKhoa, System.String _namHoc, System.Boolean? _chon, System.String _ngayCapNhat, System.String _nguoiCapNhat)
		{
			ViewLopChatLuongCao newViewLopChatLuongCao = new ViewLopChatLuongCao();
			newViewLopChatLuongCao.MaLop = _maLop;
			newViewLopChatLuongCao.TenLop = _tenLop;
			newViewLopChatLuongCao.TenKhoaHoc = _tenKhoaHoc;
			newViewLopChatLuongCao.TenKhoa = _tenKhoa;
			newViewLopChatLuongCao.NamHoc = _namHoc;
			newViewLopChatLuongCao.Chon = _chon;
			newViewLopChatLuongCao.NgayCapNhat = _ngayCapNhat;
			newViewLopChatLuongCao.NguoiCapNhat = _nguoiCapNhat;
			return newViewLopChatLuongCao;
		}
				
		#endregion Constructors
		
		#region Properties	
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
		/// 	Gets or Sets the TenKhoaHoc property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenKhoaHoc
		{
			get
			{
				return this._tenKhoaHoc; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenKhoaHoc does not allow null values.");
				if (_tenKhoaHoc == value)
					return;
					
				this._tenKhoaHoc = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenKhoaHoc");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenKhoa property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenKhoa
		{
			get
			{
				return this._tenKhoa; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "TenKhoa does not allow null values.");
				if (_tenKhoa == value)
					return;
					
				this._tenKhoa = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenKhoa");
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
		/// 	Gets or Sets the Chon property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsChonNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean? Chon
		{
			get
			{
				return this._chon; 
			}
			set
			{
				if (_chon == value && Chon != null )
					return;
					
				this._chon = value;
				this._isDirty = true;
				
				OnPropertyChanged("Chon");
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
			get { return "View_LopChatLuongCao"; }
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
		///  Returns a Typed ViewLopChatLuongCaoBase Entity 
		///</summary>
		public virtual ViewLopChatLuongCaoBase Copy()
		{
			//shallow copy entity
			ViewLopChatLuongCao copy = new ViewLopChatLuongCao();
				copy.MaLop = this.MaLop;
				copy.TenLop = this.TenLop;
				copy.TenKhoaHoc = this.TenKhoaHoc;
				copy.TenKhoa = this.TenKhoa;
				copy.NamHoc = this.NamHoc;
				copy.Chon = this.Chon;
				copy.NgayCapNhat = this.NgayCapNhat;
				copy.NguoiCapNhat = this.NguoiCapNhat;
			copy.AcceptChanges();
			return (ViewLopChatLuongCao)copy;
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
		///<returns>true if toObject is a <see cref="ViewLopChatLuongCaoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewLopChatLuongCaoBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewLopChatLuongCaoBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewLopChatLuongCaoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewLopChatLuongCaoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewLopChatLuongCaoBase Object1, ViewLopChatLuongCaoBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaLop != Object2.MaLop)
				equal = false;
			if (Object1.TenLop != Object2.TenLop)
				equal = false;
			if (Object1.TenKhoaHoc != Object2.TenKhoaHoc)
				equal = false;
			if (Object1.TenKhoa != Object2.TenKhoa)
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
			if (Object1.Chon != null && Object2.Chon != null )
			{
				if (Object1.Chon != Object2.Chon)
					equal = false;
			}
			else if (Object1.Chon == null ^ Object1.Chon == null )
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
		public static object GetPropertyValueByName(ViewLopChatLuongCao entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaLop":
					return entity.MaLop;
				case "TenLop":
					return entity.TenLop;
				case "TenKhoaHoc":
					return entity.TenKhoaHoc;
				case "TenKhoa":
					return entity.TenKhoa;
				case "NamHoc":
					return entity.NamHoc;
				case "Chon":
					return entity.Chon;
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
			return GetPropertyValueByName(this as ViewLopChatLuongCao, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{9}{8}- MaLop: {0}{8}- TenLop: {1}{8}- TenKhoaHoc: {2}{8}- TenKhoa: {3}{8}- NamHoc: {4}{8}- Chon: {5}{8}- NgayCapNhat: {6}{8}- NguoiCapNhat: {7}{8}", 
				this.MaLop,
				this.TenLop,
				this.TenKhoaHoc,
				this.TenKhoa,
				(this.NamHoc == null) ? string.Empty : this.NamHoc.ToString(),
			     
				(this.Chon == null) ? string.Empty : this.Chon.ToString(),
			     
				(this.NgayCapNhat == null) ? string.Empty : this.NgayCapNhat.ToString(),
			     
				(this.NguoiCapNhat == null) ? string.Empty : this.NguoiCapNhat.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewLopChatLuongCao columns.
	/// </summary>
	[Serializable]
	public enum ViewLopChatLuongCaoColumn
	{
		/// <summary>
		/// MaLop : 
		/// </summary>
		[EnumTextValue("MaLop")]
		[ColumnEnum("MaLop", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaLop,
		/// <summary>
		/// TenLop : 
		/// </summary>
		[EnumTextValue("TenLop")]
		[ColumnEnum("TenLop", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenLop,
		/// <summary>
		/// TenKhoaHoc : 
		/// </summary>
		[EnumTextValue("TenKhoaHoc")]
		[ColumnEnum("TenKhoaHoc", typeof(System.String), System.Data.DbType.String, false, false, false, 100)]
		TenKhoaHoc,
		/// <summary>
		/// TenKhoa : 
		/// </summary>
		[EnumTextValue("TenKhoa")]
		[ColumnEnum("TenKhoa", typeof(System.String), System.Data.DbType.String, false, false, false, 255)]
		TenKhoa,
		/// <summary>
		/// NamHoc : 
		/// </summary>
		[EnumTextValue("NamHoc")]
		[ColumnEnum("NamHoc", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		NamHoc,
		/// <summary>
		/// Chon : 
		/// </summary>
		[EnumTextValue("Chon")]
		[ColumnEnum("Chon", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		Chon,
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
		NguoiCapNhat
	}//End enum

} // end namespace
