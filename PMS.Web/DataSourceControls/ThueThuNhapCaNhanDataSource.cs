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
	/// Represents the DataRepository.ThueThuNhapCaNhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThueThuNhapCaNhanDataSourceDesigner))]
	public class ThueThuNhapCaNhanDataSource : ProviderDataSource<ThueThuNhapCaNhan, ThueThuNhapCaNhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThueThuNhapCaNhanDataSource class.
		/// </summary>
		public ThueThuNhapCaNhanDataSource() : base(new ThueThuNhapCaNhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThueThuNhapCaNhanDataSourceView used by the ThueThuNhapCaNhanDataSource.
		/// </summary>
		protected ThueThuNhapCaNhanDataSourceView ThueThuNhapCaNhanView
		{
			get { return ( View as ThueThuNhapCaNhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThueThuNhapCaNhanDataSource control invokes to retrieve data.
		/// </summary>
		public ThueThuNhapCaNhanSelectMethod SelectMethod
		{
			get
			{
				ThueThuNhapCaNhanSelectMethod selectMethod = ThueThuNhapCaNhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThueThuNhapCaNhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThueThuNhapCaNhanDataSourceView class that is to be
		/// used by the ThueThuNhapCaNhanDataSource.
		/// </summary>
		/// <returns>An instance of the ThueThuNhapCaNhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ThueThuNhapCaNhan, ThueThuNhapCaNhanKey> GetNewDataSourceView()
		{
			return new ThueThuNhapCaNhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ThueThuNhapCaNhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThueThuNhapCaNhanDataSourceView : ProviderDataSourceView<ThueThuNhapCaNhan, ThueThuNhapCaNhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThueThuNhapCaNhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThueThuNhapCaNhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThueThuNhapCaNhanDataSourceView(ThueThuNhapCaNhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThueThuNhapCaNhanDataSource ThueThuNhapCaNhanOwner
		{
			get { return Owner as ThueThuNhapCaNhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThueThuNhapCaNhanSelectMethod SelectMethod
		{
			get { return ThueThuNhapCaNhanOwner.SelectMethod; }
			set { ThueThuNhapCaNhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThueThuNhapCaNhanService ThueThuNhapCaNhanProvider
		{
			get { return Provider as ThueThuNhapCaNhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThueThuNhapCaNhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThueThuNhapCaNhan> results = null;
			ThueThuNhapCaNhan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThueThuNhapCaNhanSelectMethod.Get:
					ThueThuNhapCaNhanKey entityKey  = new ThueThuNhapCaNhanKey();
					entityKey.Load(values);
					item = ThueThuNhapCaNhanProvider.Get(entityKey);
					results = new TList<ThueThuNhapCaNhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThueThuNhapCaNhanSelectMethod.GetAll:
                    results = ThueThuNhapCaNhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThueThuNhapCaNhanSelectMethod.GetPaged:
					results = ThueThuNhapCaNhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThueThuNhapCaNhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThueThuNhapCaNhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThueThuNhapCaNhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThueThuNhapCaNhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThueThuNhapCaNhanProvider.GetById(_id);
					results = new TList<ThueThuNhapCaNhan>();
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
			if ( SelectMethod == ThueThuNhapCaNhanSelectMethod.Get || SelectMethod == ThueThuNhapCaNhanSelectMethod.GetById )
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
				ThueThuNhapCaNhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThueThuNhapCaNhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThueThuNhapCaNhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThueThuNhapCaNhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThueThuNhapCaNhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThueThuNhapCaNhanDataSource class.
	/// </summary>
	public class ThueThuNhapCaNhanDataSourceDesigner : ProviderDataSourceDesigner<ThueThuNhapCaNhan, ThueThuNhapCaNhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThueThuNhapCaNhanDataSourceDesigner class.
		/// </summary>
		public ThueThuNhapCaNhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThueThuNhapCaNhanSelectMethod SelectMethod
		{
			get { return ((ThueThuNhapCaNhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThueThuNhapCaNhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThueThuNhapCaNhanDataSourceActionList

	/// <summary>
	/// Supports the ThueThuNhapCaNhanDataSourceDesigner class.
	/// </summary>
	internal class ThueThuNhapCaNhanDataSourceActionList : DesignerActionList
	{
		private ThueThuNhapCaNhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThueThuNhapCaNhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThueThuNhapCaNhanDataSourceActionList(ThueThuNhapCaNhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThueThuNhapCaNhanSelectMethod SelectMethod
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

	#endregion ThueThuNhapCaNhanDataSourceActionList
	
	#endregion ThueThuNhapCaNhanDataSourceDesigner
	
	#region ThueThuNhapCaNhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThueThuNhapCaNhanDataSource.SelectMethod property.
	/// </summary>
	public enum ThueThuNhapCaNhanSelectMethod
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
	
	#endregion ThueThuNhapCaNhanSelectMethod

	#region ThueThuNhapCaNhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThueThuNhapCaNhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThueThuNhapCaNhanFilter : SqlFilter<ThueThuNhapCaNhanColumn>
	{
	}
	
	#endregion ThueThuNhapCaNhanFilter

	#region ThueThuNhapCaNhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThueThuNhapCaNhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThueThuNhapCaNhanExpressionBuilder : SqlExpressionBuilder<ThueThuNhapCaNhanColumn>
	{
	}
	
	#endregion ThueThuNhapCaNhanExpressionBuilder	

	#region ThueThuNhapCaNhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThueThuNhapCaNhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThueThuNhapCaNhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThueThuNhapCaNhanProperty : ChildEntityProperty<ThueThuNhapCaNhanChildEntityTypes>
	{
	}
	
	#endregion ThueThuNhapCaNhanProperty
}

