﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewNgayChotGio.cs instead.
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
	/// An object representation of the 'View_NgayChotGio' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewNgayChotGioBase")]
	public abstract partial class ViewNgayChotGioBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaCauHinhChotGio : 
		/// </summary>
		private System.Int32		  _maCauHinhChotGio = (int)0;
		
		/// <summary>
		/// TuNgay : 
		/// </summary>
		private System.DateTime?		  _tuNgay = null;
		
		/// <summary>
		/// DenNgay : 
		/// </summary>
		private System.DateTime?		  _denNgay = null;
		
		/// <summary>
		/// TenQuanLy : 
		/// </summary>
		private System.String		  _tenQuanLy = null;
		
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
		/// Creates a new <see cref="ViewNgayChotGioBase"/> instance.
		///</summary>
		public ViewNgayChotGioBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewNgayChotGioBase"/> instance.
		///</summary>
		///<param name="_maCauHinhChotGio"></param>
		///<param name="_tuNgay"></param>
		///<param name="_denNgay"></param>
		///<param name="_tenQuanLy"></param>
		public ViewNgayChotGioBase(System.Int32 _maCauHinhChotGio, System.DateTime? _tuNgay, System.DateTime? _denNgay, System.String _tenQuanLy)
		{
			this._maCauHinhChotGio = _maCauHinhChotGio;
			this._tuNgay = _tuNgay;
			this._denNgay = _denNgay;
			this._tenQuanLy = _tenQuanLy;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewNgayChotGio"/> instance.
		///</summary>
		///<param name="_maCauHinhChotGio"></param>
		///<param name="_tuNgay"></param>
		///<param name="_denNgay"></param>
		///<param name="_tenQuanLy"></param>
		public static ViewNgayChotGio CreateViewNgayChotGio(System.Int32 _maCauHinhChotGio, System.DateTime? _tuNgay, System.DateTime? _denNgay, System.String _tenQuanLy)
		{
			ViewNgayChotGio newViewNgayChotGio = new ViewNgayChotGio();
			newViewNgayChotGio.MaCauHinhChotGio = _maCauHinhChotGio;
			newViewNgayChotGio.TuNgay = _tuNgay;
			newViewNgayChotGio.DenNgay = _denNgay;
			newViewNgayChotGio.TenQuanLy = _tenQuanLy;
			return newViewNgayChotGio;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the MaCauHinhChotGio property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 MaCauHinhChotGio
		{
			get
			{
				return this._maCauHinhChotGio; 
			}
			set
			{
				if (_maCauHinhChotGio == value)
					return;
					
				this._maCauHinhChotGio = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaCauHinhChotGio");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TuNgay property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsTuNgayNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? TuNgay
		{
			get
			{
				return this._tuNgay; 
			}
			set
			{
				if (_tuNgay == value && TuNgay != null )
					return;
					
				this._tuNgay = value;
				this._isDirty = true;
				
				OnPropertyChanged("TuNgay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DenNgay property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsDenNgayNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? DenNgay
		{
			get
			{
				return this._denNgay; 
			}
			set
			{
				if (_denNgay == value && DenNgay != null )
					return;
					
				this._denNgay = value;
				this._isDirty = true;
				
				OnPropertyChanged("DenNgay");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TenQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String TenQuanLy
		{
			get
			{
				return this._tenQuanLy; 
			}
			set
			{
				if (_tenQuanLy == value)
					return;
					
				this._tenQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("TenQuanLy");
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
			get { return "View_NgayChotGio"; }
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
		///  Returns a Typed ViewNgayChotGioBase Entity 
		///</summary>
		public virtual ViewNgayChotGioBase Copy()
		{
			//shallow copy entity
			ViewNgayChotGio copy = new ViewNgayChotGio();
				copy.MaCauHinhChotGio = this.MaCauHinhChotGio;
				copy.TuNgay = this.TuNgay;
				copy.DenNgay = this.DenNgay;
				copy.TenQuanLy = this.TenQuanLy;
			copy.AcceptChanges();
			return (ViewNgayChotGio)copy;
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
		///<returns>true if toObject is a <see cref="ViewNgayChotGioBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewNgayChotGioBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewNgayChotGioBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewNgayChotGioBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewNgayChotGioBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewNgayChotGioBase Object1, ViewNgayChotGioBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaCauHinhChotGio != Object2.MaCauHinhChotGio)
				equal = false;
			if (Object1.TuNgay != null && Object2.TuNgay != null )
			{
				if (Object1.TuNgay != Object2.TuNgay)
					equal = false;
			}
			else if (Object1.TuNgay == null ^ Object1.TuNgay == null )
			{
				equal = false;
			}
			if (Object1.DenNgay != null && Object2.DenNgay != null )
			{
				if (Object1.DenNgay != Object2.DenNgay)
					equal = false;
			}
			else if (Object1.DenNgay == null ^ Object1.DenNgay == null )
			{
				equal = false;
			}
			if (Object1.TenQuanLy != null && Object2.TenQuanLy != null )
			{
				if (Object1.TenQuanLy != Object2.TenQuanLy)
					equal = false;
			}
			else if (Object1.TenQuanLy == null ^ Object1.TenQuanLy == null )
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
		public static object GetPropertyValueByName(ViewNgayChotGio entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaCauHinhChotGio":
					return entity.MaCauHinhChotGio;
				case "TuNgay":
					return entity.TuNgay;
				case "DenNgay":
					return entity.DenNgay;
				case "TenQuanLy":
					return entity.TenQuanLy;
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
			return GetPropertyValueByName(this as ViewNgayChotGio, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{5}{4}- MaCauHinhChotGio: {0}{4}- TuNgay: {1}{4}- DenNgay: {2}{4}- TenQuanLy: {3}{4}", 
				this.MaCauHinhChotGio,
				(this.TuNgay == null) ? string.Empty : this.TuNgay.ToString(),
			     
				(this.DenNgay == null) ? string.Empty : this.DenNgay.ToString(),
			     
				(this.TenQuanLy == null) ? string.Empty : this.TenQuanLy.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewNgayChotGio columns.
	/// </summary>
	[Serializable]
	public enum ViewNgayChotGioColumn
	{
		/// <summary>
		/// MaCauHinhChotGio : 
		/// </summary>
		[EnumTextValue("MaCauHinhChotGio")]
		[ColumnEnum("MaCauHinhChotGio", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaCauHinhChotGio,
		/// <summary>
		/// TuNgay : 
		/// </summary>
		[EnumTextValue("TuNgay")]
		[ColumnEnum("TuNgay", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		TuNgay,
		/// <summary>
		/// DenNgay : 
		/// </summary>
		[EnumTextValue("DenNgay")]
		[ColumnEnum("DenNgay", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		DenNgay,
		/// <summary>
		/// TenQuanLy : 
		/// </summary>
		[EnumTextValue("TenQuanLy")]
		[ColumnEnum("TenQuanLy", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		TenQuanLy
	}//End enum

} // end namespace
