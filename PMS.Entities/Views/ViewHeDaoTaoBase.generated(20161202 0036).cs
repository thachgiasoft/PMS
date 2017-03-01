﻿/*
	File generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewHeDaoTao.cs instead.
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
	/// An object representation of the 'View_HeDaoTao' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("ViewHeDaoTaoBase")]
	public abstract partial class ViewHeDaoTaoBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
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
		/// Creates a new <see cref="ViewHeDaoTaoBase"/> instance.
		///</summary>
		public ViewHeDaoTaoBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="ViewHeDaoTaoBase"/> instance.
		///</summary>
		///<param name="_maHeDaoTao"></param>
		///<param name="_tenHeDaoTao"></param>
		public ViewHeDaoTaoBase(System.String _maHeDaoTao, System.String _tenHeDaoTao)
		{
			this._maHeDaoTao = _maHeDaoTao;
			this._tenHeDaoTao = _tenHeDaoTao;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="ViewHeDaoTao"/> instance.
		///</summary>
		///<param name="_maHeDaoTao"></param>
		///<param name="_tenHeDaoTao"></param>
		public static ViewHeDaoTao CreateViewHeDaoTao(System.String _maHeDaoTao, System.String _tenHeDaoTao)
		{
			ViewHeDaoTao newViewHeDaoTao = new ViewHeDaoTao();
			newViewHeDaoTao.MaHeDaoTao = _maHeDaoTao;
			newViewHeDaoTao.TenHeDaoTao = _tenHeDaoTao;
			return newViewHeDaoTao;
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
			get { return "View_HeDaoTao"; }
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
		///  Returns a Typed ViewHeDaoTaoBase Entity 
		///</summary>
		public virtual ViewHeDaoTaoBase Copy()
		{
			//shallow copy entity
			ViewHeDaoTao copy = new ViewHeDaoTao();
				copy.MaHeDaoTao = this.MaHeDaoTao;
				copy.TenHeDaoTao = this.TenHeDaoTao;
			copy.AcceptChanges();
			return (ViewHeDaoTao)copy;
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
		///<returns>true if toObject is a <see cref="ViewHeDaoTaoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(ViewHeDaoTaoBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="ViewHeDaoTaoBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="ViewHeDaoTaoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="ViewHeDaoTaoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(ViewHeDaoTaoBase Object1, ViewHeDaoTaoBase Object2)
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
		public static object GetPropertyValueByName(ViewHeDaoTao entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaHeDaoTao":
					return entity.MaHeDaoTao;
				case "TenHeDaoTao":
					return entity.TenHeDaoTao;
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
			return GetPropertyValueByName(this as ViewHeDaoTao, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{3}{2}- MaHeDaoTao: {0}{2}- TenHeDaoTao: {1}{2}", 
				this.MaHeDaoTao,
				this.TenHeDaoTao,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the ViewHeDaoTao columns.
	/// </summary>
	[Serializable]
	public enum ViewHeDaoTaoColumn
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
		TenHeDaoTao
	}//End enum

} // end namespace