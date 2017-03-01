﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewHinhThucThi.cs instead.
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
	/// An object representation of the 'View_HinhThucThi' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewHinhThucThiBase")]
	public abstract partial class ViewHinhThucThiBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaHinhThucThi : 
		/// </summary>
		private System.String		  _maHinhThucThi = string.Empty;
		
		/// <summary>
		/// TenHinhThucThi : 
		/// </summary>
		private System.String		  _tenHinhThucThi = null;
		
		/// <summary>
		/// ThoiGianThi : 
		/// </summary>
		private System.String		  _thoiGianThi = null;
		
		/// <summary>
		/// GhiChu : 
		/// </summary>
		private System.String		  _ghiChu = null;
		
		/// <summary>
		/// Coefficient : 
		/// </summary>
		private System.Decimal?		  _coefficient = null;
		
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
		/// Creates a new <see cref="ViewHinhThucThiBase"/> instance.
		///</summary>
		public ViewHinhThucThiBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewHinhThucThiBase"/> instance.
		///</summary>
		///<param name="_maHinhThucThi"></param>
		///<param name="_tenHinhThucThi"></param>
		///<param name="_thoiGianThi"></param>
		///<param name="_ghiChu"></param>
		///<param name="_coefficient"></param>
		public ViewHinhThucThiBase(System.String _maHinhThucThi, System.String _tenHinhThucThi, System.String _thoiGianThi, System.String _ghiChu, System.Decimal? _coefficient)
		{
			this._maHinhThucThi = _maHinhThucThi;
			this._tenHinhThucThi = _tenHinhThucThi;
			this._thoiGianThi = _thoiGianThi;
			this._ghiChu = _ghiChu;
			this._coefficient = _coefficient;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewHinhThucThi"/> instance.
		///</summary>
		///<param name="_maHinhThucThi"></param>
		///<param name="_tenHinhThucThi"></param>
		///<param name="_thoiGianThi"></param>
		///<param name="_ghiChu"></param>
		///<param name="_coefficient"></param>
		public static ViewHinhThucThi CreateViewHinhThucThi(System.String _maHinhThucThi, System.String _tenHinhThucThi, System.String _thoiGianThi, System.String _ghiChu, System.Decimal? _coefficient)
		{
			ViewHinhThucThi newViewHinhThucThi = new ViewHinhThucThi();
			newViewHinhThucThi.MaHinhThucThi = _maHinhThucThi;
			newViewHinhThucThi.TenHinhThucThi = _tenHinhThucThi;
			newViewHinhThucThi.ThoiGianThi = _thoiGianThi;
			newViewHinhThucThi.GhiChu = _ghiChu;
			newViewHinhThucThi.Coefficient = _coefficient;
			return newViewHinhThucThi;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaHinhThucThi property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHinhThucThi
		{
			get
			{
				return this._maHinhThucThi; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaHinhThucThi does not allow null values.");
				if (_maHinhThucThi == value)
					return;
					
				this._maHinhThucThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHinhThucThi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenHinhThucThi property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenHinhThucThi
		{
			get
			{
				return this._tenHinhThucThi; 
			}
			set
			{
				if (_tenHinhThucThi == value)
					return;
					
				this._tenHinhThucThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenHinhThucThi");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ThoiGianThi property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ThoiGianThi
		{
			get
			{
				return this._thoiGianThi; 
			}
			set
			{
				if (_thoiGianThi == value)
					return;
					
				this._thoiGianThi = value;
				this._isDirty = true;
				
				OnPropertyChanged("ThoiGianThi");
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
		/// 	Gets or Sets the Coefficient property. 
		///		
		/// </summary>
		/// <value>This type is decimal</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return 0.0m. It is up to the developer
		/// to check the value of IsCoefficientNull() and perform business logic appropriately.
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Decimal? Coefficient
		{
			get
			{
				return this._coefficient; 
			}
			set
			{
				if (_coefficient == value && Coefficient != null )
					return;
					
				this._coefficient = value;
				this._isDirty = true;
				
				OnPropertyChanged("Coefficient");
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
			get { return "View_HinhThucThi"; }
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
		///  Returns a Typed ViewHinhThucThiBase Entity 
		///</summary>
		public virtual ViewHinhThucThiBase Copy()
		{
			//shallow copy entity
			ViewHinhThucThi copy = new ViewHinhThucThi();
				copy.MaHinhThucThi = this.MaHinhThucThi;
				copy.TenHinhThucThi = this.TenHinhThucThi;
				copy.ThoiGianThi = this.ThoiGianThi;
				copy.GhiChu = this.GhiChu;
				copy.Coefficient = this.Coefficient;
			copy.AcceptChanges();
			return (ViewHinhThucThi)copy;
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
		///<returns>true if toObject is a <see cref="ViewHinhThucThiBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewHinhThucThiBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewHinhThucThiBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewHinhThucThiBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewHinhThucThiBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewHinhThucThiBase Object1, ViewHinhThucThiBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaHinhThucThi != Object2.MaHinhThucThi)
				equal = false;
			if (Object1.TenHinhThucThi != null && Object2.TenHinhThucThi != null )
			{
				if (Object1.TenHinhThucThi != Object2.TenHinhThucThi)
					equal = false;
			}
			else if (Object1.TenHinhThucThi == null ^ Object1.TenHinhThucThi == null )
			{
				equal = false;
			}
			if (Object1.ThoiGianThi != null && Object2.ThoiGianThi != null )
			{
				if (Object1.ThoiGianThi != Object2.ThoiGianThi)
					equal = false;
			}
			else if (Object1.ThoiGianThi == null ^ Object1.ThoiGianThi == null )
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
			if (Object1.Coefficient != null && Object2.Coefficient != null )
			{
				if (Object1.Coefficient != Object2.Coefficient)
					equal = false;
			}
			else if (Object1.Coefficient == null ^ Object1.Coefficient == null )
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
		public static object GetPropertyValueByName(ViewHinhThucThi entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaHinhThucThi":
					return entity.MaHinhThucThi;
				case "TenHinhThucThi":
					return entity.TenHinhThucThi;
				case "ThoiGianThi":
					return entity.ThoiGianThi;
				case "GhiChu":
					return entity.GhiChu;
				case "Coefficient":
					return entity.Coefficient;
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
			return GetPropertyValueByName(this as ViewHinhThucThi, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{6}{5}- MaHinhThucThi: {0}{5}- TenHinhThucThi: {1}{5}- ThoiGianThi: {2}{5}- GhiChu: {3}{5}- Coefficient: {4}{5}", 
				this.MaHinhThucThi,
				(this.TenHinhThucThi == null) ? string.Empty : this.TenHinhThucThi.ToString(),
			     
				(this.ThoiGianThi == null) ? string.Empty : this.ThoiGianThi.ToString(),
			     
				(this.GhiChu == null) ? string.Empty : this.GhiChu.ToString(),
			     
				(this.Coefficient == null) ? string.Empty : this.Coefficient.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewHinhThucThi columns.
	/// </summary>
	[Serializable]
	public enum ViewHinhThucThiColumn
	{
		/// <summary>
		/// MaHinhThucThi : 
		/// </summary>
		[EnumTextValue("MaHinhThucThi")]
		[ColumnEnum("MaHinhThucThi", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaHinhThucThi,
		/// <summary>
		/// TenHinhThucThi : 
		/// </summary>
		[EnumTextValue("TenHinhThucThi")]
		[ColumnEnum("TenHinhThucThi", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenHinhThucThi,
		/// <summary>
		/// ThoiGianThi : 
		/// </summary>
		[EnumTextValue("ThoiGianThi")]
		[ColumnEnum("ThoiGianThi", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		ThoiGianThi,
		/// <summary>
		/// GhiChu : 
		/// </summary>
		[EnumTextValue("GhiChu")]
		[ColumnEnum("GhiChu", typeof(System.String), System.Data.DbType.String, false, false, true, 255)]
		GhiChu,
		/// <summary>
		/// Coefficient : 
		/// </summary>
		[EnumTextValue("Coefficient")]
		[ColumnEnum("Coefficient", typeof(System.Decimal), System.Data.DbType.Decimal, false, false, true)]
		Coefficient
	}//End enum

} // end namespace
