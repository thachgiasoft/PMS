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
	/// Represents the DataRepository.LopHocPhanClcAufCjlProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LopHocPhanClcAufCjlDataSourceDesigner))]
	public class LopHocPhanClcAufCjlDataSource : ProviderDataSource<LopHocPhanClcAufCjl, LopHocPhanClcAufCjlKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanClcAufCjlDataSource class.
		/// </summary>
		public LopHocPhanClcAufCjlDataSource() : base(new LopHocPhanClcAufCjlService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LopHocPhanClcAufCjlDataSourceView used by the LopHocPhanClcAufCjlDataSource.
		/// </summary>
		protected LopHocPhanClcAufCjlDataSourceView LopHocPhanClcAufCjlView
		{
			get { return ( View as LopHocPhanClcAufCjlDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LopHocPhanClcAufCjlDataSource control invokes to retrieve data.
		/// </summary>
		public LopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get
			{
				LopHocPhanClcAufCjlSelectMethod selectMethod = LopHocPhanClcAufCjlSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LopHocPhanClcAufCjlSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LopHocPhanClcAufCjlDataSourceView class that is to be
		/// used by the LopHocPhanClcAufCjlDataSource.
		/// </summary>
		/// <returns>An instance of the LopHocPhanClcAufCjlDataSourceView class.</returns>
		protected override BaseDataSourceView<LopHocPhanClcAufCjl, LopHocPhanClcAufCjlKey> GetNewDataSourceView()
		{
			return new LopHocPhanClcAufCjlDataSourceView(this, DefaultViewName);
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
	/// Supports the LopHocPhanClcAufCjlDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LopHocPhanClcAufCjlDataSourceView : ProviderDataSourceView<LopHocPhanClcAufCjl, LopHocPhanClcAufCjlKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LopHocPhanClcAufCjlDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LopHocPhanClcAufCjlDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LopHocPhanClcAufCjlDataSourceView(LopHocPhanClcAufCjlDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LopHocPhanClcAufCjlDataSource LopHocPhanClcAufCjlOwner
		{
			get { return Owner as LopHocPhanClcAufCjlDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get { return LopHocPhanClcAufCjlOwner.SelectMethod; }
			set { LopHocPhanClcAufCjlOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LopHocPhanClcAufCjlService LopHocPhanClcAufCjlProvider
		{
			get { return Provider as LopHocPhanClcAufCjlService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LopHocPhanClcAufCjl> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LopHocPhanClcAufCjl> results = null;
			LopHocPhanClcAufCjl item;
			count = 0;
			
			System.String _maLopHocPhan;

			switch ( SelectMethod )
			{
				case LopHocPhanClcAufCjlSelectMethod.Get:
					LopHocPhanClcAufCjlKey entityKey  = new LopHocPhanClcAufCjlKey();
					entityKey.Load(values);
					item = LopHocPhanClcAufCjlProvider.Get(entityKey);
					results = new TList<LopHocPhanClcAufCjl>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LopHocPhanClcAufCjlSelectMethod.GetAll:
                    results = LopHocPhanClcAufCjlProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LopHocPhanClcAufCjlSelectMethod.GetPaged:
					results = LopHocPhanClcAufCjlProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LopHocPhanClcAufCjlSelectMethod.Find:
					if ( FilterParameters != null )
						results = LopHocPhanClcAufCjlProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LopHocPhanClcAufCjlProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LopHocPhanClcAufCjlSelectMethod.GetByMaLopHocPhan:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = LopHocPhanClcAufCjlProvider.GetByMaLopHocPhan(_maLopHocPhan);
					results = new TList<LopHocPhanClcAufCjl>();
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
			if ( SelectMethod == LopHocPhanClcAufCjlSelectMethod.Get || SelectMethod == LopHocPhanClcAufCjlSelectMethod.GetByMaLopHocPhan )
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
				LopHocPhanClcAufCjl entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LopHocPhanClcAufCjlProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LopHocPhanClcAufCjl> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LopHocPhanClcAufCjlProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LopHocPhanClcAufCjlDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LopHocPhanClcAufCjlDataSource class.
	/// </summary>
	public class LopHocPhanClcAufCjlDataSourceDesigner : ProviderDataSourceDesigner<LopHocPhanClcAufCjl, LopHocPhanClcAufCjlKey>
	{
		/// <summary>
		/// Initializes a new instance of the LopHocPhanClcAufCjlDataSourceDesigner class.
		/// </summary>
		public LopHocPhanClcAufCjlDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanClcAufCjlSelectMethod SelectMethod
		{
			get { return ((LopHocPhanClcAufCjlDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LopHocPhanClcAufCjlDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LopHocPhanClcAufCjlDataSourceActionList

	/// <summary>
	/// Supports the LopHocPhanClcAufCjlDataSourceDesigner class.
	/// </summary>
	internal class LopHocPhanClcAufCjlDataSourceActionList : DesignerActionList
	{
		private LopHocPhanClcAufCjlDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LopHocPhanClcAufCjlDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LopHocPhanClcAufCjlDataSourceActionList(LopHocPhanClcAufCjlDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LopHocPhanClcAufCjlSelectMethod SelectMethod
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

	#endregion LopHocPhanClcAufCjlDataSourceActionList
	
	#endregion LopHocPhanClcAufCjlDataSourceDesigner
	
	#region LopHocPhanClcAufCjlSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LopHocPhanClcAufCjlDataSource.SelectMethod property.
	/// </summary>
	public enum LopHocPhanClcAufCjlSelectMethod
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
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion LopHocPhanClcAufCjlSelectMethod

	#region LopHocPhanClcAufCjlFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanClcAufCjl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanClcAufCjlFilter : SqlFilter<LopHocPhanClcAufCjlColumn>
	{
	}
	
	#endregion LopHocPhanClcAufCjlFilter

	#region LopHocPhanClcAufCjlExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanClcAufCjl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanClcAufCjlExpressionBuilder : SqlExpressionBuilder<LopHocPhanClcAufCjlColumn>
	{
	}
	
	#endregion LopHocPhanClcAufCjlExpressionBuilder	

	#region LopHocPhanClcAufCjlProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LopHocPhanClcAufCjlChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LopHocPhanClcAufCjl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LopHocPhanClcAufCjlProperty : ChildEntityProperty<LopHocPhanClcAufCjlChildEntityTypes>
	{
	}
	
	#endregion LopHocPhanClcAufCjlProperty
}

