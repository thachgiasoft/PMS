﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VwThongKeHoSoDaNopChuaNopTongHoSo.cs instead.
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
	/// An object representation of the 'vw_ThongKeHoSo_DaNop_ChuaNop_TongHoSo' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VwThongKeHoSoDaNopChuaNopTongHoSoBase")]
	public abstract partial class VwThongKeHoSoDaNopChuaNopTongHoSoBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		private System.Int32		  _maGiangVien = (int)0;
		
		/// <summary>
		/// MaGiangVienQuanLy : 
		/// </summary>
		private System.String		  _maGiangVienQuanLy = string.Empty;
		
		/// <summary>
		/// MaHoSoDaNop : 
		/// </summary>
		private System.String		  _maHoSoDaNop = null;
		
		/// <summary>
		/// MaHoSoChuaNop : 
		/// </summary>
		private System.String		  _maHoSoChuaNop = null;
		
		/// <summary>
		/// MaTongHoSo : 
		/// </summary>
		private System.String		  _maTongHoSo = null;
		
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
		/// Creates a new <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> instance.
		///</summary>
		public VwThongKeHoSoDaNopChuaNopTongHoSoBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maGiangVienQuanLy"></param>
		///<param name="_maHoSoDaNop"></param>
		///<param name="_maHoSoChuaNop"></param>
		///<param name="_maTongHoSo"></param>
		public VwThongKeHoSoDaNopChuaNopTongHoSoBase(System.Int32 _maGiangVien, System.String _maGiangVienQuanLy, System.String _maHoSoDaNop, System.String _maHoSoChuaNop, System.String _maTongHoSo)
		{
			this._maGiangVien = _maGiangVien;
			this._maGiangVienQuanLy = _maGiangVienQuanLy;
			this._maHoSoDaNop = _maHoSoDaNop;
			this._maHoSoChuaNop = _maHoSoChuaNop;
			this._maTongHoSo = _maTongHoSo;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VwThongKeHoSoDaNopChuaNopTongHoSo"/> instance.
		///</summary>
		///<param name="_maGiangVien"></param>
		///<param name="_maGiangVienQuanLy"></param>
		///<param name="_maHoSoDaNop"></param>
		///<param name="_maHoSoChuaNop"></param>
		///<param name="_maTongHoSo"></param>
		public static VwThongKeHoSoDaNopChuaNopTongHoSo CreateVwThongKeHoSoDaNopChuaNopTongHoSo(System.Int32 _maGiangVien, System.String _maGiangVienQuanLy, System.String _maHoSoDaNop, System.String _maHoSoChuaNop, System.String _maTongHoSo)
		{
			VwThongKeHoSoDaNopChuaNopTongHoSo newVwThongKeHoSoDaNopChuaNopTongHoSo = new VwThongKeHoSoDaNopChuaNopTongHoSo();
			newVwThongKeHoSoDaNopChuaNopTongHoSo.MaGiangVien = _maGiangVien;
			newVwThongKeHoSoDaNopChuaNopTongHoSo.MaGiangVienQuanLy = _maGiangVienQuanLy;
			newVwThongKeHoSoDaNopChuaNopTongHoSo.MaHoSoDaNop = _maHoSoDaNop;
			newVwThongKeHoSoDaNopChuaNopTongHoSo.MaHoSoChuaNop = _maHoSoChuaNop;
			newVwThongKeHoSoDaNopChuaNopTongHoSo.MaTongHoSo = _maTongHoSo;
			return newVwThongKeHoSoDaNopChuaNopTongHoSo;
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
		/// 	Gets or Sets the MaGiangVienQuanLy property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaGiangVienQuanLy
		{
			get
			{
				return this._maGiangVienQuanLy; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "MaGiangVienQuanLy does not allow null values.");
				if (_maGiangVienQuanLy == value)
					return;
					
				this._maGiangVienQuanLy = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaGiangVienQuanLy");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaHoSoDaNop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHoSoDaNop
		{
			get
			{
				return this._maHoSoDaNop; 
			}
			set
			{
				if (_maHoSoDaNop == value)
					return;
					
				this._maHoSoDaNop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHoSoDaNop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaHoSoChuaNop property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaHoSoChuaNop
		{
			get
			{
				return this._maHoSoChuaNop; 
			}
			set
			{
				if (_maHoSoChuaNop == value)
					return;
					
				this._maHoSoChuaNop = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaHoSoChuaNop");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the MaTongHoSo property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String MaTongHoSo
		{
			get
			{
				return this._maTongHoSo; 
			}
			set
			{
				if (_maTongHoSo == value)
					return;
					
				this._maTongHoSo = value;
				this._isDirty = true;
				
				OnPropertyChanged("MaTongHoSo");
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
			get { return "vw_ThongKeHoSo_DaNop_ChuaNop_TongHoSo"; }
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
		///  Returns a Typed VwThongKeHoSoDaNopChuaNopTongHoSoBase Entity 
		///</summary>
		public virtual VwThongKeHoSoDaNopChuaNopTongHoSoBase Copy()
		{
			//shallow copy entity
			VwThongKeHoSoDaNopChuaNopTongHoSo copy = new VwThongKeHoSoDaNopChuaNopTongHoSo();
				copy.MaGiangVien = this.MaGiangVien;
				copy.MaGiangVienQuanLy = this.MaGiangVienQuanLy;
				copy.MaHoSoDaNop = this.MaHoSoDaNop;
				copy.MaHoSoChuaNop = this.MaHoSoChuaNop;
				copy.MaTongHoSo = this.MaTongHoSo;
			copy.AcceptChanges();
			return (VwThongKeHoSoDaNopChuaNopTongHoSo)copy;
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
		///<returns>true if toObject is a <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VwThongKeHoSoDaNopChuaNopTongHoSoBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VwThongKeHoSoDaNopChuaNopTongHoSoBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VwThongKeHoSoDaNopChuaNopTongHoSoBase Object1, VwThongKeHoSoDaNopChuaNopTongHoSoBase Object2)
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
			if (Object1.MaGiangVienQuanLy != Object2.MaGiangVienQuanLy)
				equal = false;
			if (Object1.MaHoSoDaNop != null && Object2.MaHoSoDaNop != null )
			{
				if (Object1.MaHoSoDaNop != Object2.MaHoSoDaNop)
					equal = false;
			}
			else if (Object1.MaHoSoDaNop == null ^ Object1.MaHoSoDaNop == null )
			{
				equal = false;
			}
			if (Object1.MaHoSoChuaNop != null && Object2.MaHoSoChuaNop != null )
			{
				if (Object1.MaHoSoChuaNop != Object2.MaHoSoChuaNop)
					equal = false;
			}
			else if (Object1.MaHoSoChuaNop == null ^ Object1.MaHoSoChuaNop == null )
			{
				equal = false;
			}
			if (Object1.MaTongHoSo != null && Object2.MaTongHoSo != null )
			{
				if (Object1.MaTongHoSo != Object2.MaTongHoSo)
					equal = false;
			}
			else if (Object1.MaTongHoSo == null ^ Object1.MaTongHoSo == null )
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
		public static object GetPropertyValueByName(VwThongKeHoSoDaNopChuaNopTongHoSo entity, string propertyName)
		{
			switch (propertyName)
			{
				case "MaGiangVien":
					return entity.MaGiangVien;
				case "MaGiangVienQuanLy":
					return entity.MaGiangVienQuanLy;
				case "MaHoSoDaNop":
					return entity.MaHoSoDaNop;
				case "MaHoSoChuaNop":
					return entity.MaHoSoChuaNop;
				case "MaTongHoSo":
					return entity.MaTongHoSo;
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
			return GetPropertyValueByName(this as VwThongKeHoSoDaNopChuaNopTongHoSo, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{6}{5}- MaGiangVien: {0}{5}- MaGiangVienQuanLy: {1}{5}- MaHoSoDaNop: {2}{5}- MaHoSoChuaNop: {3}{5}- MaTongHoSo: {4}{5}", 
				this.MaGiangVien,
				this.MaGiangVienQuanLy,
				(this.MaHoSoDaNop == null) ? string.Empty : this.MaHoSoDaNop.ToString(),
			     
				(this.MaHoSoChuaNop == null) ? string.Empty : this.MaHoSoChuaNop.ToString(),
			     
				(this.MaTongHoSo == null) ? string.Empty : this.MaTongHoSo.ToString(),
			     
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VwThongKeHoSoDaNopChuaNopTongHoSo columns.
	/// </summary>
	[Serializable]
	public enum VwThongKeHoSoDaNopChuaNopTongHoSoColumn
	{
		/// <summary>
		/// MaGiangVien : 
		/// </summary>
		[EnumTextValue("MaGiangVien")]
		[ColumnEnum("MaGiangVien", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		MaGiangVien,
		/// <summary>
		/// MaGiangVienQuanLy : 
		/// </summary>
		[EnumTextValue("MaGiangVienQuanLy")]
		[ColumnEnum("MaGiangVienQuanLy", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 20)]
		MaGiangVienQuanLy,
		/// <summary>
		/// MaHoSoDaNop : 
		/// </summary>
		[EnumTextValue("MaHoSoDaNop")]
		[ColumnEnum("MaHoSoDaNop", typeof(System.String), System.Data.DbType.String, false, false, true)]
		MaHoSoDaNop,
		/// <summary>
		/// MaHoSoChuaNop : 
		/// </summary>
		[EnumTextValue("MaHoSoChuaNop")]
		[ColumnEnum("MaHoSoChuaNop", typeof(System.String), System.Data.DbType.String, false, false, true)]
		MaHoSoChuaNop,
		/// <summary>
		/// MaTongHoSo : 
		/// </summary>
		[EnumTextValue("MaTongHoSo")]
		[ColumnEnum("MaTongHoSo", typeof(System.String), System.Data.DbType.String, false, false, true)]
		MaTongHoSo
	}//End enum

} // end namespace
