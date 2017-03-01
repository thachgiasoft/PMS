﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewBacDaoTao.cs instead.
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
	/// An object representation of the 'View_BacDaoTao' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewBacDaoTaoBase")]
	public abstract partial class ViewBacDaoTaoBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaBacDaoTao : 
		/// </summary>
		private System.String		  _maBacDaoTao = string.Empty;
		
		/// <summary>
		/// TenBacDaoTao : 
		/// </summary>
		private System.String		  _tenBacDaoTao = string.Empty;
		
		/// <summary>
		/// Stt : 
		/// </summary>
		private System.String		  _stt = null;
		
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
		/// Creates a new <see cref="ViewBacDaoTaoBase"/> instance.
		///</summary>
		public ViewBacDaoTaoBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewBacDaoTaoBase"/> instance.
		///</summary>
		///<param name="_maBacDaoTao"></param>
		///<param name="_tenBacDaoTao"></param>
		///<param name="_stt"></param>
		public ViewBacDaoTaoBase(System.String _maBacDaoTao, System.String _tenBacDaoTao, System.String _stt)
		{
			this._maBacDaoTao = _maBacDaoTao;
			this._tenBacDaoTao = _tenBacDaoTao;
			this._stt = _stt;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewBacDaoTao"/> instance.
		///</summary>
		///<param name="_maBacDaoTao"></param>
		///<param name="_tenBacDaoTao"></param>
		///<param name="_stt"></param>
		public static ViewBacDaoTao CreateViewBacDaoTao(System.String _maBacDaoTao, System.String _tenBacDaoTao, System.String _stt)
		{
			ViewBacDaoTao newViewBacDaoTao = new ViewBacDaoTao();
			newViewBacDaoTao.MaBacDaoTao = _maBacDaoTao;
			newViewBacDaoTao.TenBacDaoTao = _tenBacDaoTao;
			newViewBacDaoTao.Stt = _stt;
			return newViewBacDaoTao;
		}
				
		#endregion Constructors
		
		#region Properties	
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
		/// 	Gets or Sets the Stt property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[XmlElement(IsNullable=true)]
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Stt
		{
			get
			{
				return this._stt; 
			}
			set
			{
				if (_stt == value)
					return;
					
				this._stt = value;
				this._isDirty = true;
				
				OnPropertyChanged("Stt");
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
			get { return "View_BacDaoTao"; }
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
		///  Returns a Typed ViewBacDaoTaoBase Entity 
		///</summary>
		public virtual ViewBacDaoTaoBase Copy()
		{
			//shallow copy entity
			ViewBacDaoTao copy = new ViewBacDaoTao();
				copy.MaBacDaoTao = this.MaBacDaoTao;
				copy.TenBacDaoTao = this.TenBacDaoTao;
				copy.Stt = this.Stt;
			copy.AcceptChanges();
			return (ViewBacDaoTao)copy;
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
		///<returns>true if toObject is a <see cref="ViewBacDaoTaoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewBacDaoTaoBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewBacDaoTaoBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewBacDaoTaoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewBacDaoTaoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewBacDaoTaoBase Object1, ViewBacDaoTaoBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.MaBacDaoTao != Object2.MaBacDaoTao)
				equal = false;
			if (Object1.TenBacDaoTao != Object2.TenBacDaoTao)
				equal = false;
			if (Object1.Stt != null && Object2.Stt != null )
			{
				if (Object1.Stt != Object2.Stt)
					equal = false;
			}
			else if (Object1.Stt == null ^ Object1.Stt == null )
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
		public static object GetPropertyValueByName(ViewBacDaoTao entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaBacDaoTao":
					return entity.MaBacDaoTao;
				case "TenBacDaoTao":
					return entity.TenBacDaoTao;
				case "Stt":
					return entity.Stt;
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
			return GetPropertyValueByName(this as ViewBacDaoTao, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{4}{3}- MaBacDaoTao: {0}{3}- TenBacDaoTao: {1}{3}- Stt: {2}{3}", 
				this.MaBacDaoTao,
				this.TenBacDaoTao,
				(this.Stt == null) ? string.Empty : this.Stt.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewBacDaoTao columns.
	/// </summary>
	[Serializable]
	public enum ViewBacDaoTaoColumn
	{
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
		/// Stt : 
		/// </summary>
		[EnumTextValue("Stt")]
		[ColumnEnum("Stt", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 20)]
		Stt
	}//End enum

} // end namespace
