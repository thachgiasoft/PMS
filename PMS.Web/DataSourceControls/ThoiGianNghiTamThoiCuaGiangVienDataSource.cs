﻿#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ThoiGianNghiTamThoiCuaGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner))]
	public class ThoiGianNghiTamThoiCuaGiangVienDataSource : ProviderDataSource<ThoiGianNghiTamThoiCuaGiangVien, ThoiGianNghiTamThoiCuaGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianNghiTamThoiCuaGiangVienDataSource class.
		/// </summary>
		public ThoiGianNghiTamThoiCuaGiangVienDataSource() : base(new ThoiGianNghiTamThoiCuaGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThoiGianNghiTamThoiCuaGiangVienDataSourceView used by the ThoiGianNghiTamThoiCuaGiangVienDataSource.
		/// </summary>
		protected ThoiGianNghiTamThoiCuaGiangVienDataSourceView ThoiGianNghiTamThoiCuaGiangVienView
		{
			get { return ( View as ThoiGianNghiTamThoiCuaGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThoiGianNghiTamThoiCuaGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public ThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get
			{
				ThoiGianNghiTamThoiCuaGiangVienSelectMethod selectMethod = ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThoiGianNghiTamThoiCuaGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThoiGianNghiTamThoiCuaGiangVienDataSourceView class that is to be
		/// used by the ThoiGianNghiTamThoiCuaGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ThoiGianNghiTamThoiCuaGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ThoiGianNghiTamThoiCuaGiangVien, ThoiGianNghiTamThoiCuaGiangVienKey> GetNewDataSourceView()
		{
			return new ThoiGianNghiTamThoiCuaGiangVienDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ThoiGianNghiTamThoiCuaGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThoiGianNghiTamThoiCuaGiangVienDataSourceView : ProviderDataSourceView<ThoiGianNghiTamThoiCuaGiangVien, ThoiGianNghiTamThoiCuaGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianNghiTamThoiCuaGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThoiGianNghiTamThoiCuaGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThoiGianNghiTamThoiCuaGiangVienDataSourceView(ThoiGianNghiTamThoiCuaGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThoiGianNghiTamThoiCuaGiangVienDataSource ThoiGianNghiTamThoiCuaGiangVienOwner
		{
			get { return Owner as ThoiGianNghiTamThoiCuaGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get { return ThoiGianNghiTamThoiCuaGiangVienOwner.SelectMethod; }
			set { ThoiGianNghiTamThoiCuaGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThoiGianNghiTamThoiCuaGiangVienService ThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get { return Provider as ThoiGianNghiTamThoiCuaGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThoiGianNghiTamThoiCuaGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThoiGianNghiTamThoiCuaGiangVien> results = null;
			ThoiGianNghiTamThoiCuaGiangVien item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.Get:
					ThoiGianNghiTamThoiCuaGiangVienKey entityKey  = new ThoiGianNghiTamThoiCuaGiangVienKey();
					entityKey.Load(values);
					item = ThoiGianNghiTamThoiCuaGiangVienProvider.Get(entityKey);
					results = new TList<ThoiGianNghiTamThoiCuaGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetAll:
                    results = ThoiGianNghiTamThoiCuaGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetPaged:
					results = ThoiGianNghiTamThoiCuaGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThoiGianNghiTamThoiCuaGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThoiGianNghiTamThoiCuaGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThoiGianNghiTamThoiCuaGiangVienProvider.GetById(_id);
					results = new TList<ThoiGianNghiTamThoiCuaGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = ThoiGianNghiTamThoiCuaGiangVienProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == ThoiGianNghiTamThoiCuaGiangVienSelectMethod.Get || SelectMethod == ThoiGianNghiTamThoiCuaGiangVienSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				ThoiGianNghiTamThoiCuaGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThoiGianNghiTamThoiCuaGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<ThoiGianNghiTamThoiCuaGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThoiGianNghiTamThoiCuaGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThoiGianNghiTamThoiCuaGiangVienDataSource class.
	/// </summary>
	public class ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner : ProviderDataSourceDesigner<ThoiGianNghiTamThoiCuaGiangVien, ThoiGianNghiTamThoiCuaGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner class.
		/// </summary>
		public ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get { return ((ThoiGianNghiTamThoiCuaGiangVienDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList : DesignerActionList
	{
		private ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList(ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianNghiTamThoiCuaGiangVienSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion ThoiGianNghiTamThoiCuaGiangVienDataSourceActionList
	
	#endregion ThoiGianNghiTamThoiCuaGiangVienDataSourceDesigner
	
	#region ThoiGianNghiTamThoiCuaGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThoiGianNghiTamThoiCuaGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ThoiGianNghiTamThoiCuaGiangVienSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion ThoiGianNghiTamThoiCuaGiangVienSelectMethod

	#region ThoiGianNghiTamThoiCuaGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianNghiTamThoiCuaGiangVienFilter : SqlFilter<ThoiGianNghiTamThoiCuaGiangVienColumn>
	{
	}
	
	#endregion ThoiGianNghiTamThoiCuaGiangVienFilter

	#region ThoiGianNghiTamThoiCuaGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianNghiTamThoiCuaGiangVienExpressionBuilder : SqlExpressionBuilder<ThoiGianNghiTamThoiCuaGiangVienColumn>
	{
	}
	
	#endregion ThoiGianNghiTamThoiCuaGiangVienExpressionBuilder	

	#region ThoiGianNghiTamThoiCuaGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThoiGianNghiTamThoiCuaGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianNghiTamThoiCuaGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianNghiTamThoiCuaGiangVienProperty : ChildEntityProperty<ThoiGianNghiTamThoiCuaGiangVienChildEntityTypes>
	{
	}
	
	#endregion ThoiGianNghiTamThoiCuaGiangVienProperty
}
