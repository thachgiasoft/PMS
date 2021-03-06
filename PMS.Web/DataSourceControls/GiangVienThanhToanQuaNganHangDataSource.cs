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
	/// Represents the DataRepository.GiangVienThanhToanQuaNganHangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienThanhToanQuaNganHangDataSourceDesigner))]
	public class GiangVienThanhToanQuaNganHangDataSource : ProviderDataSource<GiangVienThanhToanQuaNganHang, GiangVienThanhToanQuaNganHangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangDataSource class.
		/// </summary>
		public GiangVienThanhToanQuaNganHangDataSource() : base(new GiangVienThanhToanQuaNganHangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienThanhToanQuaNganHangDataSourceView used by the GiangVienThanhToanQuaNganHangDataSource.
		/// </summary>
		protected GiangVienThanhToanQuaNganHangDataSourceView GiangVienThanhToanQuaNganHangView
		{
			get { return ( View as GiangVienThanhToanQuaNganHangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienThanhToanQuaNganHangDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienThanhToanQuaNganHangSelectMethod SelectMethod
		{
			get
			{
				GiangVienThanhToanQuaNganHangSelectMethod selectMethod = GiangVienThanhToanQuaNganHangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienThanhToanQuaNganHangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienThanhToanQuaNganHangDataSourceView class that is to be
		/// used by the GiangVienThanhToanQuaNganHangDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienThanhToanQuaNganHangDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienThanhToanQuaNganHang, GiangVienThanhToanQuaNganHangKey> GetNewDataSourceView()
		{
			return new GiangVienThanhToanQuaNganHangDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienThanhToanQuaNganHangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienThanhToanQuaNganHangDataSourceView : ProviderDataSourceView<GiangVienThanhToanQuaNganHang, GiangVienThanhToanQuaNganHangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienThanhToanQuaNganHangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienThanhToanQuaNganHangDataSourceView(GiangVienThanhToanQuaNganHangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienThanhToanQuaNganHangDataSource GiangVienThanhToanQuaNganHangOwner
		{
			get { return Owner as GiangVienThanhToanQuaNganHangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienThanhToanQuaNganHangSelectMethod SelectMethod
		{
			get { return GiangVienThanhToanQuaNganHangOwner.SelectMethod; }
			set { GiangVienThanhToanQuaNganHangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienThanhToanQuaNganHangService GiangVienThanhToanQuaNganHangProvider
		{
			get { return Provider as GiangVienThanhToanQuaNganHangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienThanhToanQuaNganHang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienThanhToanQuaNganHang> results = null;
			GiangVienThanhToanQuaNganHang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienThanhToanQuaNganHangSelectMethod.Get:
					GiangVienThanhToanQuaNganHangKey entityKey  = new GiangVienThanhToanQuaNganHangKey();
					entityKey.Load(values);
					item = GiangVienThanhToanQuaNganHangProvider.Get(entityKey);
					results = new TList<GiangVienThanhToanQuaNganHang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienThanhToanQuaNganHangSelectMethod.GetAll:
                    results = GiangVienThanhToanQuaNganHangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienThanhToanQuaNganHangSelectMethod.GetPaged:
					results = GiangVienThanhToanQuaNganHangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienThanhToanQuaNganHangSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienThanhToanQuaNganHangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienThanhToanQuaNganHangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienThanhToanQuaNganHangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienThanhToanQuaNganHangProvider.GetById(_id);
					results = new TList<GiangVienThanhToanQuaNganHang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == GiangVienThanhToanQuaNganHangSelectMethod.Get || SelectMethod == GiangVienThanhToanQuaNganHangSelectMethod.GetById )
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
				GiangVienThanhToanQuaNganHang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienThanhToanQuaNganHangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienThanhToanQuaNganHang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienThanhToanQuaNganHangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienThanhToanQuaNganHangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienThanhToanQuaNganHangDataSource class.
	/// </summary>
	public class GiangVienThanhToanQuaNganHangDataSourceDesigner : ProviderDataSourceDesigner<GiangVienThanhToanQuaNganHang, GiangVienThanhToanQuaNganHangKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangDataSourceDesigner class.
		/// </summary>
		public GiangVienThanhToanQuaNganHangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThanhToanQuaNganHangSelectMethod SelectMethod
		{
			get { return ((GiangVienThanhToanQuaNganHangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienThanhToanQuaNganHangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienThanhToanQuaNganHangDataSourceActionList

	/// <summary>
	/// Supports the GiangVienThanhToanQuaNganHangDataSourceDesigner class.
	/// </summary>
	internal class GiangVienThanhToanQuaNganHangDataSourceActionList : DesignerActionList
	{
		private GiangVienThanhToanQuaNganHangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienThanhToanQuaNganHangDataSourceActionList(GiangVienThanhToanQuaNganHangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThanhToanQuaNganHangSelectMethod SelectMethod
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

	#endregion GiangVienThanhToanQuaNganHangDataSourceActionList
	
	#endregion GiangVienThanhToanQuaNganHangDataSourceDesigner
	
	#region GiangVienThanhToanQuaNganHangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienThanhToanQuaNganHangDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienThanhToanQuaNganHangSelectMethod
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
		GetById
	}
	
	#endregion GiangVienThanhToanQuaNganHangSelectMethod

	#region GiangVienThanhToanQuaNganHangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThanhToanQuaNganHangFilter : SqlFilter<GiangVienThanhToanQuaNganHangColumn>
	{
	}
	
	#endregion GiangVienThanhToanQuaNganHangFilter

	#region GiangVienThanhToanQuaNganHangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThanhToanQuaNganHangExpressionBuilder : SqlExpressionBuilder<GiangVienThanhToanQuaNganHangColumn>
	{
	}
	
	#endregion GiangVienThanhToanQuaNganHangExpressionBuilder	

	#region GiangVienThanhToanQuaNganHangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienThanhToanQuaNganHangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThanhToanQuaNganHang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThanhToanQuaNganHangProperty : ChildEntityProperty<GiangVienThanhToanQuaNganHangChildEntityTypes>
	{
	}
	
	#endregion GiangVienThanhToanQuaNganHangProperty
}

